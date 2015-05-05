using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Win32
{
	/// <summary>
	/// Defines the specific access rights to files and directories. See <see cref="ACCESS_MASK"/> for more information.
	/// </summary>
	public enum FileAccess : uint
	{
		/// <summary>
		/// For a file object, the right to read the corresponding file data.
		/// For a directory object, the right to read the corresponding directory data.
		/// </summary>
		FILE_READ_DATA=0x0001,

		/// <summary>
		/// For a directory, the right to list the contents of the directory.
		/// </summary>
		FILE_LIST_DIRECTORY=0x0001,

		/// <summary>
		/// For a file object, the right to write data to the file.
		/// </summary>
		FILE_WRITE_DATA=0x0002,

		/// <summary>
		/// For a directory, the right to create a file in the directory.
		/// </summary>
		FILE_ADD_FILE=0x0002,

		/// <summary>
		/// For a file object, the right to append data to the file.
		/// </summary>
		FILE_APPEND_DATA=0x0004,

		/// <summary>
		/// For a directory, the right to create a subdirectory.
		/// </summary>
		FILE_ADD_SUBDIRECTORY=0x0004,

		/// <summary>
		/// For a named pipe, the right to create a pipe.
		/// </summary>
		FILE_CREATE_PIPE_INSTANCE=0x0004,

		/// <summary>
		/// The right to read extended file attributes.
		/// </summary>
		FILE_READ_EA=0x0008, 

		/// <summary>
		/// The right to write extended file attributes.
		/// </summary>
		FILE_WRITE_EA=0x0010,

		/// <summary>
		/// For a native code file, the right to execute the file. This access
		/// right given to scripts may cause the script to be executable,
		/// depending on the script interpreter.
		/// </summary>
		FILE_EXECUTE=0x0020,

		/// <summary>
		/// For a directory, the right to traverse the directory.
		/// </summary>
		FILE_TRAVERSE=0x0020,

		/// <summary>
		/// For a directory, the right to delete a directory and all
		/// the files it contains, including read-only files.
		/// </summary>
		FILE_DELETE_CHILD=0x0040,

		/// <summary>
		/// The right to read file attributes.
		/// </summary>
		FILE_READ_ATTRIBUTES=0x0080,

		/// <summary>
		/// The right to write file attributes.
		/// </summary>
		FILE_WRITE_ATTRIBUTES=0x0100,

		/// <summary>
		/// All possible access rights for a file.
		/// </summary>
		FILE_ALL_ACCESS=STANDARD_RIGHTS.REQUIRED|ACCESS_MASK.SYNCHRONIZE|0x1FF,
	}
}
