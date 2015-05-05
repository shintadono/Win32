using System;

namespace Win32
{
	/// <summary>
	/// Defines the file access flags used by some file functions.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum FILE_SHARE : uint
	{
		/// <summary>
		/// Prevents other processes from opening a file or device if they request delete, read, or write access.
		/// </summary>
		NONE=0,

		/// <summary>
		/// Enables subsequent open operations on a file or device to request read access.
		/// </summary>
		READ=0x00000001,

		/// <summary>
		/// Enables subsequent open operations on a file or device to request write access.
		/// </summary>
		WRITE=0x00000002,

		/// <summary>
		/// Enables subsequent open operations on a file or device to request delete access.
		/// </summary>
		DELETE=0x00000004,
	}
}
