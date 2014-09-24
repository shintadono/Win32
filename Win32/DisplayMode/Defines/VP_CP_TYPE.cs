namespace Win32
{
	/// <summary>
	/// Specifies the copy protection type.
	/// </summary>
	public enum VP_CP_TYPE : uint
	{
		/// <summary>
		/// Only DVD trigger bits available.
		/// </summary>
		APS_TRIGGER=0x0001,

		/// <summary>
		/// Full Macrovision data is available.
		/// </summary>
		MACROVISION=0x0002,
	}
}
