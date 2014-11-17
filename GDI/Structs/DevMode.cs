using System;
using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// The <see cref="DevMode"/> data structure contains information about the initialization and environment of a printer or a display device.
	/// </summary>
	[StructLayout(LayoutKind.Explicit, CharSet=CharSet.Unicode)]
	public struct DevMode
	{
		/// <summary>
		/// Size of <see cref="dmDeviceName"/> in <b>char</b>s.
		/// </summary>
		public const int CCHDEVICENAME=32;

		/// <summary>
		/// Size of <see cref="dmFormName"/> in <b>char</b>s.
		/// </summary>
		public const int CCHFORMNAME=32;

		/// <summary>
		/// A zero-terminated character array that specifies the "friendly" name of the printer or display.
		/// </summary>
		[FieldOffset(0)]
		public unsafe fixed char dmDeviceName[CCHDEVICENAME];

		/// <summary>
		/// Property to access <see cref="dmDeviceName"/> as string.
		/// </summary>
		public string DeviceName
		{
			get
			{
				unsafe
				{
					fixed(char* devName=dmDeviceName) return new string(devName);
				}
			}
			set
			{
				int len=Math.Min(value.Length, 31);
				unsafe
				{
					fixed(char* devName=dmDeviceName)
					{
						for(int i=0; i<len; i++) devName[i]=value[i];
						devName[len]='\0';
					}
				}
			}
		}

		/// <summary>
		/// The version number of the initialization data specification on which the structure is based.
		/// </summary>
		[FieldOffset(64)]
		public ushort dmSpecVersion;

		/// <summary>
		/// The driver version number assigned by the driver developer.
		/// </summary>
		[FieldOffset(66)]
		public ushort dmDriverVersion;

		/// <summary>
		/// Specifies the size, in bytes, of the <see cref="DevMode"/> structure, not including any private driver-specific data that might follow the structure's public members.
		/// </summary>
		[FieldOffset(68)]
		public ushort dmSize;

		/// <summary>
		/// Contains the number of bytes of private driver-data that follow this structure. If a device driver does not use device-specific information, set this member to zero.
		/// </summary>
		[FieldOffset(70)]
		public ushort dmDriverExtra;

		/// <summary>
		/// Specifies whether certain members of the <see cref="DevMode"/> structure have been initialized.
		/// </summary>
		[FieldOffset(72)]
		public DM dmFields;

		/// <summary>
		/// For printer devices only, selects the orientation of the paper.
		/// </summary>
		[FieldOffset(76)]
		public DMORIENT dmOrientation;

		/// <summary>
		/// For printer devices only, selects the size of the paper to print on.
		/// </summary>
		[FieldOffset(78)]
		public DMPAPER dmPaperSize;

		/// <summary>
		/// For printer devices only, overrides the length of the paper specified by the <see cref="dmPaperSize"/> member, either for custom paper sizes or for devices such as dot-matrix printers that can print on a page of arbitrary length.
		/// </summary>
		[FieldOffset(80)]
		public short dmPaperLength;

		/// <summary>
		/// For printer devices only, overrides the width of the paper specified by the <see cref="dmPaperSize"/> member.
		/// </summary>
		[FieldOffset(82)]
		public short dmPaperWidth;

		/// <summary>
		/// Specifies the factor by which the printed output is to be scaled.
		/// </summary>
		[FieldOffset(84)]
		public short dmScale;

		/// <summary>
		/// Selects the number of copies printed if the device supports multiple-page copies.
		/// </summary>
		[FieldOffset(86)]
		public short dmCopies;

		/// <summary>
		/// Specifies the paper source. 
		/// </summary>
		[FieldOffset(88)]
		public DMBIN dmDefaultSource;

		/// <summary>
		/// Specifies the printer resolution.
		/// </summary>
		[FieldOffset(90)]
		public DMRES dmPrintQuality;

		/// <summary>
		/// For display devices only, a <see cref="Point"/> structure that indicates the positional coordinates of the
		/// display device in reference to the desktop area. The primary display device is always located at coordinates (0,0).
		/// </summary>
		[FieldOffset(76)]
		public Point dmPosition;

		/// <summary>
		/// For display devices only, the orientation at which images should be presented.
		/// </summary>
		[FieldOffset(84)]
		public DMDO dmDisplayOrientation;

		/// <summary>
		/// For fixed-resolution display devices only, how the display presents a low-resolution mode on a higher-resolution display.
		/// </summary>
		[FieldOffset(88)]
		public DMDFO dmDisplayFixedOutput;

		/// <summary>
		/// Switches between color and monochrome on color printers.
		/// </summary>
		[FieldOffset(92)]
		public DMCOLOR dmColor;

		/// <summary>
		/// Selects duplex or double-sided printing for printers capable of duplex printing.
		/// </summary>
		[FieldOffset(94)]
		public DMDUP dmDuplex;

		/// <summary>
		/// Specifies the y-resolution, in dots per inch, of the printer.
		/// </summary>
		[FieldOffset(96)]
		public short dmYResolution;

		/// <summary>
		/// Specifies how TrueType fonts should be printed. 
		/// </summary>
		[FieldOffset(98)]
		public DMTT dmTTOption;

		/// <summary>
		/// Specifies whether collation should be used when printing multiple copies.
		/// </summary>
		[FieldOffset(100)]
		public DMCOLLATE dmCollate;

		/// <summary>
		/// A zero-terminated character array that specifies the name of the form to use; for example, "Letter" or "Legal".
		/// </summary>
		[FieldOffset(102)]
		public unsafe fixed char dmFormName[CCHFORMNAME];

		/// <summary>
		/// Property to access <see cref="dmFormName"/> as string.
		/// </summary>
		public string FormName
		{
			get
			{
				unsafe
				{
					fixed(char* formName=dmFormName) return new string(formName);
				}
			}
			set
			{
				int len=Math.Min(value.Length, 31);
				unsafe
				{
					fixed(char* formName=dmFormName)
					{
						for(int i=0; i<len; i++) formName[i]=value[i];
						formName[len]='\0';
					}
				}
			}
		}

		/// <summary>
		/// The number of pixels per logical inch.
		/// </summary>
		[FieldOffset(166)]
		public ushort dmLogPixels;

		/// <summary>
		/// Specifies the color resolution, in bits per pixel, of the display device.
		/// </summary>
		[FieldOffset(168)]
		public uint dmBitsPerPel;

		/// <summary>
		/// Specifies the width, in pixels, of the visible device surface.
		/// </summary>
		[FieldOffset(172)]
		public uint dmPelsWidth;

		/// <summary>
		/// Specifies the height, in pixels, of the visible device surface.
		/// </summary>
		[FieldOffset(176)]
		public uint dmPelsHeight;

		/// <summary>
		/// Specifies the device's display mode.
		/// </summary>
		[FieldOffset(180)]
		public DMDISPLAYFLAGS dmDisplayFlags;

		/// <summary>
		/// Specifies where the NUP is done.
		/// </summary>
		[FieldOffset(180)]
		public DMNUP dmNup;

		/// <summary>
		/// Specifies the frequency, in hertz (cycles per second), of the display device in a particular mode.
		/// </summary>
		[FieldOffset(184)]
		public uint dmDisplayFrequency;

		/// <summary>
		/// Specifies how ICM is handled. For a non-ICM application, this member determines if ICM is enabled or disabled.
		/// </summary>
		[FieldOffset(188)]
		public DMICMMETHOD dmICMMethod;

		/// <summary>
		/// Specifies which color matching method, or intent, should be used by default.
		/// </summary>
		[FieldOffset(192)]
		public DMICM dmICMIntent;

		/// <summary>
		/// Specifies the type of media being printed on.
		/// </summary>
		[FieldOffset(196)]
		public DMMEDIA dmMediaType;

		/// <summary>
		/// Specifies how dithering is to be done.
		/// </summary>
		[FieldOffset(200)]
		public DMDITHER dmDitherType;

		/// <summary>
		/// This member must be zero.
		/// </summary>
		[FieldOffset(204)]
		public uint dmReserved1;

		/// <summary>
		/// This member must be zero.
		/// </summary>
		[FieldOffset(208)]
		public uint dmReserved2;

		/// <summary>
		/// This member must be zero.
		/// </summary>
		[FieldOffset(212)]
		public uint dmPanningWidth;

		/// <summary>
		/// This member must be zero.
		/// </summary>
		[FieldOffset(216)]
		public uint dmPanningHeight;
	}
}
