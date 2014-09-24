namespace Win32
{
	/// <summary>
	/// Window styles.
	/// </summary>
	public static class WS
	{
		#region Window styles
		/// <summary>
		/// The window is an overlapped window. An overlapped window has a title bar and a
		/// border. Same as the <see cref="WS.TILED"/> style.
		/// </summary>
		public const int OVERLAPPED=0x00000000;

		/// <summary>
		/// The window has a maximize button. Cannot be combined with the <see cref="WS.EX.CONTEXTHELP"/>
		/// style. The <see cref="WS.SYSMENU"/> style must also be specified.
		/// </summary>
		public const int MAXIMIZEBOX=0x00010000;

		/// <summary>
		/// The window has a minimize button. Cannot be combined with the <see cref="WS.EX.CONTEXTHELP"/>
		/// style. The <see cref="WS.SYSMENU"/> style must also be specified.
		/// </summary>
		public const int MINIMIZEBOX=0x00020000;

		/// <summary>
		/// The window has a sizing border. Same as the <see cref="WS.SIZEBOX"/> style.
		/// </summary>
		public const int THICKFRAME=0x00040000;

		/// <summary>
		/// The window has a window menu on its title bar. The <see cref="WS.CAPTION"/>
		/// style must also be specified.
		/// </summary>
		public const int SYSMENU=0x00080000;

		/// <summary>
		/// The window has a horizontal scroll bar.
		/// </summary>
		public const int HSCROLL=0x00100000;

		/// <summary>
		/// The window has a vertical scroll bar.
		/// </summary>
		public const int VSCROLL=0x00200000;

		/// <summary>
		/// The window has a border of a style typically used with dialog boxes. A
		/// window with this style cannot have a title bar.
		/// </summary>
		public const int DLGFRAME=0x00400000;

		/// <summary>
		/// The window has a thin-line border.
		/// </summary>
		public const int BORDER=0x00800000;

		/// <summary>
		/// The window is initially maximized.
		/// </summary>
		public const int MAXIMIZE=0x01000000;

		/// <summary>
		/// Excludes the area occupied by child windows when drawing occurs within the
		/// parent window. This style is used when creating the parent window.
		/// </summary>
		public const int CLIPCHILDREN=0x02000000;

		/// <summary>
		/// Clips child windows relative to each other; that is, when a particular child
		/// window receives a <see cref="WM.PAINT"/> message, the <see cref="WS.CLIPSIBLINGS"/>
		/// style clips all other overlapping child windows out of the region of the child
		/// window to be updated. If <see cref="WS.CLIPSIBLINGS"/> is not specified and child
		/// windows overlap, it is possible, when drawing within the client area of a child
		/// window, to draw within the client area of a neighboring child window.
		/// </summary>
		public const int CLIPSIBLINGS=0x04000000;

		/// <summary>
		/// The window is initially disabled. A disabled window cannot receive input from the user.
		/// </summary>
		public const int DISABLED=0x08000000;

		/// <summary>
		/// The window is initially visible.
		/// </summary>
		public const int VISIBLE=0x10000000;

		/// <summary>
		/// The window is initially minimized. Same as the <see cref="WS.ICONIC"/> style.
		/// </summary>
		public const int MINIMIZE=0x20000000;

		/// <summary>
		/// The window is a child window. A window with this style cannot have a menu bar.
		/// This style cannot be used with the <see cref="WS.POPUP"/> style.
		/// </summary>
		public const int CHILD=0x40000000;

		/// <summary>
		/// The windows is a pop-up window. This style cannot be used with the <see cref="WS.CHILD"/> style.
		/// </summary>
		public const int POPUP=unchecked((int)0x80000000);

		#region Control only styles
		/// <summary>
		/// The window is a control that can receive the keyboard focus when the user presses the <b>TAB</b> key.
		/// </summary>
		public const int TABSTOP=0x00010000;

		/// <summary>
		/// The window is the first control of a group of controls.
		/// </summary>
		public const int GROUP=0x00020000;
		#endregion

		/// <summary>
		/// The window has a title bar (includes the <see cref="WS.BORDER"/> style).
		/// </summary>
		public const int CAPTION=BORDER|DLGFRAME;

		/// <summary>
		/// The window is an overlapped window. An overlapped window has a title bar and a border. Same as the <see cref="WS.OVERLAPPED"/> style.
		/// </summary>
		public const int TILED=OVERLAPPED;

		/// <summary>
		/// The window is initially minimized. Same as the <see cref="WS.MINIMIZE"/> style.
		/// </summary>
		public const int ICONIC=MINIMIZE;

		/// <summary>
		/// The window has a sizing border. Same as the <see cref="WS.THICKFRAME"/> style.
		/// </summary>
		public const int SIZEBOX=THICKFRAME;

		#region Common window styles
		/// <summary>
		/// The window is an overlapped window. Same as the <see cref="WS.TILEDWINDOW"/> style.
		/// </summary>
		public const int OVERLAPPEDWINDOW=OVERLAPPED|CAPTION|SYSMENU|THICKFRAME|MINIMIZEBOX|MAXIMIZEBOX;

		/// <summary>
		/// The window is a pop-up window. The <see cref="WS.CAPTION"/> and <see cref="WS.POPUPWINDOW"/>
		/// styles must be combined to make the window menu visible.
		/// </summary>
		public const int POPUPWINDOW=POPUP|BORDER|SYSMENU;

		/// <summary>
		/// Same as the <see cref="WS.CHILD"/> style.
		/// </summary>
		public const int CHILDWINDOW=CHILD;

		/// <summary>
		/// The window is an overlapped window. Same as the <see cref="WS.OVERLAPPEDWINDOW"/> style.
		/// </summary>
		public const int TILEDWINDOW=OVERLAPPEDWINDOW;
		#endregion
		#endregion

		#region Extended window styles
		/// <summary>
		/// Extended window styles.
		/// </summary>
		public static class EX
		{
			/// <summary>
			/// The window has generic left-aligned properties. This is the default.
			/// </summary>
			public const int LEFT=0x00000000;

			/// <summary>
			/// The window text is displayed using left-to-right reading-order properties.
			/// This is the default.
			/// </summary>
			public const int LTRREADING=0x00000000;

			/// <summary>
			/// The vertical scroll bar (if present) is to the right of the client area.
			/// This is the default.
			/// </summary>
			public const int RIGHTSCROLLBAR=0x00000000;

			/// <summary>
			/// The window has a double border; the window can, optionally, be created
			/// with a title bar by specifying the <see cref="WS.CAPTION"/> style.
			/// </summary>
			public const int DLGMODALFRAME=0x00000001;

			/// <summary>
			/// Reserved.
			/// </summary>
			public const int h2=0x00000002;

			/// <summary>
			/// The child window created with this style does not send the <see cref="WM.PARENTNOTIFY"/>
			/// message to its parent window when it is created or destroyed.
			/// </summary>
			public const int NOPARENTNOTIFY=0x00000004;

			/// <summary>
			/// The window should be placed above all non-topmost windows and
			/// should stay above them, even when the window is deactivated.
			/// </summary>
			public const int TOPMOST=0x00000008;

			/// <summary>
			/// The window accepts drag-drop files.
			/// </summary>
			public const int ACCEPTFILES=0x00000010;

			/// <summary>
			/// The window should not be painted until siblings beneath the window
			/// (that were created by the same thread) have been painted.
			/// </summary>
			public const int TRANSPARENT=0x00000020;

			/// <summary>
			/// The window is a MDI child window.
			/// </summary>
			public const int MDICHILD=0x00000040;

			/// <summary>
			/// The window is intended to be used as a floating toolbar.
			/// </summary>
			public const int TOOLWINDOW=0x00000080;

			/// <summary>
			/// The window has a border with a raised edge.
			/// </summary>
			public const int WINDOWEDGE=0x00000100;

			/// <summary>
			/// The window has a border with a sunken edge.
			/// </summary>
			public const int CLIENTEDGE=0x00000200;

			/// <summary>
			/// The title bar of the window includes a question mark. When the user clicks the
			/// question mark, the cursor changes to a question mark with a pointer. If the user
			/// then clicks a child window, the child receives a <see cref="WM.HELP"/> message.
			/// <see cref="WS.EX.CONTEXTHELP"/> cannot be used with the <see cref="WS.MAXIMIZEBOX"/>
			/// or <see cref="WS.MINIMIZEBOX"/> styles.
			/// </summary>
			public const int CONTEXTHELP=0x00000400;

			/// <summary>
			/// Reserved.
			/// </summary>
			public const int h800=0x00000800;

			/// <summary>
			/// The window has generic "right-aligned" properties. This depends on the window
			/// class. This style has an effect only if the shell language is Hebrew, Arabic,
			/// or another language that supports reading-order alignment; otherwise, the
			/// style is ignored.
			/// </summary>
			public const int RIGHT=0x00001000;

			/// <summary>
			/// If the shell language is Hebrew, Arabic, or another language that supports
			/// reading-order alignment, the window text is displayed using right-to-left
			/// reading-order properties. For other languages, the style is ignored.
			/// </summary>
			public const int RTLREADING=0x00002000;

			/// <summary>
			/// If the shell language is Hebrew, Arabic, or another language that supports
			/// reading order alignment, the vertical scroll bar (if present) is to the left
			/// of the client area. For other languages, the style is ignored.
			/// </summary>
			public const int LEFTSCROLLBAR=0x00004000;

			/// <summary>
			/// Reserved.
			/// </summary>
			public const int h8000=0x00008000;

			/// <summary>
			/// The window itself contains child windows that should take part in dialog box navigation.
			/// </summary>
			public const int CONTROLPARENT=0x00010000;

			/// <summary>
			/// The window has a three-dimensional border style intended to be
			/// used for items that do not accept user input.
			/// </summary>
			public const int STATICEDGE=0x00020000;

			/// <summary>
			/// Forces a top-level window onto the taskbar when the window is visible.
			/// </summary>
			public const int APPWINDOW=0x00040000;

			/// <summary>
			/// The window is a layered window. This style cannot be used if the window
			/// has a class style of either <see cref="CS.OWNDC"/> or <see cref="CS.CLASSDC"/>.
			/// </summary>
			public const int LAYERED=0x00080000;

			/// <summary>
			/// The window does not pass its window layout to its child windows.
			/// </summary>
			public const int NOINHERITLAYOUT=0x00100000;

			/// <summary>
			/// The window does not render to a redirection surface. This is for windows
			/// that do not have visible content or that use mechanisms other than
			/// surfaces to provide their visual.
			/// </summary>
			public const int NOREDIRECTIONBITMAP=0x00200000;

			/// <summary>
			/// If the shell language is Hebrew, Arabic, or another language that supports
			/// reading order alignment, the horizontal origin of the window is on the right
			/// edge. Increasing horizontal values advance to the left.
			/// </summary>
			public const int LAYOUTRTL=0x00400000;

			/// <summary>
			/// Reserved.
			/// </summary>
			public const int h800000=0x00800000;

			/// <summary>
			/// Reserved.
			/// </summary>
			public const int h1000000=0x01000000;

			/// <summary>
			/// Paints all descendants of a window in bottom-to-top painting order using double-buffering.
			/// </summary>
			public const int COMPOSITED=0x02000000;

			/// <summary>
			/// Reserved.
			/// </summary>
			public const int h4000000=0x04000000;

			/// <summary>
			/// A top-level window created with this style does not become the foreground window
			/// when the user clicks it. The system does not bring this window to the foreground
			/// when the user minimizes or closes the foreground window.
			/// The window does not appear on the taskbar by default. To force the window to
			/// appear on the taskbar, use the <see cref="WS.EX.APPWINDOW"/> style.
			/// </summary>
			public const int NOACTIVATE=0x08000000;

			/// <summary>
			/// The window is an overlapped window.
			/// </summary>
			public const int OVERLAPPEDWINDOW=WINDOWEDGE|CLIENTEDGE;

			/// <summary>
			/// The window is palette window, which is a modeless dialog box that
			/// presents an array of commands.
			/// </summary>
			public const int PALETTEWINDOW=WINDOWEDGE|TOOLWINDOW|TOPMOST;
		}
		#endregion
	}
}
