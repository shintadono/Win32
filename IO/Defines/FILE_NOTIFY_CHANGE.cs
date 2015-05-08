using System;

namespace Win32.IO
{
	/// <summary>
	/// Defines filters for directory change notification.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum FILE_NOTIFY_CHANGE : uint
	{
		/// <summary>
		/// Return on any file name change, or on creating or deleting of a file.
		/// </summary>
		FILE_NAME=0x00000001,

		/// <summary>
		/// Return on any directory name change, or on creating or deleting of a directory.
		/// </summary>
		DIR_NAME=0x00000002,

		/// <summary>
		/// Return on any attribute change.
		/// </summary>
		ATTRIBUTES=0x00000004,

		/// <summary>
		/// Return on any size change.
		/// </summary>
		SIZE=0x00000008,

		/// <summary>
		/// Return on any change on the last write time of a file.
		/// </summary>
		LAST_WRITE=0x00000010,

		/// <summary>
		/// Return on any change on the last access time of a file.
		/// </summary>
		LAST_ACCESS=0x00000020,

		/// <summary>
		/// Return on any change on the creation time of a file.
		/// </summary>
		CREATION=0x00000040,

		/// <summary>
		/// Return on any change on the security-descriptor in the watch directory.
		/// </summary>
		SECURITY=0x00000100,
	}
}
