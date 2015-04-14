using System;
using System.Runtime.InteropServices;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Contains the header information that is part of the raw input data.
	/// </summary>
	/// <remarks>To get more information on the device, use <see cref="device"/> in a call to
	/// <see cref="GetRawInputDeviceInfo"/>.</remarks>
	[StructLayout(LayoutKind.Sequential)]
	[CLSCompliant(false)]
	public struct RAWINPUTHEADER
	{
		/// <summary>
		/// The type of raw input.
		/// </summary>
		public RawInputMode type;

		/// <summary>
		/// The size, in bytes, of the entire input packet of data. This includes <see cref="RAWINPUT"/>
		/// plus possible extra input reports in the <see cref="RAWHID"/> variable length array.
		/// </summary>
		public uint size;

		/// <summary>
		/// A handle to the device generating the raw input data.
		/// </summary>
		public IntPtr device;

		/// <summary>
		/// The value passed in the wParam parameter of the <see cref="WM.INPUT">WM_INPUT</see> message.
		/// </summary>
		public UIntPtr wParam;
	}
}
