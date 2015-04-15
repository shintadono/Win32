using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32.HumanInterfaceDevices
{
	public class RID_DEVICE_INFO_MOUSE
	{
		public uint dwId;
		public uint dwNumberOfButtons;
		public uint dwSampleRate;

		[MarshalAs(UnmanagedType.Bool)]
		public bool fHasHorizontalWheel;
	}
}
