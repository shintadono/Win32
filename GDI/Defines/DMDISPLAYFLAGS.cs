using System;

namespace Win32
{
	/// <summary>
	/// Specifies the device's display mode.
	/// </summary>
	public enum DMDISPLAYFLAGS : uint
	{
		/// <summary>
		/// Specifies that the display is a noncolor device. If this flag is not set, color is assumed.
		/// </summary>
		[Obsolete("This flag is no longer valid.")]
		GRAYSCALE=0x00000001,

		/// <summary>
		/// Specifies that the display mode is interlaced. If the flag is not set, noninterlaced is assumed.
		/// </summary>
		INTERLACED=0x00000002,

		/// <summary>
		/// Specifies that the display mode is text. If the flag is not set, graphic is assumed.
		/// </summary>
		TEXTMODE=0x00000004,
	}
}
