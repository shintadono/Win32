using System;
using System.Runtime.InteropServices;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Defines the raw input data coming from the specified keyboard.
	/// </summary>
	/// <remarks>For the keyboard, the Usage Page is 1 and the Usage is 6.</remarks>
	[StructLayout(LayoutKind.Sequential)]
	[CLSCompliant(false)]
	public struct RID_DEVICE_INFO_KEYBOARD
	{
		/// <summary>
		/// The type of the keyboard.
		/// </summary>
		public uint dwType;

		/// <summary>
		/// The subtype of the keyboard.
		/// </summary>
		public uint dwSubType;

		/// <summary>
		/// The scan code mode.
		/// </summary>
		public uint dwKeyboardMode;

		/// <summary>
		/// The number of function keys on the keyboard.
		/// </summary>
		public uint dwNumberOfFunctionKeys;

		/// <summary>
		/// The number of LED indicators on the keyboard.
		/// </summary>
		public uint dwNumberOfIndicators;

		/// <summary>
		/// The total number of keys on the keyboard.
		/// </summary>
		public uint dwNumberOfKeysTotal;
	}
}
