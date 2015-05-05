namespace Win32
{
	/// <summary>
	/// Windows errors.
	/// </summary>
	public static class ERROR
	{
		/// <summary>
		/// No error.
		/// </summary>
		public const int NO_ERROR=0x0000;

		/// <summary>
		/// Access is denied.
		/// </summary>
		public const int ACCESS_DENIED=0x0005;

		/// <summary>
		/// The data area passed to a system call is too small.
		/// </summary>
		public const int INSUFFICIENT_BUFFER=0x007A;

		/// <summary>
		/// The operation did not complete successfully because it would cause an oplock
		/// to be broken. The caller has requested that existing oplocks not be broken.
		/// </summary>
		public const int CANNOT_BREAK_OPLOCK=0x0322;

		/// <summary>
		/// Overlapped I/O operation is in progress.
		/// </summary>
		public const int IO_PENDING=0x03E5;
	}
}
