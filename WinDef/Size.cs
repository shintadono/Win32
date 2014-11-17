using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Defines the width and height of a rectangle.
	/// </summary>
	/// <remarks>
	/// The rectangle dimensions stored in this structure may correspond to viewport extents, window extents,
	/// text extents, bitmap dimensions, or the aspect-ratio filter for some extended functions.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct Size
	{
		/// <summary>
		/// Specifies the rectangle's width. The units depend on which function uses this.
		/// </summary>
		public int cx;

		/// <summary>
		/// Specifies the rectangle's height. The units depend on which function uses this.
		/// </summary>
		public int cy;
	}
}
