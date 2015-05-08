using System;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Defines the allowed values for the <b>wParam</b> parameter of a
	/// <see cref="WM.INPUT">WM_INPUT</see> message.
	/// To get the <b>wParam</b> value, use the <see cref="RawInput.GET_RAWINPUT_CODE_WPARAM"/>.
	/// </summary>
	public enum RIM
	{
		/// <summary>
		/// The input is in the regular message flow, the app is required to call
		/// <b>DefWindowProc</b> so that the system can perform clean ups.
		/// </summary>
		INPUT=0,

		/// <summary>
		/// The input is sink only. The app is expected to behave nicely and the
		/// app is required to call <b>DefWindowProc</b> so that the system can
		/// perform clean ups.
		/// </summary>
		INPUTSINK=1,
	}
}
