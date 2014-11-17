using System;

namespace Win32
{
	/// <summary>
	/// Specifies which members of the <see cref="DevMode"/> structure have been initialized.
	/// </summary>
	[Flags]
	public enum DM : uint
	{
		/// <summary>
		/// <see cref="DevMode.dmOrientation"/>
		/// </summary>
		ORIENTATION=0x00000001,

		/// <summary>
		/// <see cref="DevMode.dmPaperSize"/>
		/// </summary>
		PAPERSIZE=0x00000002,

		/// <summary>
		/// <see cref="DevMode.dmPaperLength"/>
		/// </summary>
		PAPERLENGTH=0x00000004,

		/// <summary>
		/// <see cref="DevMode.dmPaperWidth"/>
		/// </summary>
		PAPERWIDTH=0x00000008,

		/// <summary>
		/// <see cref="DevMode.dmScale"/>
		/// </summary>
		SCALE=0x00000010,

		/// <summary>
		/// <see cref="DevMode.dmPosition"/>
		/// </summary>
		POSITION=0x00000020,

		/// <summary>
		/// <see cref="DevMode.dmNup"/>
		/// </summary>
		NUP=0x00000040,

		/// <summary>
		/// <see cref="DevMode.dmDisplayOrientation"/>
		/// </summary>
		DISPLAYORIENTATION=0x00000080,

		/// <summary>
		/// <see cref="DevMode.dmCopies"/>
		/// </summary>
		COPIES=0x00000100,

		/// <summary>
		/// <see cref="DevMode.dmDefaultSource"/>
		/// </summary>
		DEFAULTSOURCE=0x00000200,

		/// <summary>
		/// <see cref="DevMode.dmPrintQuality"/>
		/// </summary>
		PRINTQUALITY=0x00000400,

		/// <summary>
		/// <see cref="DevMode.dmColor"/>
		/// </summary>
		COLOR=0x00000800,

		/// <summary>
		/// <see cref="DevMode.dmDuplex"/>
		/// </summary>
		DUPLEX=0x00001000,

		/// <summary>
		/// <see cref="DevMode.dmYResolution"/>
		/// </summary>
		YRESOLUTION=0x00002000,

		/// <summary>
		/// <see cref="DevMode.dmTTOption"/>
		/// </summary>
		TTOPTION=0x00004000,

		/// <summary>
		/// <see cref="DevMode.dmCollate"/>
		/// </summary>
		COLLATE=0x00008000,

		/// <summary>
		/// <see cref="DevMode.dmFormName"/>
		/// </summary>
		FORMNAME=0x00010000,

		/// <summary>
		/// <see cref="DevMode.dmLogPixels"/>
		/// </summary>
		LOGPIXELS=0x00020000,

		/// <summary>
		/// <see cref="DevMode.dmBitsPerPel"/>
		/// </summary>
		BITSPERPEL=0x00040000,

		/// <summary>
		/// <see cref="DevMode.dmPelsWidth"/>
		/// </summary>
		PELSWIDTH=0x00080000,

		/// <summary>
		/// <see cref="DevMode.dmPelsHeight"/>
		/// </summary>
		PELSHEIGHT=0x00100000,

		/// <summary>
		/// <see cref="DevMode.dmDisplayFlags"/>
		/// </summary>
		DISPLAYFLAGS=0x00200000,

		/// <summary>
		/// <see cref="DevMode.dmDisplayFrequency"/>
		/// </summary>
		DISPLAYFREQUENCY=0x00400000,

		/// <summary>
		/// <see cref="DevMode.dmICMMethod"/>
		/// </summary>
		ICMMETHOD=0x00800000,

		/// <summary>
		/// <see cref="DevMode.dmICMIntent"/>
		/// </summary>
		ICMINTENT=0x01000000,

		/// <summary>
		/// <see cref="DevMode.dmMediaType"/>
		/// </summary>
		MEDIATYPE=0x02000000,

		/// <summary>
		/// <see cref="DevMode.dmDitherType"/>
		/// </summary>
		DITHERTYPE=0x04000000,

		/// <summary>
		/// <see cref="DevMode.dmPanningWidth"/>
		/// </summary>
		PANNINGWIDTH=0x08000000,

		/// <summary>
		/// <see cref="DevMode.dmPanningHeight"/>
		/// </summary>
		PANNINGHEIGHT=0x10000000,

		/// <summary>
		/// <see cref="DevMode.dmDisplayFixedOutput"/>
		/// </summary>
		DISPLAYFIXEDOUTPUT=0x20000000,

		/// <summary>
		/// Not used.
		/// </summary>
		UPDATE=1,

		/// <summary>
		/// The function writes the printer driver's current print settings, including private data, to the <see cref="DevMode"/> data
		/// structure supplied by the caller. The caller must allocate a buffer sufficiently large to contain the information.
		/// This value is also defined as <see cref="OUT_BUFFER"/>.
		/// </summary>
		COPY=2,

		/// <summary>
		/// The function presents the printer driver's Print Setup property sheet and then changes the settings in the printer's
		/// <see cref="DevMode"/> data structure to those values specified by the user. This value is also defined as <see cref="IN_PROMPT"/>.
		/// </summary>
		PROMPT=4,

		/// <summary>
		/// The caller has supplied a <see cref="DevMode"/> structure, the function update its internal <see cref="DevMode"/>
		/// structure to reflect the contents of the supplied <see cref="DevMode"/>.
		/// This value is also defined as <see cref="IN_BUFFER"/>.
		/// </summary>
		MODIFY=8,

		/// <summary>
		/// The caller has supplied a <see cref="DevMode"/> structure, the function update its internal <see cref="DevMode"/>
		/// structure to reflect the contents of the supplied <see cref="DevMode"/>.
		/// This value is also defined as <see cref="MODIFY"/>.
		/// </summary>
		IN_BUFFER=MODIFY,
		
		/// <summary>
		/// The function presents the printer driver's Print Setup property sheet and then changes the settings in the printer's
		/// <see cref="DevMode"/> data structure to those values specified by the user. This value is also defined as <see cref="PROMPT"/>.
		/// </summary>
		IN_PROMPT=PROMPT,

		/// <summary>
		/// The function writes the printer driver's current print settings, including private data, to the <see cref="DevMode"/> data
		/// structure supplied by the caller. The caller must allocate a buffer sufficiently large to contain the information.
		/// This value is also defined as <see cref="COPY"/>.
		/// </summary>
		OUT_BUFFER=COPY,

		/// <summary>
		/// Not used.
		/// </summary>
		OUT_DEFAULT=UPDATE,
	}
}
