using System;

namespace Win32
{
	/// <summary>
	/// Generic Access Rights. See <see cref="ACCESS_MASK"/> for more information.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum GENERIC : uint
	{
		/// <summary>
		/// Read access
		/// </summary>
		READ=ACCESS_MASK.GENERIC_READ,

		/// <summary>
		/// Write access
		/// </summary>
		WRITE=ACCESS_MASK.GENERIC_WRITE,

		/// <summary>
		/// Execute access
		/// </summary>
		EXECUTE=ACCESS_MASK.GENERIC_EXECUTE,

		/// <summary>
		/// All possible access rights
		/// </summary>
		ALL=ACCESS_MASK.GENERIC_ALL,
	}
}
