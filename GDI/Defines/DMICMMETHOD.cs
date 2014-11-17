namespace Win32
{
	/// <summary>
	/// Specifies how ICM is handled. For a non-ICM application, this member determines if ICM is enabled or disabled.
	/// </summary>
	public enum DMICMMETHOD : uint
	{
		/// <summary>
		/// Specifies that ICM is disabled.
		/// </summary>
		NONE=1,

		/// <summary>
		/// Specifies that ICM is handled by Windows.
		/// </summary>
		SYSTEM=2,

		/// <summary>
		/// Specifies that ICM is handled by the device driver.
		/// </summary>
		DRIVER=3,

		/// <summary>
		/// Specifies that ICM is handled by the destination device.
		/// </summary>
		DEVICE=4,

		/// <summary>
		/// Start of the user-defined methods.
		/// </summary>
		USER=256,
	}
}
