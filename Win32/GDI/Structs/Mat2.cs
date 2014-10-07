using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Defines the values for a transformation matrix used by the <see cref="O:Win32.Font.GetGlyphOutline">GetGlyphOutline</see> function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Mat2
	{
		/// <summary>
		/// The M11 component of a 3 by 3 transformation matrix.
		/// </summary>
		public int eM11;

		/// <summary>
		/// The M12 component of a 3 by 3 transformation matrix.
		/// </summary>
		public int eM12;

		/// <summary>
		/// The M21 component of a 3 by 3 transformation matrix.
		/// </summary>
		public int eM21;

		/// <summary>
		/// The M22 component of a 3 by 3 transformation matrix.
		/// </summary>
		public int eM22;

		/// <summary>
		/// Returns the identity matrix.
		/// </summary>
		public static Mat2 Identity { get { Mat2 ret; ret.eM11=ret.eM22=1; ret.eM12=ret.eM21=0; return ret; } }
	}
}
