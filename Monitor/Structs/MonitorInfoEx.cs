using System;
using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Structure containing information about a display monitor. Same as <see cref="MonitorInfo"/>, but additionally containing a device name.
	/// </summary>
	[StructLayout(LayoutKind.Explicit, CharSet=CharSet.Unicode)]
	public struct MonitorInfoEx
	{
		/// <summary>
		/// Size of <see cref="szDevice"/> in <b>char</b>s.
		/// </summary>
		public const int CCHDEVICENAME=32;

		/// <summary>
		/// The size, in bytes, of the structure.
		/// </summary>
		[FieldOffset(0)]
		public uint cbSize;

		/// <summary>
		/// A <see cref="Rect"/> structure that specifies the display monitor rectangle, expressed in virtual-screen coordinates.
		/// </summary>
		[FieldOffset(4)]
		public Rect rcMonitor;

		/// <summary>
		/// A <see cref="Rect"/> structure that specifies the work area rectangle of the display monitor that can be used by applications, expressed in virtual-screen coordinates.
		/// </summary>
		[FieldOffset(20)]
		public Rect rcWork;

		/// <summary>
		/// A set of flags that represent attributes of the display monitor.
		/// </summary>
		[FieldOffset(36)]
		public MonitorInfoFlag dwFlags;

		/// <summary>
		/// A zero-terminated character array that specifies the "friendly" name of the display.
		/// </summary>
		[FieldOffset(40)]
		public unsafe fixed char szDevice[CCHDEVICENAME];

		/// <summary>
		/// Property to access <see cref="szDevice"/> as string.
		/// </summary>
		public string Device
		{
			get
			{
				unsafe
				{
					fixed(char* devName=szDevice) return new string(devName);
				}
			}
			set
			{
				int len=Math.Min(value.Length, 31);
				unsafe
				{
					fixed(char* devName=szDevice)
					{
						for(int i=0; i<len; i++) devName[i]=value[i];
						devName[len]='\0';
					}
				}
			}
		}
	}
}
