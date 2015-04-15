using System;

namespace Win32
{
	/// <summary>
	/// The pitch and family of the font. The low-order bits (Bit 1-0) specify the pitch,
	/// the higher-order bits (7-4) specify the font family. Bit 3 specifies monospace font.
	/// </summary>
	[Flags]
	public enum PitchAndFamily : uint
	{
		/// <summary>
		/// Default pitch.
		/// </summary>
		DEFAULT_PITCH=0,

		/// <summary>
		/// Fixed pitch.
		/// </summary>
		FIXED_PITCH=1,

		/// <summary>
		/// Variable pitch.
		/// </summary>
		VARIABLE_PITCH=2,

		/// <summary>
		/// Monospace font.
		/// </summary>
		MONO_FONT=8,

		/// <summary>
		/// Don't care or don't know.
		/// </summary>
		FF_DONTCARE=0,

		/// <summary>
		/// Variable stroke width, serifed. (Times Roman, Century Schoolbook, etc.)
		/// </summary>
		FF_ROMAN=0x10,

		/// <summary>
		/// Variable stroke width, sans-serifed. (Helvetica, Swiss, etc.)
		/// </summary>
		FF_SWISS=0x20,

		/// <summary>
		/// Constant stroke width, serifed or sans-serifed. (Pica, Elite, Courier, etc.)
		/// </summary>
		FF_MODERN=0x30,

		/// <summary>
		/// Fonts designed to look like handwriting. (Cursive, etc.)
		/// </summary>
		FF_SCRIPT=0x40,

		/// <summary>
		/// Novelty fonts. (Old English, etc.)
		/// </summary>
		FF_DECORATIVE=0x50,
	}
}
