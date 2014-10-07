using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Defines the x- and y- coordinates of a point.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Point
	{
		/// <summary>
		/// The x-coordinate of the point.
		/// </summary>
		public int x;

		/// <summary>
		/// The y-coordinate of the point.
		/// </summary>
		public int y;
	}
}
