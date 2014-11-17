using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Defines the attributes of a font. (Use only in environments that have <see cref="Marshal.SystemDefaultCharSize"/> == 2.)
	/// </summary>
	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
	public class LogFont
	{
		/// <summary>
		/// Constant specifying the length of the character array holding <see cref="lfFaceName"/>.
		/// </summary>
		public const int LF_FACESIZE=32;

		/// <summary>
		/// The height, in logical units, of the font's character cell or character.
		/// </summary>
		public int lfHeight;
		
		/// <summary>
		/// The average width, in logical units, of characters in the requested font.
		/// </summary>
		public int lfWidth;
		
		/// <summary>
		/// The angle, in tenths of degrees, between the escapement vector and the x-axis of the device. The escapement vector is parallel to the base line of a row of text.
		/// </summary>
		public int lfEscapement;
		
		/// <summary>
		/// The angle, in tenths of degrees, between each character's base line and the x-axis of the device.
		/// </summary>
		public int lfOrientation;
		
		/// <summary>
		/// The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is used.
		/// </summary>
		public int lfWeight;
		
		/// <summary>
		/// <b>true</b> if the font is italic.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool lfItalic;

		/// <summary>
		/// <b>true</b> if the font is underlined.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool lfUnderline;

		/// <summary>
		/// <b>true</b> if the font is striked out.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool lfStrikeOut;
		
		/// <summary>
		/// A <see cref="LogFontCharSet"/> specifying the character set.
		/// </summary>
		public LogFontCharSet lfCharSet;
		
		/// <summary>
		/// A <see cref="LogFontPrecision"/> specifying the output precision.
		/// </summary>
		public LogFontPrecision lfOutPrecision;
		
		/// <summary>
		/// A <see cref="LogFontClipPrecision"/> specifying the clip precision.
		/// </summary>
		public LogFontClipPrecision lfClipPrecision;
		
		/// <summary>
		/// A <see cref="LogFontQuality"/> specifying the quality.
		/// </summary>
		public LogFontQuality lfQuality;
		
		/// <summary>
		/// A <see cref="LogFontPitchAndFamily"/> specifying the pitch and font family.
		/// </summary>
		public LogFontPitchAndFamily lfPitchAndFamily;

		/// <summary>
		/// String that specifying the typeface name of the font.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=LF_FACESIZE)]
		public string lfFaceName=string.Empty;
	}
}
