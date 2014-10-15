using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Fixed-point real number used be <see cref="Mat2"/>.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public struct Fixed
	{
		/// <summary>
		/// Fraction.
		/// </summary>
		public ushort fract;

		/// <summary>
		/// Value.
		/// </summary>
		public short value;

		/// <summary>
		/// Initializes an instance of <b>Fixed</b>.
		/// </summary>
		/// <param name="value">The integral value.</param>
		/// <param name="fract">The fractional value.</param>
		public Fixed(short value, ushort fract=0)
		{
			this.value=value;
			this.fract=fract;
		}
	}

	/// <summary>
	/// Defines the values for a transformation matrix used by the <see cref="O:Win32.Font.GetGlyphOutline">GetGlyphOutline</see> function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Mat2
	{
		/// <summary>
		/// The M11 component of a 2 by 2 transformation matrix.
		/// </summary>
		public Fixed eM11;

		/// <summary>
		/// The M12 component of a 2 by 2 transformation matrix.
		/// </summary>
		public Fixed eM12;

		/// <summary>
		/// The M21 component of a 2 by 2 transformation matrix.
		/// </summary>
		public Fixed eM21;

		/// <summary>
		/// The M22 component of a 2 by 2 transformation matrix.
		/// </summary>
		public Fixed eM22;

		/// <summary>
		/// Returns the identity matrix.
		/// </summary>
		public static Mat2 Identity { get { Mat2 ret; ret.eM11=ret.eM22=new Fixed(1); ret.eM12=ret.eM21=new Fixed(); return ret; } }
	}
}
