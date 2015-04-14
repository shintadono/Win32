using System.Runtime.InteropServices;

namespace Win32.HumanInterfaceDevices
{
	// https://msdn.microsoft.com/en-us/library/windows/desktop/ms645584%28v=vs.85%29.aspx
	[StructLayout(LayoutKind.Sequential)]
	public struct RID_DEVICE_INFO_HID
	{
		public uint dwVendorID;

		public uint dwProductID;

		public uint dwVersionNumber;

		public ushort usUsagePage;

		public ushort usUsage;

		// padding to get the size right
		//public int unused1;
		//public int unused2;
	}
}
