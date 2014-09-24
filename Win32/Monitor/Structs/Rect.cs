using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Defines the coordinates of the upper-left and lower-right corners of a rectangle.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Rect
	{
		/// <summary>
		/// The x-coordinate of the upper-left corner of the rectangle.
		/// </summary>
		public int left;

		/// <summary>
		/// The y-coordinate of the upper-left corner of the rectangle.
		/// </summary>
		public int top;

		/// <summary>
		/// The x-coordinate of the lower-right corner of the rectangle.
		/// </summary>
		public int right;

		/// <summary>
		/// The y-coordinate of the lower-right corner of the rectangle.
		/// </summary>
		public int bottom;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="left">The x-coordinate of the upper-left corner of the rectangle.</param>
		/// <param name="top">The y-coordinate of the upper-left corner of the rectangle.</param>
		/// <param name="right">The x-coordinate of the lower-right corner of the rectangle.</param>
		/// <param name="bottom">The y-coordinate of the lower-right corner of the rectangle.</param>
		public Rect(int left, int top, int right, int bottom)
		{
			this.left=left;
			this.top=top;
			this.right=right;
			this.bottom=bottom;
		}
	}
}
