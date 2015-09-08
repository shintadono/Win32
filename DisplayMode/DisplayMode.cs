using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using HWND=System.IntPtr;

namespace Win32
{
	/// <summary>
	/// Class for managing display modes.
	/// </summary>
	[SuppressUnmanagedCodeSecurity]
	public class DisplayMode
	{
		/// <summary>
		/// Width of the display mode in pixels.
		/// </summary>
		public readonly uint Width;

		/// <summary>
		/// Height of the display mode in pixels.
		/// </summary>
		public readonly uint Height;

		/// <summary>
		/// Bits per pixel of the display mode.
		/// </summary>
		public readonly uint BitsPerPixel;

		/// <summary>
		/// Frequency of the display mode in Hertz (Hz)
		/// </summary>
		public readonly uint Frequency;

		/// <summary>
		/// Description of the display mode as string in the form of <c>"1280x960, 24 Bit, 75 Hz"</c>.
		/// </summary>
		public string Description { get { return string.Format("{0}x{1}, {2} Bit, {3} Hz", Width, Height, BitsPerPixel, Frequency); } }

		/// <summary>
		/// Description of the display mode as string in the form of <c>"1280x960, 75 Hz"</c>.
		/// </summary>
		public string Distinguisher { get { return string.Format("{0}x{1}, {2} Hz", Width, Height, Frequency); } }

		/// <summary>
		/// Returns the hash code of this instance.
		/// </summary>
		/// <returns>The hash code.</returns>
		public override int GetHashCode()
		{
			return (int)((Width<<18)^(Height<<6)^Frequency^BitsPerPixel);
		}

		/// <summary>
		/// Compares two instances.
		/// </summary>
		/// <param name="obj">The instance to compare with <c>this</c>.</param>
		/// <returns><b>true</b> if both instances are equal, otherwise <b>false</b>.</returns>
		public override bool Equals(object obj)
		{
			if(obj==null) return false;
			if(ReferenceEquals(this, obj)) return true;

			DisplayMode that=obj as DisplayMode;
			if(that==null) return false;

			return that.Width==Width&&that.Height==Height&&that.BitsPerPixel==BitsPerPixel&&that.Frequency==Frequency;
		}

		/// <summary>
		/// Description of the display mode as string in the form of <c>"[DisplayMode, 1280, 960, 24, 75]"</c>.
		/// </summary>
		/// <returns>The description.</returns>
		public override string ToString()
		{
			return string.Format("[DisplayMode, {0}, {1}, {2}, {3}]", Width, Height, BitsPerPixel, Frequency);;
		}

		private DisplayMode() { }

		/// <summary>
		/// Creates an instance of a display mode.
		/// </summary>
		/// <param name="width">Width of the display mode in pixels.</param>
		/// <param name="height">Height of the display mode in pixels.</param>
		/// <param name="bitsPerPixel">Bits per pixel of the display mode.</param>
		/// <param name="frequency">Frequency of the display mode in Hertz (Hz)</param>
		public DisplayMode(uint width, uint height, uint bitsPerPixel, uint frequency)
		{
			Width=width;
			Height=height;
			BitsPerPixel=bitsPerPixel;
			Frequency=frequency;
		}

		#region Static Stuff
		const string DLLName="User32.dll";
		const string EnumDisplaySettingsW="EnumDisplaySettingsW";
		const string EnumDisplaySettingsExW="EnumDisplaySettingsExW";
		const string ChangeDisplaySettingsW="ChangeDisplaySettingsW";
		const string ChangeDisplaySettingsExW="ChangeDisplaySettingsExW";

		/// <summary>
		/// Retrieves information about one of the graphics modes for a display device.
		/// </summary>
		/// <param name="lpszDeviceName">Specifies the display device.</param>
		/// <param name="iModeNum">The type of information to be retrieved.</param>
		/// <param name="lpDevMode">Returns the requested informations. <see cref="DevMode.dmSize"/> must be initialized with the size of <see cref="DevMode"/>.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint=EnumDisplaySettingsW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern bool EnumDisplaySettings(string lpszDeviceName, DisplaySettingsMode iModeNum, ref DevMode lpDevMode);

		/// <summary>
		/// Retrieves information about one of the graphics modes for a display device.
		/// </summary>
		/// <param name="lpszDeviceName">Specifies the display device.</param>
		/// <param name="iModeNum">The type of information to be retrieved.</param>
		/// <param name="lpDevMode">Returns the requested informations. <see cref="DevMode.dmSize"/> must be initialized with the size of <see cref="DevMode"/>.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint=EnumDisplaySettingsW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern bool EnumDisplaySettings(string lpszDeviceName, uint iModeNum, ref DevMode lpDevMode);

		/// <summary>
		/// Retrieves information about one of the graphics modes for a display device.
		/// </summary>
		/// <param name="lpszDeviceName">Specifies the display device.</param>
		/// <param name="iModeNum">The type of information to be retrieved.</param>
		/// <param name="lpDevMode">Returns the requested informations. <see cref="DevMode.dmSize"/> must be initialized with the size of <see cref="DevMode"/>.</param>
		/// <param name="dwFlags">Extended flags for information retrival.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint=EnumDisplaySettingsExW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern bool EnumDisplaySettingsEx(string lpszDeviceName, DisplaySettingsMode iModeNum, ref DevMode lpDevMode, EDS dwFlags);

		/// <summary>
		/// Retrieves information about one of the graphics modes for a display device.
		/// </summary>
		/// <param name="lpszDeviceName">Specifies the display device.</param>
		/// <param name="iModeNum">The type of information to be retrieved.</param>
		/// <param name="lpDevMode">Returns the requested informations. <see cref="DevMode.dmSize"/> must be initialized with the size of <see cref="DevMode"/>.</param>
		/// <param name="dwFlags">Extended flags for information retrival.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint=EnumDisplaySettingsExW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern bool EnumDisplaySettingsEx(string lpszDeviceName, uint iModeNum, ref DevMode lpDevMode, EDS dwFlags);

		/// <summary>
		/// Returns a list of available display modes. (No modes that are smaller than 640x480/60 Hz and less bit depth then the current mode will be returned.)
		/// </summary>
		/// <returns>The available display modes as list of <see cref="DisplayMode"/> objects.</returns>
		public static List<DisplayMode> GetDisplayModes()
		{
			List<DisplayMode> displayModes=new List<DisplayMode>();

			DevMode displayMode=new DevMode();
			uint modeNumber=0;

			displayMode.dmSize=(ushort)Marshal.SizeOf(displayMode);

			EnumDisplaySettings(null, DisplaySettingsMode.ENUM_CURRENT_SETTINGS, ref displayMode);
			uint currentBitDepth=displayMode.dmBitsPerPel;

			displayModes.Add(new DisplayMode(displayMode.dmPelsWidth, displayMode.dmPelsHeight, currentBitDepth, displayMode.dmDisplayFrequency));

			while(EnumDisplaySettings(null, modeNumber++, ref displayMode))
			{
				if(displayMode.dmPelsWidth>=640&&displayMode.dmPelsHeight>=480&&displayMode.dmBitsPerPel==currentBitDepth&&displayMode.dmDisplayFrequency>=60)
					displayModes.Add(new DisplayMode(displayMode.dmPelsWidth, displayMode.dmPelsHeight, currentBitDepth, displayMode.dmDisplayFrequency));
			}

			return displayModes;
		}

		/// <summary>
		/// Changes the settings of the specified display device to the specified graphics mode.
		/// </summary>
		/// <param name="lpDevMode">A <see cref="DevMode"/> structure that describes the new graphics mode.</param>
		/// <param name="dwflags">A <see cref="CDS"/> specifying how the graphics mode should be changed.</param>
		/// <returns>A <see cref="DISP_CHANGE"/> specifying the result.</returns>
		[DllImport(DLLName, EntryPoint=ChangeDisplaySettingsW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern DISP_CHANGE ChangeDisplaySettings(ref DevMode lpDevMode, CDS dwflags);

		/// <summary>
		/// Changes the settings of the specified display device to the specified graphics mode.
		/// </summary>
		/// <param name="lpDevMode">A pointer to a <see cref="DevMode"/> structure that describes the new graphics mode, or <b>0</b>.</param>
		/// <param name="dwflags">A <see cref="CDS"/> specifying how the graphics mode should be changed.</param>
		/// <returns>A <see cref="DISP_CHANGE"/> specifying the result.</returns>
		[DllImport(DLLName, EntryPoint=ChangeDisplaySettingsW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern DISP_CHANGE ChangeDisplaySettings(IntPtr lpDevMode, CDS dwflags);

		/// <summary>
		/// Changes the settings of the specified display device to the specified graphics mode.
		/// </summary>
		/// <param name="lpszDeviceName">Specifies the display device whose graphics mode will change.</param>
		/// <param name="lpDevMode">A pointer to a <see cref="DevMode"/> structure that describes the new graphics mode, or <b>0</b>.</param>
		/// <param name="hwnd">Reserved; must be <b>0</b>.</param>
		/// <param name="dwflags">A <see cref="CDS"/> specifying how the graphics mode should be changed.</param>
		/// <param name="lParam">A <see cref="VideoParameters"/> specifying video parameters.</param>
		/// <returns>A <see cref="DISP_CHANGE"/> specifying the result.</returns>
		[DllImport(DLLName, EntryPoint=ChangeDisplaySettingsExW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, IntPtr lpDevMode, HWND hwnd, CDS dwflags, ref VideoParameters lParam);

		/// <summary>
		/// Changes the settings of the specified display device to the specified graphics mode.
		/// </summary>
		/// <param name="lpszDeviceName">Specifies the display device whose graphics mode will change.</param>
		/// <param name="lpDevMode">A pointer to a <see cref="DevMode"/> structure that describes the new graphics mode, or <b>0</b>.</param>
		/// <param name="hwnd">Reserved; must be <b>0</b>.</param>
		/// <param name="dwflags">A <see cref="CDS"/> specifying how the graphics mode should be changed.</param>
		/// <param name="lParam">A pointer to a <see cref="VideoParameters"/> structure specifying video parameters, or <b>0</b>.</param>
		/// <returns>A <see cref="DISP_CHANGE"/> specifying the result.</returns>
		[DllImport(DLLName, EntryPoint=ChangeDisplaySettingsExW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, IntPtr lpDevMode, HWND hwnd, CDS dwflags, IntPtr lParam);

		/// <summary>
		/// Changes the settings of the specified display device to the specified graphics mode.
		/// </summary>
		/// <param name="lpszDeviceName">Specifies the display device whose graphics mode will change.</param>
		/// <param name="lpDevMode">A <see cref="DevMode"/> structure that describes the new graphics mode.</param>
		/// <param name="hwnd">Reserved; must be <b>0</b>.</param>
		/// <param name="dwflags">A <see cref="CDS"/> specifying how the graphics mode should be changed.</param>
		/// <param name="lParam">A <see cref="VideoParameters"/> specifying video parameters.</param>
		/// <returns>A <see cref="DISP_CHANGE"/> specifying the result.</returns>
		[DllImport(DLLName, EntryPoint=ChangeDisplaySettingsExW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, ref DevMode lpDevMode, HWND hwnd, CDS dwflags, ref VideoParameters lParam);

		/// <summary>
		/// Changes the settings of the specified display device to the specified graphics mode.
		/// </summary>
		/// <param name="lpszDeviceName">Specifies the display device whose graphics mode will change.</param>
		/// <param name="lpDevMode">A <see cref="DevMode"/> structure that describes the new graphics mode.</param>
		/// <param name="hwnd">Reserved; must be <b>0</b>.</param>
		/// <param name="dwflags">A <see cref="CDS"/> specifying how the graphics mode should be changed.</param>
		/// <param name="lParam">A pointer to a <see cref="VideoParameters"/> structure specifying video parameters, or <b>0</b>.</param>
		/// <returns>A <see cref="DISP_CHANGE"/> specifying the result.</returns>
		[DllImport(DLLName, EntryPoint=ChangeDisplaySettingsExW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, ref DevMode lpDevMode, HWND hwnd, CDS dwflags, IntPtr lParam);
		#endregion
	}
}
