using System;

namespace Win32
{
	/// <summary>
	/// Defined the type of change that can occur in directories.
	/// </summary>
	[CLSCompliant(false)]
	public enum FILE_ACTION : uint
	{
		/// <summary>
		/// A file was added to the directory.
		/// </summary>
		ADDED=0x00000001,

		/// <summary>
		/// A file was removed from the directory.
		/// </summary>
		REMOVED=0x00000002,

		/// <summary>
		/// A file was modified. This can be a change in the time stamp or attributes.
		/// </summary>
		MODIFIED=0x00000003,

		/// <summary>
		/// The file was renamed, since an action notification report carries only one
		/// file name, two reports transport the information. This is the old name.
		/// </summary>
		RENAMED_OLD_NAME=0x00000004,

		/// <summary>
		/// The file was renamed, since an action notification report carries only one
		/// file name, two reports transport the information. This is the new name.
		/// </summary>
		RENAMED_NEW_NAME=0x00000005,
	}
}
