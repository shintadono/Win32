using System;
using System.Runtime.InteropServices;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Defines the raw input data coming from the specified Human Interface Device (HID).
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[CLSCompliant(false)]
	public struct RID_DEVICE_INFO_HID
	{
		/// <summary>
		/// The vendor identifier for the HID.
		/// </summary>
		public uint dwVendorId;

		/// <summary>
		/// The product identifier for the HID.
		/// </summary>
		public uint dwProductId;

		/// <summary>
		/// The version number for the HID.
		/// </summary>
		public uint dwVersionNumber;

		/// <summary>
		/// The top-level collection Usage Page for the device.
		/// </summary>
		public ushort usUsagePage;

		/// <summary>
		/// The top-level collection Usage for the device.
		/// </summary>
		public ushort usUsage;
	}
}
