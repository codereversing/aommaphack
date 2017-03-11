using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AoMHackUI
{
    public partial class FormMain : Form
    {
        #region WinAPIs

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetWindowsHookEx(int hookType, IntPtr lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll")]
        static extern uint GetLastError();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeLibrary(IntPtr hModule);

        #endregion

        private IntPtr _hHook = IntPtr.Zero;
        private IntPtr _hModule = IntPtr.Zero;
        private Process _gameProcess = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _loadProcesses();
            _findDll();
        }

        private void _resetUI()
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                labelClassNameValue.Text = "N/A";
                labelHWNDValue.Text = "N/A";
                labelProcessIdValue.Text = "N/A";
                labelThreadIdValue.Text = "N/A";
                labelSuccessValue.Text = "N/A";

                labelWindowName.Text = "N/A";
                labelDllHandleValue.Text = "N/A";
                labelKeyboardProcAddressValue.Text = "N/A";
                labelHHOOKValue.Text = "N/A";
                labelLastErrorValue.Text = "N/A";

                buttonStop.Enabled = false;
            }));
        }

        private void _findDll()
        {
            string defaultDllName = "AoMHackDll.dll";
            string currentDirectory = Directory.GetCurrentDirectory();

            string fullPath = currentDirectory + Path.DirectorySeparatorChar + defaultDllName;
            if (File.Exists(fullPath))
            {
                textBoxDllPath.Text = fullPath;
            }
        }

        private void _loadProcesses()
        {
            comboBoxProcesses.Items.Clear();

            string aomPath = string.Empty;
            int index = 0;

            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                try
                {
                    comboBoxProcesses.Items.Add(process.MainModule.FileName);

                    string processPath = process.MainModule.FileName;
                    if (processPath.Contains("aomx.exe") || processPath.Contains("aomxnocd.exe"))
                    {
                        aomPath = processPath;
                        index = comboBoxProcesses.Items.Count - 1;
                        labelWindowNameValue.Text = process.MainWindowTitle;

                        var className = new StringBuilder(128);
                        int iRet = GetClassName(process.MainWindowHandle, className, className.Capacity);
                        labelClassNameValue.Text = iRet > 0 ? className.ToString() : string.Empty;

                        _gameProcess = process;
                        _gameProcess.EnableRaisingEvents = true;
                        _gameProcess.Exited += new EventHandler(_gameProcessExited);
                    }
                }
                catch(Win32Exception)
                {
                    // Ignore x64 processes
                }
            }

            if(!string.IsNullOrEmpty(aomPath))
            {
                comboBoxProcesses.SelectedIndex = index;
            }
        }

        private void _toggleStartStopButtons(bool startEnabled, bool stopEnabled)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                buttonStart.Enabled = startEnabled;
                buttonStop.Enabled = stopEnabled;
            }));
        }

        private void _gameProcessExited(object sender, EventArgs e)
        {
            _resetUI();

            FreeLibrary(_hModule);

            _toggleStartStopButtons(true, false);
        }

        private void _setLastError()
        {
            var lastError = GetLastError();
            labelLastErrorValue.Text = lastError.ToString();

            labelSuccessValue.Text = "No";
        }

        #region Button Handlers

        private void buttonFind_Click(object sender, EventArgs e)
        {
            using (var findDialog = new OpenFileDialog())
            {
                findDialog.Filter = ("Dll Files (*.dll)|*.dll");
                findDialog.FilterIndex = 1;

                if (findDialog.ShowDialog() == DialogResult.OK)
                {
                    string dllPath = findDialog.FileName;
                    textBoxDllPath.Text = dllPath;
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            _loadProcesses();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(_gameProcess == null)
            {
                MessageBox.Show("Could not initialize game process.");
                return;
            }

            if(string.IsNullOrEmpty(textBoxDllPath.Text))
            {
                MessageBox.Show("Map hack DLL path must be specified before starting.");
                return;
            }

            string windowName = labelWindowNameValue.Text;
            string className = labelClassNameValue.Text;
            if(string.IsNullOrEmpty(windowName) && string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Expected Age of Mythology window properties are missing.");
                return;
            }

            var hWnd = FindWindow(className, windowName);
            if(hWnd == IntPtr.Zero)
            {
                MessageBox.Show("Could not find main Age of Mythology window.");
                _setLastError();
                return;
            }

            labelHWNDValue.Text = hWnd.ToString("X");

            uint dwProcessId;
            var dwThreadId = GetWindowThreadProcessId(hWnd, out dwProcessId);
            if(dwProcessId == 0 || dwThreadId == 0)
            {
                MessageBox.Show("Could not get process/thread ids from window.");
                _setLastError();
                return;
            }

            labelProcessIdValue.Text = dwProcessId.ToString("X");
            labelThreadIdValue.Text = dwThreadId.ToString("X");

            string dllPath = textBoxDllPath.Text;
            var hModule = LoadLibrary(dllPath);
            if(hModule == IntPtr.Zero)
            {
                MessageBox.Show("Could not load map hack DLL.");
                _setLastError();
                return;
            }

            labelDllHandleValue.Text = hModule.ToString("X");
            _hModule = hModule;

            var pProc = GetProcAddress(hModule, "_KeyboardProc@12");
            if(pProc == IntPtr.Zero)
            {
                MessageBox.Show("Could not find _KeyboardProc@12 in DLL.");
                _setLastError();
                FreeLibrary(hModule);
                return;
            }

            labelKeyboardProcAddressValue.Text = pProc.ToString("X");

            const int WH_KEYBOARD = 2;
            _hHook = SetWindowsHookEx(WH_KEYBOARD, pProc, hModule, dwThreadId);
            if(_hHook == null)
            {
                MessageBox.Show("Could not install hook.");
                _setLastError();
                FreeLibrary(hModule);
                return;
            }

            labelHHOOKValue.Text = _hHook.ToString("X");

            labelSuccessValue.Text = "Yes";

            _toggleStartStopButtons(false, true);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _resetUI();

            var unhooked = UnhookWindowsHookEx(_hHook);
            if(!unhooked)
            {
                MessageBox.Show("Could not remove map hack from process.");
            }

            FreeLibrary(_hModule);
            
            _toggleStartStopButtons(true, false);
        }

        #endregion
    }
}
