namespace Win32
{
	/// <summary>
	/// Character sets.
	/// </summary>
	public enum Charset : uint
	{
		/// <summary>
		/// ANSI
		/// </summary>
		ANSI=0,

		/// <summary>
		/// Value based on the current system locale.
		/// </summary>
		DEFAULT=1,

		/// <summary>
		/// Symbol
		/// </summary>
		SYMBOL=2,

		/// <summary>
		/// Mac
		/// </summary>
		MAC=77,

		/// <summary>
		/// Japanise
		/// </summary>
		SHIFTJIS=128,

		/// <summary>
		/// HANGUL
		/// </summary>
		HANGUL=129,

		/// <summary>
		/// HANGUEL
		/// </summary>
		HANGEUL=HANGUL,

		/// <summary>
		/// Korean
		/// </summary>
		JOHAB=130,

		/// <summary>
		/// Simple chinese
		/// </summary>
		GB2312=134,

		/// <summary>
		/// Traditional chinese
		/// </summary>
		CHINESEBIG5=136,

		/// <summary>
		/// Greek
		/// </summary>
		GREEK=161,

		/// <summary>
		/// Turkish
		/// </summary>
		TURKISH=162,

		/// <summary>
		/// Vietnamese
		/// </summary>
		VIETNAMESE=163,

		/// <summary>
		/// Hebrew
		/// </summary>
		HEBREW=177,

		/// <summary>
		/// Arabic
		/// </summary>
		ARABIC=178,

		/// <summary>
		/// Baltic languages.
		/// </summary>
		BALTIC=186,

		/// <summary>
		/// Russian
		/// </summary>
		RUSSIAN=204,

		/// <summary>
		/// Thai
		/// </summary>
		THAI=222,

		/// <summary>
		/// Eastern europe languages.
		/// </summary>
		EASTEUROPE=238,

		/// <summary>
		/// Is operating-system dependent.
		/// </summary>
		OEM=255,
	}
}
