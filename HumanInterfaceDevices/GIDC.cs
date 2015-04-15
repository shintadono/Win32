using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the allowed values for the wParam parameter of a
	/// <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> message.
	/// To get the wParam value, use the <see cref="HID.GET_RAWINPUT_DEVICE_CHANGE_CODE_WPARAM"/>.
	/// </summary>
	public enum GIDC
	{
		/// <summary>
		/// A new device has been added to the system.
		/// </summary>
		ARRIVAL=1,

		/// <summary>
		/// A device has been removed from the system.
		/// </summary>
		REMOVAL=2,
	}
}
