namespace Win32
{
	/// <summary>
	/// Types of stock objects.
	/// </summary>
	public enum StockObjectType
	{
		/// <summary>
		/// White brush.
		/// </summary>
		WHITE_BRUSH=0,

		/// <summary>
		/// Light gray brush.
		/// </summary>
		LTGRAY_BRUSH=1,

		/// <summary>
		/// Gray brush.
		/// </summary>
		GRAY_BRUSH=2,

		/// <summary>
		/// Dark gray brush.
		/// </summary>
		DKGRAY_BRUSH=3,

		/// <summary>
		/// Black brush.
		/// </summary>
		BLACK_BRUSH=4,

		/// <summary>
		/// Null brush (equivalent to <see cref="HOLLOW_BRUSH"/>).
		/// </summary>
		NULL_BRUSH=5,

		/// <summary>
		/// Hollow brush (equivalent to <see cref="NULL_BRUSH"/>).
		/// </summary>
		HOLLOW_BRUSH=NULL_BRUSH,

		/// <summary>
		/// White pen.
		/// </summary>
		WHITE_PEN=6,

		/// <summary>
		/// Black pen.
		/// </summary>
		BLACK_PEN=7,

		/// <summary>
		/// Null pen. The null pen draws nothing.
		/// </summary>
		NULL_PEN=8,

		/// <summary>
		/// Original equipment manufacturer (OEM) dependent fixed-pitch (monospace) font.
		/// </summary>
		OEM_FIXED_FONT=10,

		/// <summary>
		/// Windows fixed-pitch (monospace) system font.
		/// </summary>
		ANSI_FIXED_FONT=11,

		/// <summary>
		/// Windows variable-pitch (proportional space) system font.
		/// </summary>
		ANSI_VAR_FONT=12,

		/// <summary>
		/// System font. By default, the system uses the system font to draw menus, dialog box controls, and text.
		/// </summary>
		SYSTEM_FONT=13,

		/// <summary>
		/// Device-dependent font.
		/// </summary>
		DEVICE_DEFAULT_FONT=14,

		/// <summary>
		/// Default palette. This palette consists of the static colors in the system palette.
		/// </summary>
		DEFAULT_PALETTE=15,

		/// <summary>
		/// Fixed-pitch (monospace) system font.
		/// </summary>
		SYSTEM_FIXED_FONT=16,

		/// <summary>
		/// Default font for user interface objects such as menus and dialog boxes.
		/// </summary>
		DEFAULT_GUI_FONT=17,

		/// <summary>
		/// Solid color brush. The default color is white. The color can be changed by using the <see cref="GDI.SetDCBrushColor"/> function.
		/// </summary>
		DC_BRUSH=18,

		/// <summary>
		/// Solid pen color. The default color is white. The color can be changed by using the <see cref="GDI.SetDCPenColor"/> function.
		/// </summary>
		DC_PEN=19,
	}
}
