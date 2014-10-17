using System;

namespace Win32
{
	/// <summary>
	/// Flags for <see cref="Window.SetWindowPos"/>.
	/// </summary>
	[Flags]
	public enum SWP : uint
	{
		/// <summary>
		/// Retains the current size.
		/// </summary>
		NOSIZE=0x0001,

		/// <summary>
		/// Retains the current position.
		/// </summary>
		NOMOVE=0x0002,

		/// <summary>
		/// Retains the current Z order.
		/// </summary>
		NOZORDER=0x0004,

		/// <summary>
		/// Does not redraw changes.
		/// </summary>
		NOREDRAW=0x0008,

		/// <summary>
		/// Does not activate the window.
		/// </summary>
		NOACTIVATE=0x0010,

		/// <summary>
		/// Applies new frame styles. <b>WM_NCCALCSIZE</b> message is send, even if the window's size is not being changed.
		/// </summary>
		FRAMECHANGED=0x0020,

		/// <summary>
		/// Draws a frame (defined in the window's class description) around the window.
		/// Same as <see cref="FRAMECHANGED"/>.
		/// </summary>
		DRAWFRAME=FRAMECHANGED,

		/// <summary>
		/// Displays the window.
		/// </summary>
		SHOWWINDOW=0x0040,

		/// <summary>
		/// Hides the window.
		/// </summary>
		HIDEWINDOW=0x0080,

		/// <summary>
		/// Discards the entire contents of the client area.
		/// </summary>
		NOCOPYBITS=0x0100,

		/// <summary>
		/// Does not change the owner window's position in the Z order.
		/// </summary>
		NOOWNERZORDER=0x0200,

		/// <summary>
		/// Same as <see cref="NOOWNERZORDER"/>.
		/// </summary>
		NOREPOSITION=NOOWNERZORDER,

		/// <summary>
		/// Prevents the window from receiving the <b>WM_WINDOWPOSCHANGING</b> message.
		/// </summary>
		NOSENDCHANGING=0x0400,

		/// <summary>
		/// Prevents generation of the <b>WM_SYNCPAINT</b> message.
		/// </summary>
		DEFERERASE=0x2000,

		/// <summary>
		/// If the calling thread and the thread that owns the window are attached to different input queues,
		/// the system posts the request to the thread that owns the window. This prevents the calling thread
		/// from blocking its execution while other threads process the request.
		/// </summary>
		ASYNCWINDOWPOS=0x4000,
	}
}
