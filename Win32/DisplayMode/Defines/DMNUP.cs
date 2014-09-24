namespace Win32
{
	/// <summary>
	/// Specifies where the NUP is done.
	/// </summary>
	public enum DMNUP : uint
	{
		/// <summary>
		/// The print spooler does the NUP.
		/// </summary>
		SYSTEM=1,

		/// <summary>
		/// The application does the NUP.
		/// </summary>
		ONEUP=2,
	}
}
