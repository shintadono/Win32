using System;

namespace Win32
{
	/// <summary>
	/// Defines the file flags used by some file functions.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum FILE_FLAG : uint
	{
		/// <summary>
		/// The file is being opened and an opportunistic lock (oplock) on the file is being requested
		/// as a single atomic operation. The file system checks for oplocks before it performs the
		/// create operation, and will fail the create with a last error code of
		/// <see cref="ERROR.CANNOT_BREAK_OPLOCK">ERROR_CANNOT_BREAK_OPLOCK</see> if the result would
		/// be to break an existing oplock.
		/// </summary>
		OPEN_REQUIRING_OPLOCK=0x00040000,

		/// <summary>
		/// If you attempt to create multiple instances of a pipe with this flag, creation of the
		/// first instance succeeds, but creation of the next instance fails with
		/// <see cref="ERROR.ACCESS_DENIED">ERROR_ACCESS_DENIED</see>.
		/// </summary>
		/// <remarks><b>Note: </b> This flag is not supported until Windows 2000 SP2 and Windows XP.</remarks>
		FIRST_PIPE_INSTANCE=0x00080000,

		/// <summary>
		/// Used with remote storage systems. File data is requested, but it should stay in remote storage.
		/// </summary>
		OPEN_NO_RECALL=0x00100000,

		/// <summary>
		/// Disables reparse point processing and opens the reparse point itself, if one.
		/// </summary>
		OPEN_REPARSE_POINT=0x00200000,

		//reserved_0x00400000=0x00400000,

		/// <summary>
		/// The file or device is being opened with session awareness.
		/// </summary>
		/// <remarks>This flag is supported only on server editions of Windows.
		/// <b>Note: </b>This flag is not supported until Windows Server 2012.</remarks>
		SESSION_AWARE=0x00800000,

		/// <summary>
		/// Use POSIX rules for file access.
		/// </summary>
		POSIX_SEMANTICS=0x01000000,

		/// <summary>
		/// The file or directory is being opened or created for a backup or restore operation.
		/// </summary>
		BACKUP_SEMANTICS=0x02000000,

		/// <summary>
		/// The file is to be deleted immediately after it is closed.
		/// </summary>
		DELETE_ON_CLOSE=0x04000000,

		/// <summary>
		/// Access is intended to be sequential from beginning to end. Hints the system for caching optimizations.
		/// </summary>
		SEQUENTIAL_SCAN=0x08000000,

		/// <summary>
		/// Access is intended to be random. Hints the system for caching optimizations.
		/// </summary>
		RANDOM_ACCESS=0x10000000,

		/// <summary>
		/// The file or device is being opened with no system caching for data reads and writes.
		/// </summary>
		NO_BUFFERING=0x20000000,

		/// <summary>
		/// The file or device is being opened or created for asynchronous I/O.
		/// </summary>
		OVERLAPPED=0x40000000,

		/// <summary>
		/// Write operations will not go through any intermediate cache, they will go directly to mass storage.
		/// </summary>
		WRITE_THROUGH=0x80000000,
	}
}
