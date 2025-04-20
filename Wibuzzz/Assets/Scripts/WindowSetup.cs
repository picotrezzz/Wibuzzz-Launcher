using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class WindowSetup : MonoBehaviour
{
#if UNITY_STANDALONE_WIN
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();

    [DllImport("user32.dll")]
    private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

    [DllImport("user32.dll")]
    private static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

    const int GWL_STYLE = -16;
    const uint WS_POPUP = 0x80000000;
    const uint SWP_SHOWWINDOW = 0x0040;

    void Start()
    {
        IntPtr hwnd = GetActiveWindow();

        // Hacer borderless
        SetWindowLong(hwnd, GWL_STYLE, WS_POPUP);

        // Tamaño deseado (mitad de la pantalla)
        int width = Screen.currentResolution.width / 2;
        int height = Screen.currentResolution.height / 2;

        int x = (Screen.currentResolution.width - width) / 2;
        int y = (Screen.currentResolution.height - height) / 2;

        SetWindowPos(hwnd, 0, x, y, width, height, SWP_SHOWWINDOW);
    }
#endif
}
