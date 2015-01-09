namespace Win32
{
	/// <summary>
	/// Indicates the position of the cursor hot spot.
	/// </summary>
	public enum HT : int
	{
		/// <summary>
		/// On the screen background or on a dividing line between windows (same as <see cref="HT.NOWHERE"/>, except that the DefWindowProc function produces a system beep to indicate an error).
		/// </summary>
		ERROR=-2,

		/// <summary>
		/// In a window currently covered by another window in the same thread (the message will be sent to underlying windows in the same thread until one of them returns a code that is not <see cref="HT.TRANSPARENT"/>).
		/// </summary>
		TRANSPARENT=-1,

		/// <summary>
		/// On the screen background or on a dividing line between windows.
		/// </summary>
		NOWHERE=0,

		/// <summary>
		/// In a client area.
		/// </summary>
		CLIENT=1,

		/// <summary>
		/// In a title bar.
		/// </summary>
		CAPTION=2,

		/// <summary>
		/// In a window menu or in a Close button in a child window.
		/// </summary>
		SYSMENU=3,

		/// <summary>
		/// In a size box (same as <see cref="HT.SIZE"/>).
		/// </summary>
		GROWBOX=4,

		/// <summary>
		/// In a size box (same as <see cref="HT.GROWBOX"/>).
		/// </summary>
		SIZE=4,

		/// <summary>
		/// In a menu.
		/// </summary>
		MENU=5,

		/// <summary>
		/// In a horizontal scroll bar.
		/// </summary>
		HSCROLL=6,

		/// <summary>
		/// In the vertical scroll bar.
		/// </summary>
		VSCROLL=7,

		/// <summary>
		/// In a Minimize button.
		/// </summary>
		MINBUTTON=8,

		/// <summary>
		/// In a Minimize button.
		/// </summary>
		REDUCE=8,

		/// <summary>
		/// In a Maximize button.
		/// </summary>
		MAXBUTTON=9,

		/// <summary>
		/// In a Maximize button.
		/// </summary>
		ZOOM=9,

		/// <summary>
		/// In the left border of a resizable window (the user can click the mouse to resize the window horizontally).
		/// </summary>
		LEFT=10,

		/// <summary>
		/// In the right border of a resizable window (the user can click the mouse to resize the window horizontally).
		/// </summary>
		RIGHT=11,

		/// <summary>
		/// In the upper-horizontal border of a window.
		/// </summary>
		TOP=12,

		/// <summary>
		/// In the upper-left corner of a window border.
		/// </summary>
		TOPLEFT=13,

		/// <summary>
		/// In the upper-right corner of a window border.
		/// </summary>
		TOPRIGHT=14,

		/// <summary>
		/// In the lower-horizontal border of a resizable window (the user can click the mouse to resize the window vertically).
		/// </summary>
		BOTTOM=15,

		/// <summary>
		/// In the lower-left corner of a border of a resizable window (the user can click the mouse to resize the window diagonally).
		/// </summary>
		BOTTOMLEFT=16,

		/// <summary>
		/// In the lower-right corner of a border of a resizable window (the user can click the mouse to resize the window diagonally).
		/// </summary>
		BOTTOMRIGHT=17,

		/// <summary>
		/// In the border of a window that does not have a sizing border.
		/// </summary>
		BORDER=18,

		/// <summary>
		/// In a Close button.
		/// </summary>
		CLOSE=20,

		/// <summary>
		/// In a Help button.
		/// </summary>
		HELP=21,
	}
}
