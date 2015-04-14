using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win32.HumanInterfaceDevices
{
	class RID_DEVICE_INFO_KEYBOARD
	{
		public uint dwType;
		public uint dwSubType;
		public uint dwKeyboardMode;
		public uint dwNumberOfFunctionKeys;
		public uint dwNumberOfIndicators;
		public uint dwNumberOfKeysTotal;
	}
}
