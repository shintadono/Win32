namespace Win32
{
	/// <summary>
	/// Selects duplex or double-sided printing for printers capable of duplex printing.
	/// </summary>
	public enum DMDUP : short
	{
		/// <summary>
		/// Normal (nonduplex) printing.
		/// </summary>
		SIMPLEX=1,

		/// <summary>
		/// Short-edge binding, that is, the long edge of the page is horizontal.
		/// </summary>
		HORIZONTAL=2,

		/// <summary>
		/// Long-edge binding, that is, the long edge of the page is vertical.
		/// </summary>
		VERTICAL=3,
	}
}
