namespace Win32.WGL
{
	/// <summary>
	/// Specifies the type of driver support.
	/// </summary>
	public enum wglAccelerationModeARB : int
	{
		/// <summary>
		/// Software renderer.
		/// </summary>
		NO_ACCELERATION_ARB=0x2025,

		/// <summary>
		/// Software renderer supported by a MCD driver.
		/// </summary>
		GENERIC_ACCELERATION_ARB=0x2026,

		/// <summary>
		/// Hardware renderer via an ICD driver.
		/// </summary>
		FULL_ACCELERATION_ARB=0x2027,
	}
}
