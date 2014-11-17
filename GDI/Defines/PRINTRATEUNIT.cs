namespace Win32
{
	/// <summary>
	/// Print rate units. Return value of <see cref="DC.PRINTRATEUNIT"/>
	/// </summary>
	public enum PRINTRATEUNIT : uint
	{
		/// <summary>
		/// Pages per minute.
		/// </summary>
		PPM=1,

		/// <summary>
		/// Characters per second.
		/// </summary>
		CPS=2,

		/// <summary>
		/// Lines per minute.
		/// </summary>
		LPM=3,

		/// <summary>
		/// Inches per minute.
		/// </summary>
		IPM=4,
	}
}
