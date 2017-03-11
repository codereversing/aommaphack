#include <Windows.h>
#include <WinUser.h>
#include <tchar.h>

extern "C"
{

using pToggleMapFnc = void (__cdecl *)(bool bEnableBlackOverlay, bool bEnableFogOfWar);

const bool IsBaseGame()
{
    const HMODULE hSteamDll = GetModuleHandle(L"Steam.dll");

    return hSteamDll == nullptr;
}

const DWORD_PTR GetFunctionAddress(const DWORD_PTR dwOffset)
{
    const HMODULE hGameExecutableBase = (HMODULE)0x00400000;
    const HMODULE hGameExecutableExtended = GetModuleHandle(L"aomx.exe");

    const DWORD_PTR dwBaseAddress = IsBaseGame() ? (DWORD_PTR)hGameExecutableBase :
        (DWORD_PTR)hGameExecutableExtended;

    return dwBaseAddress + dwOffset;
}

void ToggleMapStatus(const bool bEnableBlackOverlay, const bool bEnableFogOfWar)
{
    const DWORD_PTR dwOffsetMapToggleBase = 0x004AAEE0;
    const DWORD_PTR dwOffsetMapToggleExtended = 0x00505D20;

    const DWORD_PTR dwOffsetMapToggle = IsBaseGame() ? dwOffsetMapToggleBase : dwOffsetMapToggleExtended;
    pToggleMapFnc pToggleMap = (pToggleMapFnc)GetFunctionAddress(dwOffsetMapToggle);

    pToggleMap(bEnableBlackOverlay, bEnableFogOfWar);
}

LRESULT __declspec(dllexport) CALLBACK KeyboardProc(int nCode, WPARAM wParam, LPARAM lParam)
{
    if (nCode == HC_ACTION && ((DWORD)(lParam & 0x800000000) == 0))
    {
        switch (wParam)
        {
        case '7': // '7' : Reveal vision on entire map
            ToggleMapStatus(false, false);
            break;

        case '8': // '8' : Keep black overlay, show enemy TCs
            ToggleMapStatus(false, true);
            break;

        case '9': // '9' : Show revealed map with no features
            ToggleMapStatus(false, true);
            break;

        case '0': // '10' : Put black overlay back
            ToggleMapStatus(true, true);
            break;

        default: break;
        }
    }

    return CallNextHookEx(nullptr, nCode, wParam, lParam);
}

int APIENTRY DllMain(HMODULE hModule, DWORD dwReason, LPVOID lpReserved)
{
    switch (dwReason)
    {
    case DLL_PROCESS_ATTACH:
        (void)DisableThreadLibraryCalls(hModule);
        break;

    case DLL_PROCESS_DETACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
        break;
    }

    return TRUE;
}

}
