using System;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Defines the command flag for <see cref="RawInput.GetRawInputData"/>.
	/// </summary>
	[CLSCompliant(false)]
	public enum RID : uint
	{
		/// <summary>
		/// Get the header information from the <see cref="RAWINPUT"/> structure.
		/// </summary>
		HEADER=0x10000005,

		/// <summary>
		/// Get the raw data from the <see cref="RAWINPUT"/> structure.
		/// </summary>
		INPUT=0x10000003,
	}
}
