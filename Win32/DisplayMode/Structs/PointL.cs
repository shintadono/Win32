using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Contains the coordinates of a point.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct PointL
	{
		/// <summary>
		/// The horizontal (x) coordinate of the point.
		/// </summary>
		public int x;

		/// <summary>
		/// The vertical (y) coordinate of the point.
		/// </summary>
		public int y;
	}
}
