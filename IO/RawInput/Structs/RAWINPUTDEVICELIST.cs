using System;
using System.Runtime.InteropServices;
using HANDLE=System.IntPtr;

namespace Win32.RawInput
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
		public HANDLE hDevice;

		/// <summary>
		/// The type of device.
		/// </summary>
		public RIM_TYPE dwType;
	}
}
