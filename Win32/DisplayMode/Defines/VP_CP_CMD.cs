namespace Win32
{
	/// <summary>
	/// Specifies the copy protection command.
	/// </summary>
	public enum VP_CP_CMD : uint
	{
		/// <summary>
		/// Activate copy protection.
		/// </summary>
		ACTIVATE=0x0001,

		/// <summary>
		/// Deactivate copy protection.
		/// </summary>
		DEACTIVATE=0x0002,

		/// <summary>
		/// Change copy protection.
		/// </summary>
		CHANGE=0x0004,
	}
}
