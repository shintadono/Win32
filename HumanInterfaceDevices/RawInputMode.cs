using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defined the type of the raw input or the input device.
	/// </summary>
	[CLSCompliant(false)]
	public enum RawInputMode : uint
	{
		/// <summary>
		/// Raw input comes from the mouse. (See RIM_TYPEMOUSE.)
		/// </summary>
		Mouse=0,

		/// <summary>
		/// Raw input comes from the keyboard. (See RIM_TYPEKEYBOARD.)
		/// </summary>
		Keyboard=1,

		/// <summary>
		/// Raw input comes from some device that is not a keyboard or a mouse. (See RIM_TYPEHID.)
		/// </summary>
		HID=2,
	}
}
