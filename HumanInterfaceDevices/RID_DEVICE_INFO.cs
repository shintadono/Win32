using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32.HumanInterfaceDevices
{
	[StructLayout(LayoutKind.Sequential)]
	public struct RID_DEVICE_INFO
	{
		public uint cbSize;

		public uint dwType;


		//union {
		//	RID_DEVICE_INFO_MOUSE    mouse;
		//	RID_DEVICE_INFO_KEYBOARD keyboard;
		//	RID_DEVICE_INFO_HID      hid;
		//  };
	}
}
