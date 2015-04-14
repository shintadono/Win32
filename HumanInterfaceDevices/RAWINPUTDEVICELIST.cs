using System;
using System.Runtime.InteropServices;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Contains information about a raw input device.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[CLSCompliant(false)]
	public struct RAWINPUTDEVICELIST
	{
		/// <summary>
		/// A handle to the raw input device.
		/// </summary>
		public IntPtr device;

		/// <summary>
		/// The type of device.
		/// </summary>
		public RawInputMode type;
	}
}
