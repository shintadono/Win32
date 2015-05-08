using System;

namespace Win32.IO
{
	/// <summary>
	/// Defines how the generic access right for files and directories are made up,
	/// using specific and standard access rights. Use either these values or
	/// <see cref="GENERIC">GENERIC.*</see> or <see cref="ACCESS_MASK">
	/// ACCESS_MASK.GENERIC_*</see>. See <see cref="ACCESS_MASK"/> for more information.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum FILE_GENERIC : uint
	{
		/// <summary>
		/// Collects the specific and standard access rights, that are set for <see cref="GENERIC.READ">GENERIC_READ</see>.
		/// </summary>
		FILE_GENERIC_READ=STANDARD_RIGHTS.READ|FileAccess.FILE_READ_DATA|FileAccess.FILE_READ_ATTRIBUTES|FileAccess.FILE_READ_EA|ACCESS_MASK.SYNCHRONIZE,

		/// <summary>
		/// Collects the specific and standard access rights, that are set for <see cref="GENERIC.READ">GENERIC_WRITE</see>.
		/// </summary>
		FILE_GENERIC_WRITE=STANDARD_RIGHTS.WRITE|FileAccess.FILE_WRITE_DATA|FileAccess.FILE_WRITE_ATTRIBUTES|FileAccess.FILE_WRITE_EA|FileAccess.FILE_APPEND_DATA|ACCESS_MASK.SYNCHRONIZE,

		/// <summary>
		/// Collects the specific and standard access rights, that are set for <see cref="GENERIC.EXECUTE">GENERIC_EXECUTE</see>.
		/// </summary>
		FILE_GENERIC_EXECUTE=STANDARD_RIGHTS.EXECUTE|FileAccess.FILE_READ_ATTRIBUTES|FileAccess.FILE_EXECUTE|ACCESS_MASK.SYNCHRONIZE,
	}
}
