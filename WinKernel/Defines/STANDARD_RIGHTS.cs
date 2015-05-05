using System;

namespace Win32
{
	/// <summary>
	/// Standard Access Rights. See <see cref="ACCESS_MASK"/> for more information.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum STANDARD_RIGHTS : uint
	{
		/// <summary>
		/// See <see cref="ACCESS_MASK.STANDARD_RIGHTS_REQUIRED"/>.
		/// </summary>
		REQUIRED=ACCESS_MASK.STANDARD_RIGHTS_REQUIRED,

		/// <summary>
		/// See <see cref="ACCESS_MASK.STANDARD_RIGHTS_READ"/>.
		/// </summary>
		READ=ACCESS_MASK.STANDARD_RIGHTS_READ,

		/// <summary>
		/// See <see cref="ACCESS_MASK.STANDARD_RIGHTS_WRITE"/>.
		/// </summary>
		WRITE=ACCESS_MASK.STANDARD_RIGHTS_WRITE,

		/// <summary>
		/// See <see cref="ACCESS_MASK.STANDARD_RIGHTS_EXECUTE"/>.
		/// </summary>
		EXECUTE=ACCESS_MASK.STANDARD_RIGHTS_EXECUTE,

		/// <summary>
		/// See <see cref="ACCESS_MASK.STANDARD_RIGHTS_ALL"/>.
		/// </summary>
		ALL=ACCESS_MASK.STANDARD_RIGHTS_ALL,
	}
}
