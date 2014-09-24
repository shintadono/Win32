namespace Win32
{
	/// <summary>
	/// Specifies whether to retrieve or set the values that the other members of this structure specify.
	/// </summary>
	public enum VP_COMMAND : uint
	{
		/// <summary>
		/// Gets current video capabilities. If video capability is not supported, <see cref="VideoParameters.dwFlags"/> is 0.
		/// </summary>
		GET=0x0001,

		/// <summary>
		/// Sets video parameters.
		/// </summary>
		SET=0x0002,
	}
}
