using System;

namespace Win32
{
	/// <summary>
	/// Specifies flags for monitor devices.
	/// </summary>
	[Flags]
	public enum MonitorInfoFlag : uint
	{
		/// <summary>
		/// This is the primary display monitor.
		/// </summary>
		PRIMARY=0x00000001,
	}
}
