namespace AoMHackUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelProcesses = new System.Windows.Forms.Label();
            this.comboBoxProcesses = new System.Windows.Forms.ComboBox();
            this.labelHackDllPath = new System.Windows.Forms.Label();
            this.textBoxDllPath = new System.Windows.Forms.TextBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelHHOOK = new System.Windows.Forms.Label();
            this.labelKeyboardProcAddress = new System.Windows.Forms.Label();
            this.labelDllHandle = new System.Windows.Forms.Label();
            this.labelThreadId = new System.Windows.Forms.Label();
            this.labelProcessId = new System.Windows.Forms.Label();
            this.labelHWND = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.labelLastError = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelHWNDValue = new System.Windows.Forms.Label();
            this.labelProcessIdValue = new System.Windows.Forms.Label();
            this.labelThreadIdValue = new System.Windows.Forms.Label();
            this.labelSuccessValue = new System.Windows.Forms.Label();
            this.labelDllHandleValue = new System.Windows.Forms.Label();
            this.labelKeyboardProcAddressValue = new System.Windows.Forms.Label();
            this.labelHHOOKValue = new System.Windows.Forms.Label();
            this.labelLastErrorValue = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            this.labelWindowName = new System.Windows.Forms.Label();
            this.labelClassNameValue = new System.Windows.Forms.Label();
            this.labelWindowNameValue = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProcesses
            // 
            this.labelProcesses.AutoSize = true;
            this.labelProcesses.Location = new System.Drawing.Point(13, 32);
            this.labelProcesses.Name = "labelProcesses";
            this.labelProcesses.Size = new System.Drawing.Size(48, 13);
            this.labelProcesses.TabIndex = 0;
            this.labelProcesses.Text = "Process:";
            // 
            // comboBoxProcesses
            // 
            this.comboBoxProcesses.FormattingEnabled = true;
            this.comboBoxProcesses.Location = new System.Drawing.Point(74, 29);
            this.comboBoxProcesses.Name = "comboBoxProcesses";
            this.comboBoxProcesses.Size = new System.Drawing.Size(454, 21);
            this.comboBoxProcesses.TabIndex = 1;
            // 
            // labelHackDllPath
            // 
            this.labelHackDllPath.AutoSize = true;
            this.labelHackDllPath.Location = new System.Drawing.Point(13, 64);
            this.labelHackDllPath.Name = "labelHackDllPath";
            this.labelHackDllPath.Size = new System.Drawing.Size(55, 13);
            this.labelHackDllPath.TabIndex = 2;
            this.labelHackDllPath.Text = "DLL Path:";
            // 
            // textBoxDllPath
            // 
            this.textBoxDllPath.Location = new System.Drawing.Point(74, 61);
            this.textBoxDllPath.Name = "textBoxDllPath";
            this.textBoxDllPath.ReadOnly = true;
            this.textBoxDllPath.Size = new System.Drawing.Size(454, 20);
            this.textBoxDllPath.TabIndex = 3;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelWindowNameValue);
            this.groupBoxInfo.Controls.Add(this.labelClassNameValue);
            this.groupBoxInfo.Controls.Add(this.labelWindowName);
            this.groupBoxInfo.Controls.Add(this.labelClassName);
            this.groupBoxInfo.Controls.Add(this.labelLastErrorValue);
            this.groupBoxInfo.Controls.Add(this.labelHHOOKValue);
            this.groupBoxInfo.Controls.Add(this.labelKeyboardProcAddressValue);
            this.groupBoxInfo.Controls.Add(this.labelDllHandleValue);
            this.groupBoxInfo.Controls.Add(this.labelSuccessValue);
            this.groupBoxInfo.Controls.Add(this.labelThreadIdValue);
            this.groupBoxInfo.Controls.Add(this.labelProcessIdValue);
            this.groupBoxInfo.Controls.Add(this.labelHWNDValue);
            this.groupBoxInfo.Controls.Add(this.labelLastError);
            this.groupBoxInfo.Controls.Add(this.labelSuccess);
            this.groupBoxInfo.Controls.Add(this.labelHHOOK);
            this.groupBoxInfo.Controls.Add(this.labelKeyboardProcAddress);
            this.groupBoxInfo.Controls.Add(this.labelDllHandle);
            this.groupBoxInfo.Controls.Add(this.labelThreadId);
            this.groupBoxInfo.Controls.Add(this.labelProcessId);
            this.groupBoxInfo.Controls.Add(this.labelHWND);
            this.groupBoxInfo.Location = new System.Drawing.Point(13, 91);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(596, 173);
            this.groupBoxInfo.TabIndex = 4;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // labelHHOOK
            // 
            this.labelHHOOK.AutoSize = true;
            this.labelHHOOK.Location = new System.Drawing.Point(260, 108);
            this.labelHHOOK.Name = "labelHHOOK";
            this.labelHHOOK.Size = new System.Drawing.Size(49, 13);
            this.labelHHOOK.TabIndex = 5;
            this.labelHHOOK.Text = "HHOOK:";
            // 
            // labelKeyboardProcAddress
            // 
            this.labelKeyboardProcAddress.AutoSize = true;
            this.labelKeyboardProcAddress.Location = new System.Drawing.Point(260, 81);
            this.labelKeyboardProcAddress.Name = "labelKeyboardProcAddress";
            this.labelKeyboardProcAddress.Size = new System.Drawing.Size(118, 13);
            this.labelKeyboardProcAddress.TabIndex = 4;
            this.labelKeyboardProcAddress.Text = "KeyboardProc Address:";
            // 
            // labelDllHandle
            // 
            this.labelDllHandle.AutoSize = true;
            this.labelDllHandle.Location = new System.Drawing.Point(260, 54);
            this.labelDllHandle.Name = "labelDllHandle";
            this.labelDllHandle.Size = new System.Drawing.Size(67, 13);
            this.labelDllHandle.TabIndex = 3;
            this.labelDllHandle.Text = "DLL Handle:";
            // 
            // labelThreadId
            // 
            this.labelThreadId.AutoSize = true;
            this.labelThreadId.Location = new System.Drawing.Point(7, 108);
            this.labelThreadId.Name = "labelThreadId";
            this.labelThreadId.Size = new System.Drawing.Size(58, 13);
            this.labelThreadId.TabIndex = 2;
            this.labelThreadId.Text = "Thread ID:";
            // 
            // labelProcessId
            // 
            this.labelProcessId.AutoSize = true;
            this.labelProcessId.Location = new System.Drawing.Point(7, 81);
            this.labelProcessId.Name = "labelProcessId";
            this.labelProcessId.Size = new System.Drawing.Size(62, 13);
            this.labelProcessId.TabIndex = 1;
            this.labelProcessId.Text = "Process ID:";
            // 
            // labelHWND
            // 
            this.labelHWND.AutoSize = true;
            this.labelHWND.Location = new System.Drawing.Point(7, 54);
            this.labelHWND.Name = "labelHWND";
            this.labelHWND.Size = new System.Drawing.Size(45, 13);
            this.labelHWND.TabIndex = 0;
            this.labelHWND.Text = "HWND:";
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Location = new System.Drawing.Point(7, 135);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(51, 13);
            this.labelSuccess.TabIndex = 5;
            this.labelSuccess.Text = "Success:";
            // 
            // labelLastError
            // 
            this.labelLastError.AutoSize = true;
            this.labelLastError.Location = new System.Drawing.Point(260, 135);
            this.labelLastError.Name = "labelLastError";
            this.labelLastError.Size = new System.Drawing.Size(54, 13);
            this.labelLastError.TabIndex = 6;
            this.labelLastError.Text = "Last error:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(454, 270);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(535, 270);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(534, 29);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(534, 59);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 9;
            this.buttonFind.Text = "Find ...";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelHWNDValue
            // 
            this.labelHWNDValue.AutoSize = true;
            this.labelHWNDValue.Location = new System.Drawing.Point(71, 54);
            this.labelHWNDValue.Name = "labelHWNDValue";
            this.labelHWNDValue.Size = new System.Drawing.Size(27, 13);
            this.labelHWNDValue.TabIndex = 7;
            this.labelHWNDValue.Text = "N/A";
            // 
            // labelProcessIdValue
            // 
            this.labelProcessIdValue.AutoSize = true;
            this.labelProcessIdValue.Location = new System.Drawing.Point(71, 81);
            this.labelProcessIdValue.Name = "labelProcessIdValue";
            this.labelProcessIdValue.Size = new System.Drawing.Size(27, 13);
            this.labelProcessIdValue.TabIndex = 8;
            this.labelProcessIdValue.Text = "N/A";
            // 
            // labelThreadIdValue
            // 
            this.labelThreadIdValue.AutoSize = true;
            this.labelThreadIdValue.Location = new System.Drawing.Point(71, 108);
            this.labelThreadIdValue.Name = "labelThreadIdValue";
            this.labelThreadIdValue.Size = new System.Drawing.Size(27, 13);
            this.labelThreadIdValue.TabIndex = 9;
            this.labelThreadIdValue.Text = "N/A";
            // 
            // labelSuccessValue
            // 
            this.labelSuccessValue.AutoSize = true;
            this.labelSuccessValue.Location = new System.Drawing.Point(71, 135);
            this.labelSuccessValue.Name = "labelSuccessValue";
            this.labelSuccessValue.Size = new System.Drawing.Size(27, 13);
            this.labelSuccessValue.TabIndex = 10;
            this.labelSuccessValue.Text = "N/A";
            // 
            // labelDllHandleValue
            // 
            this.labelDllHandleValue.AutoSize = true;
            this.labelDllHandleValue.Location = new System.Drawing.Point(391, 54);
            this.labelDllHandleValue.Name = "labelDllHandleValue";
            this.labelDllHandleValue.Size = new System.Drawing.Size(27, 13);
            this.labelDllHandleValue.TabIndex = 11;
            this.labelDllHandleValue.Text = "N/A";
            // 
            // labelKeyboardProcAddressValue
            // 
            this.labelKeyboardProcAddressValue.AutoSize = true;
            this.labelKeyboardProcAddressValue.Location = new System.Drawing.Point(391, 81);
            this.labelKeyboardProcAddressValue.Name = "labelKeyboardProcAddressValue";
            this.labelKeyboardProcAddressValue.Size = new System.Drawing.Size(27, 13);
            this.labelKeyboardProcAddressValue.TabIndex = 13;
            this.labelKeyboardProcAddressValue.Text = "N/A";
            // 
            // labelHHOOKValue
            // 
            this.labelHHOOKValue.AutoSize = true;
            this.labelHHOOKValue.Location = new System.Drawing.Point(391, 108);
            this.labelHHOOKValue.Name = "labelHHOOKValue";
            this.labelHHOOKValue.Size = new System.Drawing.Size(27, 13);
            this.labelHHOOKValue.TabIndex = 14;
            this.labelHHOOKValue.Text = "N/A";
            // 
            // labelLastErrorValue
            // 
            this.labelLastErrorValue.AutoSize = true;
            this.labelLastErrorValue.Location = new System.Drawing.Point(391, 135);
            this.labelLastErrorValue.Name = "labelLastErrorValue";
            this.labelLastErrorValue.Size = new System.Drawing.Size(27, 13);
            this.labelLastErrorValue.TabIndex = 15;
            this.labelLastErrorValue.Text = "N/A";
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(7, 27);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(64, 13);
            this.labelClassName.TabIndex = 16;
            this.labelClassName.Text = "Class name:";
            // 
            // labelWindowName
            // 
            this.labelWindowName.AutoSize = true;
            this.labelWindowName.Location = new System.Drawing.Point(260, 27);
            this.labelWindowName.Name = "labelWindowName";
            this.labelWindowName.Size = new System.Drawing.Size(78, 13);
            this.labelWindowName.TabIndex = 17;
            this.labelWindowName.Text = "Window name:";
            // 
            // labelClassNameValue
            // 
            this.labelClassNameValue.AutoSize = true;
            this.labelClassNameValue.Location = new System.Drawing.Point(71, 27);
            this.labelClassNameValue.Name = "labelClassNameValue";
            this.labelClassNameValue.Size = new System.Drawing.Size(27, 13);
            this.labelClassNameValue.TabIndex = 18;
            this.labelClassNameValue.Text = "N/A";
            // 
            // labelWindowNameValue
            // 
            this.labelWindowNameValue.AutoSize = true;
            this.labelWindowNameValue.Location = new System.Drawing.Point(391, 27);
            this.labelWindowNameValue.Name = "labelWindowNameValue";
            this.labelWindowNameValue.Size = new System.Drawing.Size(27, 13);
            this.labelWindowNameValue.TabIndex = 19;
            this.labelWindowNameValue.Text = "N/A";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 307);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.textBoxDllPath);
            this.Controls.Add(this.labelHackDllPath);
            this.Controls.Add(this.comboBoxProcesses);
            this.Controls.Add(this.labelProcesses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Age of Mythology Map Hack";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProcesses;
        private System.Windows.Forms.ComboBox comboBoxProcesses;
        private System.Windows.Forms.Label labelHackDllPath;
        private System.Windows.Forms.TextBox textBoxDllPath;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelHHOOK;
        private System.Windows.Forms.Label labelKeyboardProcAddress;
        private System.Windows.Forms.Label labelDllHandle;
        private System.Windows.Forms.Label labelThreadId;
        private System.Windows.Forms.Label labelProcessId;
        private System.Windows.Forms.Label labelHWND;
        private System.Windows.Forms.Label labelLastError;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelLastErrorValue;
        private System.Windows.Forms.Label labelHHOOKValue;
        private System.Windows.Forms.Label labelKeyboardProcAddressValue;
        private System.Windows.Forms.Label labelDllHandleValue;
        private System.Windows.Forms.Label labelSuccessValue;
        private System.Windows.Forms.Label labelThreadIdValue;
        private System.Windows.Forms.Label labelProcessIdValue;
        private System.Windows.Forms.Label labelHWNDValue;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.Label labelClassNameValue;
        private System.Windows.Forms.Label labelWindowName;
        private System.Windows.Forms.Label labelWindowNameValue;
    }
}

