using System;

namespace Win32
{
	/// <summary>
	/// Defines the file attributes and flags used by some file functions.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum FILE_ATTRIBUTE : uint
	{
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

		/// <summary>
		/// Identifies a directory.
		/// </summary>
		DIRECTORY=0x00000010,

		/// <summary>
		/// Used to mark file and directories for backup.
		/// </summary>
		ARCHIVE=0x00000020,

		/// <summary>
		/// This value is reserved for system use.
		/// </summary>
		DEVICE=0x00000040,

		/// <summary>
		/// A file that does not have other attributes set. This attribute is valid only when used alone.
		/// </summary>
		NORMAL=0x00000080,

		/// <summary>
		/// Marks a file as temporary storage. The system delays writing data to mass storage, if possible,
		/// since the file is most likely to be delete after use.
		/// </summary>
		TEMPORARY=0x00000100,

		/// <summary>
		/// Marks a file as sparse file.
		/// </summary>
		SPARSE_FILE=0x00000200,

		/// <summary>
		/// Marks a file or directory as associated with a reparse point, or marks a file as a symbolic link.
		/// </summary>
		REPARSE_POINT=0x00000400,

		/// <summary>
		/// Marks a file or directory that is compressed.
		/// </summary>
		COMPRESSED=0x00000800,

		/// <summary>
		/// Marks a file that is moved to an offline storage and not immediately available.
		/// </summary>
		OFFLINE=0x00001000,

		/// <summary>
		/// Marks a file or directory that does not take part in content indexing.
		/// </summary>
		NOT_CONTENT_INDEXED=0x00002000,

		/// <summary>
		/// Marks a file or directory that is encrypted.
		/// </summary>
		ENCRYPTED=0x00004000,

		/// <summary>
		/// Marks a file or directory that is configured with integrity. Supported only on ReFS volumes.
		/// </summary>
		/// <remarks><b>Note:</b> This flag is not supported until Windows Server 2012.</remarks>
		INTEGRITY_STREAM=0x00008000,

		/// <summary>
		/// This value is reserved for system use.
		/// </summary>
		VIRTUAL=0x00010000,

		/// <summary>
		/// The user data stream not to be read by the background data integrity scanner
		/// (AKA scrubber). When set on a directory it only provides inheritance. This
		/// flag is only supported on Storage Spaces and ReFS volumes. It is not included
		/// in an ordinary directory listing.
		/// </summary>
		/// <remarks><b>Note:</b> This flag is not supported until Windows 8 and Windows Server 2012.</remarks>
		NO_SCRUB_DATA=0x00020000,
	}

/*

#define FILE_CASE_SENSITIVE_SEARCH          0x00000001  
#define FILE_CASE_PRESERVED_NAMES           0x00000002  
#define FILE_UNICODE_ON_DISK                0x00000004  
#define FILE_PERSISTENT_ACLS                0x00000008  
#define FILE_FILE_COMPRESSION               0x00000010  
#define FILE_VOLUME_QUOTAS                  0x00000020  
#define FILE_SUPPORTS_SPARSE_FILES          0x00000040  
#define FILE_SUPPORTS_REPARSE_POINTS        0x00000080  
#define FILE_SUPPORTS_REMOTE_STORAGE        0x00000100  
#define FILE_VOLUME_IS_COMPRESSED           0x00008000  
#define FILE_SUPPORTS_OBJECT_IDS            0x00010000  
#define FILE_SUPPORTS_ENCRYPTION            0x00020000  
#define FILE_NAMED_STREAMS                  0x00040000  
#define FILE_READ_ONLY_VOLUME               0x00080000  
#define FILE_SEQUENTIAL_WRITE_ONCE          0x00100000  
#define FILE_SUPPORTS_TRANSACTIONS          0x00200000  
#define FILE_SUPPORTS_HARD_LINKS            0x00400000  
#define FILE_SUPPORTS_EXTENDED_ATTRIBUTES   0x00800000  
#define FILE_SUPPORTS_OPEN_BY_FILE_ID       0x01000000  
#define FILE_SUPPORTS_USN_JOURNAL           0x02000000  
	*/
}
