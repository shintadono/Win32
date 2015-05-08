using System;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Defined the type of the raw input or the input device.
	/// </summary>
	[CLSCompliant(false)]
	public enum RIM_TYPE : uint
	{
		/// <summary>
		/// Raw input comes from the mouse.
		/// </summary>
		MOUSE=0,

		/// <summary>
		/// Raw input comes from the keyboard.
		/// </summary>
		KEYBOARD=1,

		/// <summary>
		/// Raw input comes from some device that is not a keyboard or a mouse.
		/// </summary>
		HID=2,
	}
}
