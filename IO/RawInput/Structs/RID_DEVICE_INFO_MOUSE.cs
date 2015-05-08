using System;
using System.Runtime.InteropServices;

namespace Win32.RawInput
{
	/// <summary>
	/// Defines the raw input data coming from the specified mouse.
	/// </summary>
	/// <remarks>For the mouse, the Usage Page is 1 and the Usage is 2.</remarks>
	[StructLayout(LayoutKind.Sequential)]
	[CLSCompliant(false)]
	public struct RID_DEVICE_INFO_MOUSE
	{
		/// <summary>
		/// The identifier of the mouse device.
		/// </summary>
		public uint dwId;

		/// <summary>
		/// The number of buttons for the mouse.
		/// </summary>
		public uint dwNumberOfButtons;

		/// <summary>
		/// The number of data points per second. This information may not be applicable for every mouse device.
		/// </summary>
		public uint dwSampleRate;

		/// <summary>
		/// <para><b>true</b> if the mouse has a wheel for horizontal scrolling; otherwise, <b>false</b>.</para>
		/// <para><b>Windows XP:</b> This member is only supported starting with Windows Vista.</para>
		/// </summary>
		[MarshalAs(UnmanagedType.Bool)]
		public bool fHasHorizontalWheel;
	}
}
