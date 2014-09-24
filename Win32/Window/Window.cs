using System.Runtime.InteropServices;
using System.Security;
using HDC=System.IntPtr;
using HRGN=System.IntPtr;
using HWND=System.IntPtr;

namespace Win32
{
	/// <summary>
	/// Class for managing windows (not the OS, just the windows).
	/// </summary>
	[SuppressUnmanagedCodeSecurity()]
	public static class Window
	{
		const string DLLName="User32.dll";

		/// <summary>
		/// Retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen.
		/// </summary>
		/// <param name="hWnd">The handle to the window. Set <see cref="HWND.Zero"/> to retrieve the device context of the screen.</param>
		/// <returns>If successful the handle to the device context, otherwise 0 (zero) is returned.</returns>
		[DllImport(DLLName)]
		public static extern HDC GetDC(HWND hWnd);

		/// <summary>
		/// Retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen.
		/// </summary>
		/// <param name="hWnd">The handle to the window. Set <see cref="HWND.Zero"/> to retrieve the device context of the screen.</param>
		/// <param name="hrgnClip">A clipping region that may be combined with the visible region of the DC. If the value of flags is
		/// <see cref="DCX.INTERSECTRGN"/> or <see cref="DCX.EXCLUDERGN"/>, then the operating system assumes ownership of the region
		/// and will automatically delete it when it is no longer needed. In this case, the application should not use or delete the
		/// region after a successful call to <see cref="GetDCEx"/>.</param>
		/// <param name="flags">A <see cref="DCX"/>-bitmask specifying how the DC is created.</param>
		/// <returns>If successful the handle to the device context, otherwise 0 (zero) is returned.</returns>
		[DllImport(DLLName)]
		public static extern HDC GetDCEx(HWND hWnd, HRGN hrgnClip, DCX flags);

		/// <summary>
		/// Retrieves a handle to a device context (DC) for the entire window, including title bar, menus, and scroll bars, or of the primary monitor device.
		/// </summary>
		/// <param name="hWnd">The handle to the window. Set <see cref="HWND.Zero"/> to retrieve the device context of the primary monitor device.</param>
		/// <returns>If successful the handle to the device context, otherwise 0 (zero) is returned.</returns>
		[DllImport(DLLName)]
		public static extern HDC GetWindowDC(HWND hWnd);

		/// <summary>
		/// Releases a device context (DC).
		/// </summary>
		/// <param name="hWnd">The handle to the window whose DC is to be released.</param>
		/// <param name="hDC">The handle to the DC to be released.</param>
		/// <returns>1 (one) if the device context was released, otherwise 0 (zero) is returned.</returns>
		[DllImport(DLLName)]
		public static extern int ReleaseDC(HWND hWnd, HDC hDC);

		/// <summary>
		/// Retrieves a handle of a window from a device context (DC).
		/// </summary>
		/// <param name="hDC">The handle to the device context.</param>
		/// <returns>If successful the handle to the window, otherwise 0 (zero) is returned.</returns>
		[DllImport(DLLName)]
		public static extern HWND WindowFromDC(HDC hDC);

		/// <summary>
		/// Changes the size, position, and Z order of a child, pop-up, or top-level window.
		/// </summary>
		/// <param name="hWnd">The handle to the window.</param>
		/// <param name="hWndInsertAfter">The handle to the window to precede the positioned window in the Z order.
		/// Can also be one of <see cref="TOP"/>, <see cref="BOTTOM"/>, <see cref="TOPMOST"/> and <see cref="NOTOPMOST"/>.</param>
		/// <param name="X">The new position of the left side of the window, in client coordinates. </param>
		/// <param name="Y">The new position of the top of the window, in client coordinates. </param>
		/// <param name="cx">The new width of the window, in pixels. </param>
		/// <param name="cy">The new height of the window, in pixels. </param>
		/// <param name="uFlags">A <see cref="SWP"/> specifying window sizing and positioning flags.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool SetWindowPos(HWND hWnd, HWND hWndInsertAfter, int X, int Y, int cx, int cy, SWP uFlags);

		/// <summary>
		/// Places the window at the bottom of the Z order.
		/// </summary>
		public static readonly HWND BOTTOM=(HWND)1;

		/// <summary>
		/// Places the window at the top of the Z order.
		/// </summary>
		public static readonly HWND TOP=(HWND)0;

		/// <summary>
		/// Places the window above all non-topmost windows.
		/// </summary>
		public static readonly HWND TOPMOST=(HWND)(-1);

		/// <summary>
		/// Places the window above all non-topmost windows (that is, behind all topmost windows).
		/// </summary>
		public static readonly HWND NOTOPMOST=(HWND)(-2);
	}
}
