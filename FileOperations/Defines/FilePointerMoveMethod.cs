using System;

namespace Win32
{
	/// <summary>
	/// Defines the starting points for the file pointer move operations.
	/// </summary>
	[CLSCompliant(false)]
	public enum FilePointerMoveMethod : uint
	{
		/// <summary>
		/// The starting point is zero or the beginning of the file.
		/// </summary>
		FILE_BEGIN=0,

		/// <summary>
		/// The starting point is the current value of the file pointer.
		/// </summary>
		FILE_CURRENT=1,

		/// <summary>
		/// The starting point is the current end-of-file position.
		/// </summary>
		FILE_END=2,
	}
}
