namespace Win32
{
	/// <summary>
	/// Specifies the paper source.
	/// </summary>
	public enum DMBIN : short
	{
		/// <summary>
		/// 
		/// </summary>
		ONLYONE=1,

		/// <summary>
		/// Upper.
		/// </summary>
		UPPER=1,

		/// <summary>
		/// Lower.
		/// </summary>
		LOWER=2,

		/// <summary>
		/// Middle.
		/// </summary>
		MIDDLE=3,

		/// <summary>
		/// Manual.
		/// </summary>
		MANUAL=4,

		/// <summary>
		/// Envelope.
		/// </summary>
		ENVELOPE=5,

		/// <summary>
		/// Envelope manual.
		/// </summary>
		ENVMANUAL=6,

		/// <summary>
		/// Auto.
		/// </summary>
		AUTO=7,

		/// <summary>
		/// Tractor.
		/// </summary>
		TRACTOR=8,

		/// <summary>
		/// Smale format.
		/// </summary>
		SMALLFMT=9,

		/// <summary>
		/// Large format.
		/// </summary>
		LARGEFMT=10,

		/// <summary>
		/// Large capacity.
		/// </summary>
		LARGECAPACITY=11,

		/// <summary>
		/// Casette.
		/// </summary>
		CASSETTE=14,

		/// <summary>
		/// Form source.
		/// </summary>
		FORMSOURCE=15,

		/// <summary>
		/// First predefined paper source.
		/// </summary>
		FIRST=UPPER,

		/// <summary>
		/// Last predefined paper source.
		/// </summary>
		LAST=FORMSOURCE,

		/// <summary>
		/// Start of the user-defined paper sources.
		/// </summary>
		USER=256,
	}
}
