using System;

namespace Win32
{
	/// <summary>
	/// Return value for <see cref="DC.TRUETYPE"/>.
	/// </summary>
	[Flags]
	public enum DCTT : uint
	{
		/// <summary>
		/// Device can print TrueType fonts as graphics.
		/// </summary>
		BITMAP=1,

		/// <summary>
		/// Device can download TrueType fonts.
		/// </summary>
		DOWNLOAD=2,

		/// <summary>
		/// Device can substitute device fonts for TrueType fonts.
		/// </summary>
		SUBDEV=4,

		/// <summary>
		/// (Windows 95/98/Me only) The device can download outline TrueType fonts.
		/// </summary>
		DOWNLOAD_OUTLINE=8,
	}
}
