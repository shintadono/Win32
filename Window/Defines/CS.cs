namespace Win32
{
	/// <summary>
	/// Window class styles.
	/// </summary>
	public static class CS
	{
		/// <summary>
		/// Redraws the entire window if a movement or size adjustment changes the height of the client area.
		/// </summary>
		public const int VREDRAW=0x00000001;

		/// <summary>
		/// Redraws the entire window if a movement or size adjustment changes the width of the client area.
		/// </summary>
		public const int HREDRAW=0x00000002;

		/// <summary>
		/// Undocumented.
		/// </summary>
		public const int KEYCVTWINDOW=0x00000004;

		/// <summary>
		/// Sends a double-click message to the window procedure when the user double-clicks the mouse
		/// while the cursor is within a window belonging to the class.
		/// </summary>
		public const int DBLCLKS=0x00000008;

		/// <summary>
		/// Reserved.
		/// </summary>
		public const int h10=0x00000010;

		/// <summary>
		/// Allocates a unique device context for each window in the class.
		/// </summary>
		public const int OWNDC=0x00000020;

		/// <summary>
		/// Allocates one device context to be shared by all windows in the class.
		/// </summary>
		public const int CLASSDC=0x00000040;

		/// <summary>
		/// Sets the clipping rectangle of the child window to that of the parent window so that the
		/// child can draw on the parent.
		/// </summary>
		public const int PARENTDC=0x00000080;

		/// <summary>
		/// Undocumented.
		/// </summary>
		public const int NOKEYCVT=0x00000100;

		/// <summary>
		/// Disables <b>Close</b> on the window menu.
		/// </summary>
		public const int NOCLOSE=0x00000200;

		/// <summary>
		/// Reserved.
		/// </summary>
		public const int h400=0x00000400;

		/// <summary>
		/// Saves, as a bitmap, the portion of the screen image obscured by a window of this class.
		/// </summary>
		public const int SAVEBITS=0x00000800;

		/// <summary>
		/// Aligns the window's client area on a byte boundary (in the x direction).
		/// This style affects the width of the window and its horizontal placement on the display.
		/// </summary>
		public const int BYTEALIGNCLIENT=0x00001000;

		/// <summary>
		/// Aligns the window on a byte boundary (in the x direction). This style affects the width
		/// of the window and its horizontal placement on the display.
		/// </summary>
		public const int BYTEALIGNWINDOW=0x00002000;

		/// <summary>
		/// Indicates that the window class is an application global class.
		/// </summary>
		public const int GLOBALCLASS=0x00004000;

		/// <summary>
		/// Reserved.
		/// </summary>
		public const int h8000=0x00008000;

		/// <summary>
		/// Undocumented.
		/// </summary>
		public const int IME=0x00010000;

		/// <summary>
		/// Enables the drop shadow effect on a window.
		/// </summary>
		public const int DROPSHADOW=0x00020000;
	}
}
