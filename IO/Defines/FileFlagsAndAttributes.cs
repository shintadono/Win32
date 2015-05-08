using System;

namespace Win32.IO
{
	/// <summary>
	/// Used by <see cref="O:Wind32.File.CreateFile">CreateFile</see> as combined parameter for <b>FILE_FLAG_*</b>,
	/// <b>FILE_ATTRIBUTE_*</b> and <b>SECURITY_*</b>.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum FileFlagsAndAttributes : uint
	{
		#region FILE_ATTRIBUTE_*
		/// <summary>
		/// A file that is read-only. Applications can read the file, but cannot write to it or delete it.
		/// </summary>
		READONLY=0x00000001,

		/// <summary>
		/// Marks a file or directory as hidden.
		/// </summary>
		HIDDEN=0x00000002,

		/// <summary>
		/// A file or directory of the operating system.
		/// </summary>
		SYSTEM=0x00000004,

		//reserved_0x00000008=0x00000008,

		///// <summary>
		///// Identifies a directory.
		///// </summary>
		//DIRECTORY=0x00000010,

		/// <summary>
		/// Used to mark file and directories for backup.
		/// </summary>
		ARCHIVE=0x00000020,

		///// <summary>
		///// This value is reserved for system use.
		///// </summary>
		//DEVICE=0x00000040,

		/// <summary>
		/// A file that does not have other attributes set. This attribute is valid only when used alone.
		/// </summary>
		NORMAL=0x00000080,

		/// <summary>
		/// Marks a file as temporary storage. The system delays writing data to mass storage, if possible,
		/// since the file is most likely to be delete after use.
		/// </summary>
		TEMPORARY=0x00000100,

		///// <summary>
		///// Marks a file as sparse file.
		///// </summary>
		//SPARSE_FILE=0x00000200,

		///// <summary>
		///// Marks a file or directory as associated with a reparse point, or marks a file as a symbolic link.
		///// </summary>
		//REPARSE_POINT=0x00000400,

		///// <summary>
		///// Marks a file or directory that is compressed.
		///// </summary>
		//COMPRESSED=0x00000800,

		/// <summary>
		/// Marks a file that is moved to an offline storage and not immediately available.
		/// </summary>
		OFFLINE=0x00001000,

		///// <summary>
		///// Marks a file or directory that does not take part in content indexing.
		///// </summary>
		//NOT_CONTENT_INDEXED=0x00002000,

		/// <summary>
		/// Marks a file or directory that is encrypted.
		/// </summary>
		ENCRYPTED=0x00004000,

		///// <summary>
		///// Marks a file or directory that is configured with integrity. Supported only on ReFS volumes.
		///// </summary>
		///// <remarks><b>Note:</b> This flag is not supported until Windows Server 2012.</remarks>
		//INTEGRITY_STREAM=0x00008000,

		///// <summary>
		///// This value is reserved for system use.
		///// </summary>
		//VIRTUAL=0x00010000,

		///// <summary>
		///// The user data stream not to be read by the background data integrity scanner
		///// (AKA scrubber). When set on a directory it only provides inheritance. This
		///// flag is only supported on Storage Spaces and ReFS volumes. It is not included
		///// in an ordinary directory listing.
		///// </summary>
		///// <remarks><b>Note:</b> This flag is not supported until Windows 8 and Windows Server 2012.</remarks>
		//NO_SCRUB_DATA=0x00020000,
		#endregion

		#region FILE_FLAG_*
		/// <summary>
		/// The file is being opened and an opportunistic lock (oplock) on the file is being requested
		/// as a single atomic operation. The file system checks for oplocks before it performs the
		/// create operation, and will fail the create with a last error code of
		/// <see cref="ERROR.CANNOT_BREAK_OPLOCK">ERROR_CANNOT_BREAK_OPLOCK</see> if the result would
		/// be to break an existing oplock.
		/// </summary>
		OPEN_REQUIRING_OPLOCK=0x00040000,

		///// <summary>
		///// If you attempt to create multiple instances of a pipe with this flag, creation of the
		///// first instance succeeds, but creation of the next instance fails with
		///// <see cref="ERROR.ACCESS_DENIED">ERROR_ACCESS_DENIED</see>.
		///// </summary>
		///// <remarks><b>Note: </b> This flag is not supported until Windows 2000 SP2 and Windows XP.</remarks>
		//FIRST_PIPE_INSTANCE=0x00080000,

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
		#endregion

		#region SECURITY_*
		/// <summary>
		/// Impersonates a client at the Anonymous impersonation level.
		/// </summary>
		ANONYMOUS=SECURITY_IMPERSONATION_LEVEL.SecurityAnonymous<<16,

		/// <summary>
		/// Impersonates a client at the Identification impersonation level.
		/// </summary>
		IDENTIFICATION=SECURITY_IMPERSONATION_LEVEL.SecurityIdentification<<16,

		/// <summary>
		/// Impersonate a client at the impersonation level. This is the default behavior
		/// if no other flags are specified along with the SECURITY_SQOS_PRESENT flag.
		/// </summary>
		IMPERSONATION=SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation<<16,

		/// <summary>
		/// Impersonates a client at the Delegation impersonation level.
		/// </summary>
		DELEGATION=SECURITY_IMPERSONATION_LEVEL.SecurityDelegation<<16,

		/// <summary>
		/// The security tracking mode is dynamic. If this flag is not specified, the
		/// security tracking mode is static.
		/// </summary>
		CONTEXT_TRACKING=0x00040000,

		/// <summary>
		/// <para>Only the enabled aspects of the client's security context are available
		/// to the server. If you do not specify this flag, all aspects of the client's
		/// security context are available.</para>
		/// <para>This allows the client to limit the groups and privileges that a server
		/// can use while impersonating the client.</para>
		/// </summary>
		EFFECTIVE_ONLY=0x00080000,

		/// <summary>
		/// Security quality of service flags.
		/// </summary>
		SQOS_PRESENT=0x00100000,

		/// <summary>
		/// Bitmask for valid security quality of service flags.
		/// </summary>
		VALID_SQOS_FLAGS=SQOS_PRESENT|EFFECTIVE_ONLY|CONTEXT_TRACKING|DELEGATION|IMPERSONATION|IDENTIFICATION|ANONYMOUS,
		#endregion
	}
}
