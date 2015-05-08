using System;

namespace Win32.IO
{
	/// <summary>
	/// Defines the file opening or creation actions.
	/// </summary>
	[CLSCompliant(false)]
	public enum FileMode : uint
	{
		/// <summary>
		/// Creates a new file, only if it does not already exist.
		/// </summary>
		CREATE_NEW=1,

		/// <summary>
		/// Creates a new file, always.
		/// </summary>
		CREATE_ALWAYS=2,

		/// <summary>
		/// Opens a file or device, only if it exists.
		/// </summary>
		OPEN_EXISTING=3,

		/// <summary>
		/// Opens a file, always.
		/// </summary>
		OPEN_ALWAYS=4,

		/// <summary>
		/// Opens a file and truncates it so that its size is zero bytes, only if it exists.
		/// </summary>
		TRUNCATE_EXISTING=5,
	}
}
