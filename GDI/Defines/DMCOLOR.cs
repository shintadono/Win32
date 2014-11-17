namespace Win32
{
	/// <summary>
	/// Switches between color and monochrome on color printers.
	/// </summary>
	public enum DMCOLOR : short
	{
		/// <summary>
		/// Print monochrome on color printers.
		/// </summary>
		MONOCHROME=1,

		/// <summary>
		/// Print color on color printers.
		/// </summary>
		COLOR=2,
	}
}
