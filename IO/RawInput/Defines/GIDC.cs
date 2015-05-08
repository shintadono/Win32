using System;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Defines the allowed values for the <b>wParam</b> parameter of a
	/// <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> message.
	/// To get the <b>wParam</b> value, use the <see cref="RawInput.GET_RAWINPUT_DEVICE_CHANGE_CODE_WPARAM"/>.
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
