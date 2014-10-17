using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Structure containing information about a display monitor.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MonitorInfo
	{
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
	}
}
