namespace Win32
{
	/// <summary>
	/// Device capabilities.
	/// </summary>
	public enum DC
	{
		/// <summary>
		/// Returns the <see cref="DevMode.dmFields"/> of the printer driver's <see cref="DevMode"/> structure. The <see cref="DevMode.dmFields"/> member
		/// indicates which members in the device-independent portion of the structure are supported by the printer driver.
		/// </summary>
		FIELDS=1,

		/// <summary>
		/// Retrieves a list of supported paper sizes.
		/// </summary>
		PAPERS=2,

		/// <summary>
		/// Retrieves the dimensions, in tenths of a millimeter, of each supported paper size.
		/// </summary>
		PAPERSIZE=3,

		/// <summary>
		/// Returns the minimum paper size that the <see cref="DevMode.dmPaperLength"/> and <see cref="DevMode.dmPaperWidth"/> members of the printer
		/// driver's <see cref="DevMode"/> structure can specify.
		/// </summary>
		MINEXTENT=4,

		/// <summary>
		/// Returns the maximum paper size that the <see cref="DevMode.dmPaperLength"/> and <see cref="DevMode.dmPaperWidth"/> members of the printer
		/// driver's <see cref="DevMode"/> structure can specify.
		/// </summary>
		MAXEXTENT=5,

		/// <summary>
		/// Retrieves a list of available paper bins.
		/// </summary>
		BINS=6,

		/// <summary>
		/// Queries if the printer supports duplex printing.
		/// </summary>
		DUPLEX=7,

		/// <summary>
		/// Returns the <see cref="DevMode.dmSize"/> member of the printer driver's <see cref="DevMode"/> structure.
		/// </summary>
		SIZE=8,

		/// <summary>
		/// Returns the number of bytes required for the device-specific portion of the <see cref="DevMode"/> structure for the printer driver.
		/// </summary>
		EXTRA=9,

		/// <summary>
		/// Returns the specification version to which the printer driver conforms.
		/// </summary>
		VERSION=10,

		/// <summary>
		/// Returns the version number of the printer driver.
		/// </summary>
		DRIVER=11,

		/// <summary>
		/// Retrieves the names of the printer's paper bins.
		/// </summary>
		BINNAMES=12,

		/// <summary>
		/// Retrieves a list of the resolutions supported by the printer.
		/// </summary>
		ENUMRESOLUTIONS=13,

		/// <summary>
		/// Retrieves the names of any additional files that need to be loaded when a driver is installed.
		/// </summary>
		FILEDEPENDENCIES=14,

		/// <summary>
		/// Retrieves the abilities of the driver to use TrueType fonts.
		/// TODO: enum DCTT
		///  DCTT_BITMAP Device can print TrueType fonts as graphics.
		///  DCTT_DOWNLOAD Device can download TrueType fonts.
		///  DCTT_SUBDEV Device can substitute device fonts for TrueType fonts.
		/// </summary>
		TRUETYPE=15,

		/// <summary>
		/// Retrieves a list of supported paper names (for example, Letter or Legal).
		/// </summary>
		PAPERNAMES=16,

		/// <summary>
		/// Returns the relationship between portrait and landscape orientations for a device, in terms of the number of degrees that portrait
		/// orientation is rotated counterclockwise to produce landscape orientation.
		/// </summary>
		ORIENTATION=17,

		/// <summary>
		/// Returns the number of copies the device can print.
		/// </summary>
		COPIES=18,

		/// <summary>
		/// Not used for NT-based operating systems.
		/// </summary>
		BINADJUST=19,

		/// <summary>
		/// Not used for NT-based operating systems.
		/// </summary>
		EMF_COMPLIANT=20,

		/// <summary>
		/// Not used for NT-based operating systems.
		/// </summary>
		DATATYPE_PRODUCED=21,

		/// <summary>
		/// Queries if the printer supports collating.
		/// </summary>
		COLLATE=22,

		/// <summary>
		/// Not used for NT-based operating systems.
		/// </summary>
		MANUFACTURER=23,

		/// <summary>
		/// Not used for NT-based operating systems.
		/// </summary>
		MODEL=24,

		/// <summary>
		/// Retrieves a list of printer description languages supported by the printer.
		/// </summary>
		PERSONALITY=25,

		/// <summary>
		/// The return value indicates the printer's print rate.
		/// </summary>
		PRINTRATE=26,

		/// <summary>
		/// The return value is one of the following values that indicate the print rate units (<see cref="PRINTRATEUNIT"/>) for the value returned for the <see cref="PRINTRATE"/> flag.
		/// </summary>
		PRINTRATEUNIT=27,

		/// <summary>
		/// The return value is the amount of available printer memory, in kilobytes.
		/// </summary>
		PRINTERMEM=28,

		/// <summary>
		/// Retrieves the names of the paper forms that are currently available for use.
		/// </summary>
		MEDIAREADY=29,

		/// <summary>
		/// Queries if the printer supports stapling.
		/// </summary>
		STAPLE=30,

		/// <summary>
		/// The return value indicates the printer's print rate, in pages per minute.
		/// </summary>
		PRINTRATEPPM=31,

		/// <summary>
		/// Queries if the printer supports color printing.
		/// </summary>
		COLORDEVICE=32,

		/// <summary>
		/// Retrieves an array of integers that indicate that printer's ability to print multiple document pages per printed page.
		/// </summary>
		NUP=33,

		/// <summary>
		///  Retrieves the names of the supported media types.
		/// </summary>
		MEDIATYPENAMES=34,

		/// <summary>
		/// Retrieves a list of supported media types.
		/// </summary>
		MEDIATYPES=35,
	}
}
