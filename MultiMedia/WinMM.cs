using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Win32.MultiMedia
{
	/// <summary>
	/// Windows Multimedia binding for .NET, implementing Windows-specific multimedia functionality.
	/// </summary>
	[SuppressUnmanagedCodeSecurity]
	public static class WinMM
	{
		// --- Fields ---
		const string DLLName = "winmm.dll";

		#region Constants
		/// <summary>
		/// Synchronous playback of a sound event. <b>PlaySound</b> returns after the sound event completes.
		/// </summary>
		public const uint SND_SYNC = 0x0000;

		/// <summary>
		/// The sound is played asynchronously and <b>PlaySound</b> returns immediately after beginning the sound.
		/// To terminate an asynchronously played waveform sound, call <b>PlaySound</b> with <i>sound</i> set to NULL.
		/// </summary>
		public const uint SND_ASYNC = 0x0001;

		/// <summary>
		/// No default sound event is used. If the sound cannot be found, <b>PlaySound</b>
		/// returns silently without playing the default sound.
		/// </summary>
		public const uint SND_NODEFAULT = 0x0002;

		/// <summary>
		/// A sound event's file is loaded in RAM. The parameter specified by <i>sound</i>
		/// must point to an image of a sound in memory.
		/// </summary>
		public const uint SND_MEMORY = 0x0004;

		/// <summary>
		/// The sound plays repeatedly until <b>PlaySound</b> is called again with the <i>sound</i> parameter set to NULL.
		/// You must also specify the <see cref="SND_ASYNC" /> flag to indicate an asynchronous sound event.
		/// </summary>
		public const uint SND_LOOP = 0x0008;

		/// <summary>
		/// <para>
		/// The specified sound event will yield to another sound event that is already playing.  If a sound cannot be
		/// played because the resource needed to generate that sound is busy playing another sound, the function
		/// immediately returns FALSE without playing the requested sound.
		/// </para>
		/// <para>
		/// If this flag is not specified, <b>PlaySound</b> attempts to stop the currently
		/// playing sound so that the device can be used to play the new sound.
		/// </para>
		/// </summary>
		public const uint SND_NOSTOP = 0x0010;

		/// <summary>
		/// If the driver is busy, return immediately without playing the sound.
		/// </summary>
		public const uint SND_NOWAIT = 0x00002000;

		/// <summary>
		/// The <i>sound</i> parameter is a system-event alias in the registry or the WIN.INI
		/// file. Do not use with either <see cref="SND_FILENAME" /> or
		/// <see cref="SND_RESOURCE" />.
		/// </summary>
		public const uint SND_ALIAS = 0x00010000;

		/// <summary>
		/// The <i>sound</i> parameter is a predefined sound identifier.
		/// </summary>
		public const uint SND_ALIAS_ID = 0x00110000;

		/// <summary>
		/// The <i>sound</i> parameter is a filename.
		/// </summary>
		public const uint SND_FILENAME = 0x00020000;

		/// <summary>
		/// The <i>sound</i> parameter is a resource identifier; <i>mod</i> must identify the
		/// instance that contains the resource.
		/// </summary>
		public const uint SND_RESOURCE = 0x00040004;

		/// <summary>
		/// <para>
		/// Sounds are to be stopped for the calling task. If <i>sound</i> is not NULL, all instances of the specified
		/// sound are stopped. If <i>sound</i> is NULL, all sounds that are playing on behalf of the calling task are stopped.
		/// </para>
		/// <para>
		/// You must also specify the instance handle to stop <see cref="SND_RESOURCE" />
		/// events.
		/// </para>
		/// </summary>
		public const uint SND_PURGE = 0x0040;

		/// <summary>
		/// The sound is played using an application-specific association.
		/// </summary>
		public const uint SND_APPLICATION = 0x0080;

		/// <summary>
		/// Timer base identifier.
		/// </summary>
		public const uint TIMERR_BASE = 96;

		/// <summary>
		/// Successful.
		/// </summary>
		public const uint TIMERR_NOERROR = 0;

		/// <summary>
		/// Resolution specified is out of range.
		/// </summary>
		public const uint TIMERR_NOCANDO = TIMERR_BASE + 1;

		#region public const uint JOY_BUTTONs
		/// <summary>
		/// Joystick button 1
		/// </summary>
		public const uint JOY_BUTTON1 = 0x00000001;

		/// <summary>
		/// Joystick button 2
		/// </summary>
		public const uint JOY_BUTTON2 = 0x00000002;

		/// <summary>
		/// Joystick button 3
		/// </summary>
		public const uint JOY_BUTTON3 = 0x00000004;

		/// <summary>
		/// Joystick button 4
		/// </summary>
		public const uint JOY_BUTTON4 = 0x00000008;

		/// <summary>
		/// Joystick button 5
		/// </summary>
		public const uint JOY_BUTTON5 = 0x00000010;

		/// <summary>
		/// Joystick button 6
		/// </summary>
		public const uint JOY_BUTTON6 = 0x00000020;

		/// <summary>
		/// Joystick button 7
		/// </summary>
		public const uint JOY_BUTTON7 = 0x00000040;

		/// <summary>
		/// Joystick button 8
		/// </summary>
		public const uint JOY_BUTTON8 = 0x00000080;

		/// <summary>
		/// Joystick button 9
		/// </summary>
		public const uint JOY_BUTTON9 = 0x00000100;

		/// <summary>
		/// Joystick button 10
		/// </summary>
		public const uint JOY_BUTTON10 = 0x00000200;

		/// <summary>
		/// Joystick button 11
		/// </summary>
		public const uint JOY_BUTTON11 = 0x00000400;

		/// <summary>
		/// Joystick button 12
		/// </summary>
		public const uint JOY_BUTTON12 = 0x00000800;

		/// <summary>
		/// Joystick button 13
		/// </summary>
		public const uint JOY_BUTTON13 = 0x00001000;

		/// <summary>
		/// Joystick button 14
		/// </summary>
		public const uint JOY_BUTTON14 = 0x00002000;

		/// <summary>
		/// Joystick button 15
		/// </summary>
		public const uint JOY_BUTTON15 = 0x00004000;

		/// <summary>
		/// Joystick button 16
		/// </summary>
		public const uint JOY_BUTTON16 = 0x00008000;

		/// <summary>
		/// Joystick button 17
		/// </summary>
		public const uint JOY_BUTTON17 = 0x00010000;

		/// <summary>
		/// Joystick button 18
		/// </summary>
		public const uint JOY_BUTTON18 = 0x00020000;

		/// <summary>
		/// Joystick button 19
		/// </summary>
		public const uint JOY_BUTTON19 = 0x00040000;

		/// <summary>
		/// Joystick button 20
		/// </summary>
		public const uint JOY_BUTTON20 = 0x00080000;

		/// <summary>
		/// Joystick button 21
		/// </summary>
		public const uint JOY_BUTTON21 = 0x00100000;

		/// <summary>
		/// Joystick button 22
		/// </summary>
		public const uint JOY_BUTTON22 = 0x00200000;

		/// <summary>
		/// Joystick button 23
		/// </summary>
		public const uint JOY_BUTTON23 = 0x00400000;

		/// <summary>
		/// Joystick button 24
		/// </summary>
		public const uint JOY_BUTTON24 = 0x00800000;

		/// <summary>
		/// Joystick button 25
		/// </summary>
		public const uint JOY_BUTTON25 = 0x01000000;

		/// <summary>
		/// Joystick button 26
		/// </summary>
		public const uint JOY_BUTTON26 = 0x02000000;

		/// <summary>
		/// Joystick button 27
		/// </summary>
		public const uint JOY_BUTTON27 = 0x04000000;

		/// <summary>
		/// Joystick button 28
		/// </summary>
		public const uint JOY_BUTTON28 = 0x08000000;

		/// <summary>
		/// Joystick button 29
		/// </summary>
		public const uint JOY_BUTTON29 = 0x10000000;

		/// <summary>
		/// Joystick button 30
		/// </summary>
		public const uint JOY_BUTTON30 = 0x20000000;

		/// <summary>
		/// Joystick button 31
		/// </summary>
		public const uint JOY_BUTTON31 = 0x40000000;

		/// <summary>
		/// Joystick button 32
		/// </summary>
		public const uint JOY_BUTTON32 = 0x80000000;
		#endregion

		/// <summary>
		/// Joystick has z-coordinate information.
		/// </summary>
		public const uint JOYCAPS_HASZ = 1;

		/// <summary>
		/// Joystick has rudder (fourth axis) information.
		/// </summary>
		public const uint JOYCAPS_HASR = 2;

		/// <summary>
		/// Joystick has u-coordinate (fifth axis) information.
		/// </summary>
		public const uint JOYCAPS_HASU = 4;

		/// <summary>
		/// Joystick has v-coordinate (sixth axis) information.
		/// </summary>
		public const uint JOYCAPS_HASV = 8;

		/// <summary>
		/// Joystick has point-of-view information.
		/// </summary>
		public const uint JOYCAPS_HASPOV = 16;

		/// <summary>
		/// Joystick point-of-view supports discrete values (centered, forward, backward, left, and right).
		/// </summary>
		public const uint JOYCAPS_POV4DIR = 32;

		/// <summary>
		/// Joystick point-of-view supports continuous degree bearings.
		/// </summary>
		public const uint JOYCAPS_POVCTS = 64;

		/// <summary></summary>
		public const uint JOY_RETURNX = 0x00000001;

		/// <summary></summary>
		public const uint JOY_RETURNY = 0x00000002;

		/// <summary></summary>
		public const uint JOY_RETURNZ = 0x00000004;

		/// <summary></summary>
		public const uint JOY_RETURNR = 0x00000008;

		/// <summary></summary>
		public const uint JOY_RETURNU = 0x00000010;

		/// <summary></summary>
		public const uint JOY_RETURNV = 0x00000020;

		/// <summary></summary>
		public const uint JOY_RETURNPOV = 0x00000040;

		/// <summary></summary>
		public const uint JOY_RETURNBUTTONS = 0x00000080;

		/// <summary></summary>
		public const uint JOY_RETURNRAWDATA = 0x00000100;

		/// <summary></summary>
		public const uint JOY_RETURNPOVCTS = 0x00000200;

		/// <summary></summary>
		public const uint JOY_RETURNCENTERED = 0x00000400;

		/// <summary></summary>
		public const uint JOY_USEDEADZONE = 0x00000800;

		/// <summary></summary>
		public const uint JOY_RETURNALL = (JOY_RETURNX | JOY_RETURNY | JOY_RETURNZ | JOY_RETURNR | JOY_RETURNU | JOY_RETURNV | JOY_RETURNPOV | JOY_RETURNBUTTONS);

		/// <summary></summary>
		public const uint JOY_CAL_READALWAYS = 0x00010000;

		/// <summary></summary>
		public const uint JOY_CAL_READXYONLY = 0x00020000;

		/// <summary></summary>
		public const uint JOY_CAL_READ3 = 0x00040000;

		/// <summary></summary>
		public const uint JOY_CAL_READ4 = 0x00080000;

		/// <summary></summary>
		public const uint JOY_CAL_READXONLY = 0x00100000;

		/// <summary></summary>
		public const uint JOY_CAL_READYONLY = 0x00200000;

		/// <summary></summary>
		public const uint JOY_CAL_READ5 = 0x00400000;

		/// <summary></summary>
		public const uint JOY_CAL_READ6 = 0x00800000;

		/// <summary></summary>
		public const uint JOY_CAL_READZONLY = 0x00800000;

		/// <summary></summary>
		public const uint JOY_CAL_READRONLY = 0x02000000;

		/// <summary></summary>
		public const uint JOY_CAL_READUONLY = 0x04000000;

		/// <summary></summary>
		public const uint JOY_CAL_READVONLY = 0x08000000;

		/// <summary></summary>
		public const uint JOY_POVCENTERED = 65535;

		/// <summary></summary>
		public const uint JOY_POVFORWARD = 0;

		/// <summary></summary>
		public const uint JOY_POVRIGHT = 9000;

		/// <summary></summary>
		public const uint JOY_POVBACKWARD = 18000;

		/// <summary></summary>
		public const uint JOY_POVLEFT = 27000;

		/// <summary></summary>
		public const uint MMSYSERR_BASE = 0;

		/// <summary></summary>
		public const uint MMSYSERR_NOERROR = 0;

		/// <summary></summary>
		public const uint MMSYSERR_ERROR = 1;

		/// <summary></summary>
		public const uint MMSYSERR_BADDEVICEID = 2;

		/// <summary></summary>
		public const uint MMSYSERR_NOTENABLED = 3;

		/// <summary></summary>
		public const uint MMSYSERR_ALLOCATED = 4;

		/// <summary></summary>
		public const uint MMSYSERR_INVALHANDLE = 5;

		/// <summary></summary>
		public const uint MMSYSERR_NODRIVER = 6;

		/// <summary></summary>
		public const uint MMSYSERR_NOMEM = 7;

		/// <summary></summary>
		public const uint MMSYSERR_NOTSUPPORTED = 8;

		/// <summary></summary>
		public const uint MMSYSERR_BADERRNUM = 9;

		/// <summary></summary>
		public const uint MMSYSERR_INVALFLAG = 10;

		/// <summary></summary>
		public const uint MMSYSERR_INVALPARAM = 11;

		/// <summary></summary>
		public const uint MMSYSERR_LASTERROR = 11;

		/// <summary></summary>
		public const uint JOYERR_NOERROR = 0;

		/// <summary></summary>
		public const uint JOYERR_PARMS = 165;

		/// <summary></summary>
		public const uint JOYERR_NOCANDO = 166;

		/// <summary></summary>
		public const uint JOYERR_UNPLUGGED = 167;

		/// <summary></summary>
		public const uint MM_JOY1MOVE = 0x3A0;

		/// <summary></summary>
		public const uint MM_JOY2MOVE = 0x3A1;

		/// <summary></summary>
		public const uint MM_JOY1ZMOVE = 0x3A2;

		/// <summary></summary>
		public const uint MM_JOY2ZMOVE = 0x3A3;
		#endregion

		// --- Structures & Classes ---
		/// <summary>
		/// The JOYCAPS structure contains information about the joystick capabilities.
		/// </summary>
		/// <seealso cref="WinMM.JOYINFO"/>
		/// <seealso cref="WinMM.JOYINFOEX"/>
		/// <seealso cref="WinMM.joySetCapture"/>
		[StructLayout(LayoutKind.Sequential)]
		public struct JOYCAPS
		{
			/// <summary>
			/// Manufacturer identifier. Manufacturer identifiers are defined in Manufacturer and Product Identifiers.
			/// </summary>
			public ushort wMid;

			/// <summary>
			/// Product identifier. Product identifiers are defined in Manufacturer and Product Identifiers.
			/// </summary>
			public ushort wPid;

			/// <summary>
			/// Null-terminated string containing the joystick product name.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string szPname;

			/// <summary>
			/// Minimum X-coordinate.
			/// </summary>
			public uint wXmin;

			/// <summary>
			/// Maximum X-coordinate.
			/// </summary>
			public uint wXmax;

			/// <summary>
			/// Minimum Y-coordinate.
			/// </summary>
			public uint wYmin;

			/// <summary>
			/// Maximum Y-coordinate.
			/// </summary>
			public uint wYmax;

			/// <summary>
			/// Minimum Z-coordinate.
			/// </summary>
			public uint wZmin;

			/// <summary>
			/// Maximum Z-coordinate.
			/// </summary>
			public uint wZmax;

			/// <summary>
			/// Number of joystick buttons.
			/// </summary>
			public uint wNumButtons;

			/// <summary>
			/// Smallest polling frequency supported when captured by the <see cref="joySetCapture"/> function.
			/// </summary>
			public uint wPeriodMin;

			/// <summary>
			/// Largest polling frequency supported when captured by <see cref="joySetCapture"/>.
			/// </summary>
			public uint wPeriodMax;

			/// <summary>
			/// Minimum rudder value. The rudder is a fourth axis of movement.
			/// </summary>
			public uint wRmin;

			/// <summary>
			/// Maximum rudder value. The rudder is a fourth axis of movement.
			/// </summary>
			public uint wRmax;

			/// <summary>
			/// Minimum u-coordinate (fifth axis) values.
			/// </summary>
			public uint wUmin;

			/// <summary>
			/// Maximum u-coordinate (fifth axis) values.
			/// </summary>
			public uint wUmax;
			/// <summary>
			/// Minimum v-coordinate (sixth axis) values.
			/// </summary>
			public uint wVmin;

			/// <summary>
			/// Maximum v-coordinate (sixth axis) values.
			/// </summary>
			public uint wVmax;

			/// <summary>
			/// Joystick capabilities The following flags define individual capabilities that a joystick might have:
			/// </summary>
			/// <remarks>
			/// <see cref="JOYCAPS_HASZ"/> - Joystick has z-coordinate information.
			/// <see cref="JOYCAPS_HASR"/> - Joystick has rudder (fourth axis) information.
			/// <see cref="JOYCAPS_HASU"/> - Joystick has u-coordinate (fifth axis) information.
			/// <see cref="JOYCAPS_HASV"/> - Joystick has v-coordinate (sixth axis) information.
			/// <see cref="JOYCAPS_HASPOV"/> - Joystick has point-of-view information.
			/// <see cref="JOYCAPS_POV4DIR"/> - Joystick point-of-view supports discrete values (centered, forward, backward, left, and right).
			/// <see cref="JOYCAPS_POVCTS"/> - Joystick point-of-view supports continuous degree bearings.
			/// </remarks>
			public uint wCaps;

			/// <summary>
			/// Maximum number of axes supported by the joystick.
			/// </summary>
			public uint wMaxAxes;

			/// <summary>
			/// Number of axes currently in use by the joystick.
			/// </summary>
			public uint wNumAxes;

			/// <summary>
			/// Maximum number of buttons supported by the joystick.
			/// </summary>
			public uint wMaxButtons;

			/// <summary>
			/// Null-terminated string containing the registry key for the joystick.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string szRegKey;

			/// <summary>
			/// Null-terminated string identifying the joystick driver OEM.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szOEMVxD;
		}

		/// <summary>
		/// The JOYINFO structure contains information about the joystick position and button state.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct JOYINFO
		{
			/// <summary>
			/// Current X-coordinate.
			/// </summary>
			public uint wXpos;

			/// <summary>
			/// Current Y-coordinate.
			/// </summary>
			public uint wYpos;

			/// <summary>
			/// Current Z-coordinate.
			/// </summary>
			public uint wZpos;

			/// <summary>
			/// Current state of joystick buttons.
			/// </summary>
			/// <remarks>
			/// <para>According to one or more of the following values:</para>
			/// <para>
			/// <see cref="JOY_BUTTON1"/> - First joystick button is pressed.
			/// <see cref="JOY_BUTTON2"/> - Second joystick button is pressed.
			/// <see cref="JOY_BUTTON3"/> - Third joystick button is pressed.
			/// <see cref="JOY_BUTTON4"/> - Fourth joystick button is pressed.
			/// </para>
			/// </remarks>
			public uint wButtons;
		}

		/// <summary>
		/// The JOYINFOEX structure contains extended information about the joystick position, point-of-view position, and button state.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The value of the dwSize member is also used to identify the version number for the structure when it's passed to the <see cref="joyGetPosEx"/> function.
		/// </para>
		/// <para>
		/// Most devices with a point-of-view control have only five positions. When the JOY_RETURNPOV flag is set, these positions are reported by using the following constants:
		/// </para>
		/// <para>
		/// <see cref="JOY_POVBACKWARD"/> - Point-of-view hat is pressed backward. The value 18,000 represents an orientation of 180.00 degrees (to the rear).
		/// <see cref="JOY_POVCENTERED"/> - Point-of-view hat is in the neutral position. The value -1 means the point-of-view hat has no angle to report.
		/// <see cref="JOY_POVFORWARD"/> - Point-of-view hat is pressed forward. The value 0 represents an orientation of 0.00 degrees (straight ahead).
		/// <see cref="JOY_POVLEFT"/> - Point-of-view hat is being pressed to the left. The value 27,000 represents an orientation of 270.00 degrees (90.00 degrees to the left).
		/// <see cref="JOY_POVRIGHT"/> - Point-of-view hat is pressed to the right. The value 9,000 represents an orientation of 90.00 degrees (to the right).
		/// </para>
		/// <para>
		/// The default joystick driver currently supports these five discrete directions. If an application can accept only the defined point-of-view values, it must use the JOY_RETURNPOV flag. If an application can accept other degree readings, it should use the JOY_RETURNPOVCTS flag to obtain continuous data if it is available. The JOY_RETURNPOVCTS flag also supports the JOY_POV constants used with the JOY_RETURNPOV flag.
		/// </para>
		/// </remarks>
		/// <seealso cref="joyGetPosEx"/>
		[StructLayout(LayoutKind.Sequential)]
		public struct JOYINFOEX
		{
			/// <summary>
			/// Size, in bytes, of this structure.
			/// </summary>
			public uint dwSize;

			/// <summary>
			/// Flags indicating the valid information returned in this structure. Members that do not contain valid information are set to zero.
			/// </summary>
			/// <remarks>
			/// <para>
			/// <see cref="JOY_RETURNALL"/> - Equivalent to setting all of the JOY_RETURN bits except JOY_RETURNRAWDATA.
			/// <see cref="JOY_RETURNBUTTONS"/> - The dwButtons member contains valid information about the state of each joystick button.
			/// <see cref="JOY_RETURNCENTERED"/> - Centers the joystick neutral position to the middle value of each axis of movement.
			/// <see cref="JOY_RETURNPOV"/> - The dwPOV member contains valid information about the point-of-view control, expressed in discrete units.
			/// <see cref="JOY_RETURNPOVCTS"/> - The dwPOV member contains valid information about the point-of-view control expressed in continuous, one-hundredth degree units.
			/// <see cref="JOY_RETURNR"/> - The dwRpos member contains valid rudder pedal data. This information represents another (fourth) axis.
			/// <see cref="JOY_RETURNRAWDATA"/>	- Data stored in this structure is uncalibrated joystick readings.
			/// <see cref="JOY_RETURNU"/> - The dwUpos member contains valid data for a fifth axis of the joystick, if such an axis is available, or returns zero otherwise.
			/// <see cref="JOY_RETURNV"/> - The dwVpos member contains valid data for a sixth axis of the joystick, if such an axis is available, or returns zero otherwise.
			/// <see cref="JOY_RETURNX"/> - The dwXpos member contains valid data for the x-coordinate of the joystick.
			/// <see cref="JOY_RETURNY"/> - The dwYpos member contains valid data for the y-coordinate of the joystick.
			/// <see cref="JOY_RETURNZ"/> - The dwZpos member contains valid data for the z-coordinate of the joystick.
			/// <see cref="JOY_USEDEADZONE"/> - Expands the range for the neutral position of the joystick and calls this range the dead zone. The joystick driver returns a constant value for all positions in the dead zone.
			/// </para>
			/// <para>
			/// The following flags provide data to calibrate a joystick and are intended for custom calibration applications.
			/// </para>
			/// <para>
			/// <see cref="JOY_CAL_READ3"/> - Read the x-, y-, and z-coordinates and store the raw values in dwXpos, dwYpos, and dwZpos.
			/// <see cref="JOY_CAL_READ4"/> - Read the rudder information and the x-, y-, and z-coordinates and store the raw values in dwXpos, dwYpos, dwZpos, and dwRpos.
			/// <see cref="JOY_CAL_READ5"/> - Read the rudder information and the x-, y-, z-, and u-coordinates and store the raw values in dwXpos, dwYpos, dwZpos, dwRpos, and dwUpos.
			/// <see cref="JOY_CAL_READ6"/> - Read the raw v-axis data if a joystick mini driver is present that will provide the data. Returns zero otherwise.
			/// <see cref="JOY_CAL_READALWAYS"/> - Read the joystick port even if the driver does not detect a device.
			/// <see cref="JOY_CAL_READRONLY"/> - Read the rudder information if a joystick mini-driver is present that will provide the data and store the raw value in dwRpos. Return zero otherwise.
			/// <see cref="JOY_CAL_READXONLY"/> - Read the x-coordinate and store the raw (uncalibrated) value in dwXpos.
			/// <see cref="JOY_CAL_READXYONLY"/> - Reads the x- and y-coordinates and place the raw values in dwXpos and dwYpos.
			/// <see cref="JOY_CAL_READYONLY"/> - Reads the y-coordinate and store the raw value in dwYpos.
			/// <see cref="JOY_CAL_READZONLY"/> - Read the z-coordinate and store the raw value in dwZpos.
			/// <see cref="JOY_CAL_READUONLY"/> - Read the u-coordinate if a joystick mini-driver is present that will provide the data and store the raw value in dwUpos. Return zero otherwise.
			/// <see cref="JOY_CAL_READVONLY"/> - Read the v-coordinate if a joystick mini-driver is present that will provide the data and store the raw value in dwVpos. Return zero otherwise.
			/// </para>
			/// </remarks>
			public uint dwFlags;

			/// <summary>
			/// Current X-coordinate.
			/// </summary>
			public uint dwXpos;

			/// <summary>
			/// Current Y-coordinate.
			/// </summary>
			public uint dwYpos;

			/// <summary>
			/// Current Z-coordinate.
			/// </summary>
			public uint dwZpos;

			/// <summary>
			/// Current position of the rudder or fourth joystick axis.
			/// </summary>
			public uint dwRpos;

			/// <summary>
			/// Current fifth axis position.
			/// </summary>
			public uint dwUpos;

			/// <summary>
			/// Current sixth axis position.
			/// </summary>
			public uint dwVpos;

			/// <summary>
			/// Current state of the 32 joystick buttons. The value of this member can be set to any combination of JOY_BUTTONn flags, where n is a value in the range of 1 through 32 corresponding to the button that is pressed.
			/// </summary>
			public uint dwButtons;

			/// <summary>
			/// Current button number that is pressed.
			/// </summary>
			public uint dwButtonNumber;

			/// <summary>
			/// Current position of the point-of-view control. Values for this member are in the range 0 through 35,900. These values represent the angle, in degrees, of each view multiplied by 100.
			/// </summary>
			public uint dwPOV;

			/// <summary>
			/// Reserved; do not use.
			/// </summary>
			public uint dwReserved1;

			/// <summary>
			/// Reserved; do not use.
			/// </summary>
			public uint dwReserved2;
		}

		// --- Public Externs ---
		/// <summary>
		/// The <b>PlaySound</b> function plays a sound specified by the given filename,
		/// resource, or system event.  (A system event may be associated with a sound in the
		/// registry or in the WIN.INI file.)
		/// </summary>
		/// <param name="sound">
		/// <para>
		/// A string that specifies the sound to play.  If this parameter is NULL, any
		/// currently playing waveform sound is stopped.  To stop a non-waveform sound,
		/// specify <see cref="SND_PURGE" /> in the <i>soundFlags</i> parameter.
		/// </para>
		/// <para>
		/// Three flags in <i>soundFlags</i> (<see cref="SND_ALIAS" />,
		/// <see cref="SND_FILENAME" />, and <see cref="SND_RESOURCE" />) determine
		/// whether the name is interpreted as an alias for a system event, a filename, or
		/// a resource identifier.  If none of these flags are specified, <b>PlaySound</b>
		/// searches the registry or the WIN.INI file for an association with the
		/// specified sound name.  If an association is found, the sound event is played.
		/// If no association is found in the registry, the name is interpreted as a
		/// filename.
		/// </para>
		/// </param>
		/// <param name="mod">
		/// Handle to the executable file that contains the resource to be loaded.  This
		/// parameter must be NULL unless <see cref="SND_RESOURCE" /> is specified in
		/// <i>soundFlags</i>.
		/// </param>
		/// <param name="soundFlags">
		/// <para>
		/// Flags for playing the sound.  The following values are defined:
		/// </para>
		/// <para>
		/// <list type="table">
		/// <listheader>
		/// <term>Value</term>
		/// <description>Description</description>
		/// </listheader>
		/// <item>
		/// <term><see cref="SND_APPLICATION" /></term>
		/// <description>
		/// The sound is played using an application-specific association.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_ALIAS" /></term>
		/// <description>
		/// The <i>sound</i> parameter is a system-event alias in the registry
		/// or the WIN.INI file.  Do not use with either
		/// <see cref="SND_FILENAME" /> or <see cref="SND_RESOURCE" />.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_ALIAS_ID" /></term>
		/// <description>
		/// The <i>sound</i> parameter is a predefined sound identifier.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_ASYNC" /></term>
		/// <description>
		/// The sound is played asynchronously and <b>PlaySound</b> returns
		/// immediately after beginning the sound.  To terminate an
		/// asynchronously played waveform sound, call <b>PlaySound</b> with
		/// <i>sound</i> set to NULL.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_FILENAME" /></term>
		/// <description>
		/// The <i>sound</i> parameter is a filename.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_LOOP" /></term>
		/// <description>
		/// The sound plays repeatedly until <b>PlaySound</b> is called again
		/// with the <i>sound</i> parameter set to NULL.  You must also
		/// specify the <see cref="SND_ASYNC" /> flag to indicate an
		/// asynchronous sound event.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_MEMORY" /></term>
		/// <description>
		/// A sound event's file is loaded in RAM.  The parameter specified by
		/// <i>sound</i> must point to an image of a sound in memory.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_NODEFAULT" /></term>
		/// <description>
		/// No default sound event is used.  If the sound cannot be found,
		/// <b>PlaySound</b> returns silently without playing the default
		/// sound.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_NOSTOP" /></term>
		/// <description>
		/// <para>
		/// The specified sound event will yield to another sound event
		/// that is already playing.  If a sound cannot be played because
		/// the resource needed to generate that sound is busy playing
		/// another sound, the function immediately returns FALSE without
		/// playing the requested sound.
		/// </para>
		/// <para>
		/// If this flag is not specified, <b>PlaySound</b> attempts to
		/// stop the currently playing sound so that the device can be
		/// used to play the new sound.
		/// </para>
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_NOWAIT" /></term>
		/// <description>
		/// If the driver is busy, return immediately without playing the
		/// sound.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_PURGE" /></term>
		/// <description>
		/// <para>
		/// Sounds are to be stopped for the calling task.  If
		/// <i>sound</i> is not NULL, all instances of the specified sound
		/// are stopped.  If <i>sound</i> is NULL, all sounds that are
		/// playing on behalf of the calling task are stopped.
		/// </para>
		/// <para>
		/// You must also specify the instance handle to stop
		/// <see cref="SND_RESOURCE" /> events.
		/// </para>
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_RESOURCE" /></term>
		/// <description>
		/// The <i>sound</i> parameter is a resource identifier; <i>mod</i>
		/// must identify the instance that contains the resource.
		/// </description>
		/// </item>
		/// <item>
		/// <term><see cref="SND_SYNC" /></term>
		/// <description>
		/// Synchronous playback of a sound event.  <b>PlaySound</b> returns
		/// after the sound event completes.
		/// </description>
		/// </item>
		/// </list>
		/// </para>
		/// </param>
		/// <returns>
		/// Returns TRUE if successful or FALSE otherwise.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The sound specified by <i>sound</i> must fit into available physical memory
		/// and be playable by an installed waveform-audio device driver.
		/// <b>PlaySound</b> searches the following directories for sound files: the
		/// current directory; the Windows directory; the Windows system directory;
		/// directories listed in the PATH environment variable; and the list of
		/// directories mapped in a network.  For more information about the directory
		/// search order, see the documentation for the <b>OpenFile</b> function.
		/// </para>
		/// <para>
		/// If it cannot find the specified sound, <b>PlaySound</b> uses the default
		/// system event sound entry instead.  If the function can find neither the
		/// system default entry nor the default sound, it makes no sound and returns
		/// FALSE.
		/// </para>
		/// </remarks>
		// WINMMAPI BOOL WINAPI PlaySoundA(IN LPCSTR pszSound, IN HMODULE hmod, IN DWORD fdwSound);
		// WINMMAPI BOOL WINAPI PlaySoundW(IN LPCWSTR pszSound, IN HMODULE hmod, IN DWORD fdwSound);
		[DllImport(DLLName)]
		public static extern bool PlaySound(string sound, IntPtr mod, uint soundFlags);

		/// <summary>
		/// The <b>timeBeginPeriod</b> function sets the minimum timer resolution for an
		/// application or device driver.
		/// </summary>
		/// <param name="period">
		/// Minimum timer resolution, in milliseconds, for the application or device driver.
		/// </param>
		/// <returns>
		/// Returns <see cref="TIMERR_NOERROR" /> if successful or
		/// <see cref="TIMERR_NOCANDO" /> if the resolution specified in <i>period</i> is out
		/// of range.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Call this function immediately before using timer services, and call the
		/// <see cref="timeEndPeriod" /> function immediately after you are finished
		/// using the timer services.
		/// </para>
		/// <para>
		/// You must match each call to <b>timeBeginPeriod</b> with a call to
		/// <see cref="timeEndPeriod" />, specifying the same minimum resolution in both
		/// calls.  An application can make multiple <b>timeBeginPeriod</b> calls as long
		/// as each call is matched with a call to <see cref="timeEndPeriod" />.
		/// </para>
		/// </remarks>
		/// <seealso cref="timeEndPeriod" />
		// WINMMAPI MMRESULT WINAPI timeBeginPeriod(IN UINT uPeriod);
		[DllImport(DLLName)]
		public static extern uint timeBeginPeriod(uint period);

		/// <summary>
		/// The <b>timeEndPeriod</b> function clears a previously set minimum timer
		/// resolution.
		/// </summary>
		/// <param name="period">
		/// Minimum timer resolution specified in the previous call to the
		/// <see cref="timeBeginPeriod" /> function.
		/// </param>
		/// <returns>
		/// Returns <see cref="TIMERR_NOERROR" /> if successful or
		/// <see cref="TIMERR_NOCANDO" /> if the resolution specified in <i>period</i> is out
		/// of range
		/// </returns>
		/// <remarks>
		/// <para>
		/// Call this function immediately after you are finished using timer services.
		/// </para>
		/// <para>
		/// You must match each call to <see cref="timeBeginPeriod" /> with a call to
		/// <b>timeEndPeriod</b>, specifying the same minimum resolution in both calls.
		/// An application can make multiple <see cref="timeBeginPeriod" /> calls as long
		/// as each call is matched with a call to <b>timeEndPeriod</b>.
		/// </para>
		/// </remarks>
		/// <seealso cref="timeBeginPeriod" />
		// WINMMAPI MMRESULT WINAPI timeEndPeriod(IN UINT uPeriod)
		[DllImport(DLLName)]
		public static extern uint timeEndPeriod(uint period);

		/// <summary>
		/// The <b>timeGetTime</b> function retrieves the system time, in milliseconds.
		/// The system time is the time elapsed since Windows was started.
		/// </summary>
		/// <returns>
		/// Returns the system time, in milliseconds.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The only difference between this function and the <b>timeGetSystemTime</b>
		/// function is that <b>timeGetSystemTime</b> uses the <b>MMTIME</b> structure to
		/// return the system time.  The <b>timeGetTime</b> function has less overhead
		/// than <b>timeGetSystemTime</b>.
		/// </para>
		/// <para>
		/// Note that the value returned by the <b>timeGetTime</b> function is a DWORD
		/// value.  The return value wraps around to 0 every 2^32 milliseconds, which is
		/// about 49.71 days.  This can cause problems in code that directly uses the
		/// <b>timeGetTime</b> return value in computations, particularly where the value
		/// is used to control code execution.  You should always use the difference
		/// between two <b>timeGetTime</b> return values in computations.
		/// </para>
		/// <para>
		/// <b>Windows NT/2000:</b> The default precision of the <b>timeGetTime</b>
		/// function can be five milliseconds or more, depending on the machine.  You
		/// can use the <see cref="timeBeginPeriod" /> and <see cref="timeEndPeriod" />
		/// functions to increase the precision of <b>timeGetTime</b>.  If you do so, the
		/// minimum difference between successive values returned by <b>timeGetTime</b>
		/// can be as large as the minimum period value set using
		/// <see cref="timeBeginPeriod" /> and <see cref="timeEndPeriod" />.  Use the
		/// <see cref="WinKernel.QueryPerformanceCounter" /> and
		/// <see cref="WinKernel.QueryPerformanceFrequency" /> functions to measure short
		/// time intervals at a high resolution.
		/// </para>
		/// </remarks>
		/// <seealso cref="WinKernel.QueryPerformanceCounter" />
		/// <seealso cref="WinKernel.QueryPerformanceFrequency" />
		/// <seealso cref="timeBeginPeriod" />
		/// <seealso cref="timeEndPeriod" />
		// <seealso cref="MMTIME" />
		// <seealso cref="timeGetSystemTime" />
		// WINMMAPI DWORD WINAPI timeGetTime(void);
		[DllImport(DLLName)]
		public static extern uint timeGetTime();

		/// <summary>
		/// The joyConfigChanged function informs the joystick driver that the configuration has changed and should be reloaded from the registry.
		/// </summary>
		/// <param name="dwFlags">
		/// Reserved for future use. Must equal zero.
		/// </param>
		/// <returns>
		/// Returns JOYERR_NOERROR if successful. Returns JOYERR_PARMS if the parameter is non-zero.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This function causes a window message to be sent to all top-level windows. This message may be defined by applications that need to respond to changes in joystick calibration by using RegisterWindowMessage with the following message ID:
		/// </para>
		/// <code>
		/// #define JOY_CONFIGCHANGED_MSGSTRING     "MSJSTICK_VJOYD_MSGSTR"
		/// </code>
		/// </remarks>
		[DllImport(DLLName)]
		public static extern uint joyConfigChanged(uint dwFlags);

		/// <summary>
		/// The joyGetDevCaps function queries a joystick to determine its capabilities.
		/// </summary>
		/// <param name="uJoyID">
		/// Identifier of the joystick to be queried. Valid values for uJoyID range from -1 to 15. A value of -1 enables retrieval of the szRegKey member of the JOYCAPS structure whether a device is present or not. For Windows NT 4.0, valid values are limited to zero (JOYSTICKID1) and JOYSTICKID2.
		/// </param>
		/// <param name="pjc">
		/// Pointer to a <see cref="JOYCAPS"/> structure to contain the capabilities of the joystick.
		/// </param>
		/// <param name="cbjc"> 
		/// Size, in bytes, of the JOYCAPS structure.
		/// </param>
		/// <returns>
		/// <para>
		/// Returns JOYERR_NOERROR if successful or one of the following error values:
		/// </para>
		/// <para>
		/// <see cref="MMSYSERR_NODRIVER"/> - The joystick driver is not present. Windows NT/2000/XP: The specified joystick identifier is invalid.
		/// <see cref="MMSYSERR_INVALPARAM"/> - An invalid parameter was passed. Windows 95/98/Me: The specified joystick identifier is invalid.
		/// </para>
		/// </returns>
		/// <remarks>
		/// <para>
		/// Use the <see cref="joyGetNumDevs"/> function to determine the number of joystick devices supported by the driver.
		/// </para>
		/// </remarks>
		/// <seealso cref="JOYCAPS"/>
		/// <seealso cref="joyGetNumDevs"/>
		[DllImport(DLLName)]
		public static extern Int32 joyGetDevCaps(UIntPtr uJoyID, ref JOYCAPS pjc, uint cbjc);

		/// <summary>
		/// The joyGetNumDevs function queries the joystick driver for the number of joysticks it supports.
		/// </summary>
		/// <returns>
		/// The joyGetNumDevs function returns the number of joysticks supported by the current driver or zero if no driver is installed.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Use the <see cref="joyGetPos"/> function to determine whether a given joystick is physically attached to the system. If the specified joystick is not connected, joyGetPos returns a <see cref="JOYERR_UNPLUGGED"/> error value.
		/// </para>
		/// </remarks>
		[DllImport(DLLName)]
		public static extern uint joyGetNumDevs();

		/// <summary>
		/// The joyGetPos function queries a joystick for its position and button status.
		/// </summary>
		/// <param name="uJoyID">
		/// Identifier of the joystick to be queried. Valid values for uJoyID range from 0 to 15.
		/// </param>
		/// <param name="pji">
		/// Pointer to a <see cref="JOYINFO"/> structure that contains the position and button status of the joystick.
		/// </param>
		/// <returns>
		/// Returns <see cref="JOYERR_NOERROR"/> if successful or one of the following error values.
		/// <para>
		/// <see cref="MMSYSERR_NODRIVER"/> - The joystick driver is not present.
		/// <see cref="MMSYSERR_INVALPARAM"/> - An invalid parameter was passed.
		/// <see cref="JOYERR_UNPLUGGED"/> - The specified joystick is not connected to the system.
		/// </para>
		/// </returns>
		/// <remarks>
		/// For devices that have four to six axes of movement, a point-of-view control, or more than four buttons, use the <see cref="joyGetPosEx"/> function.
		/// </remarks>
		[DllImport(DLLName)]
		public static extern uint joyGetPos(uint uJoyID, ref JOYINFO pji);

		/// <summary>
		/// The joyGetPosEx function queries a joystick for its position and button status.
		/// </summary>
		/// <param name="uJoyID">
		/// Identifier of the joystick to be queried. Valid values for uJoyID range from 0 to 15.
		/// </param>
		/// <param name="pji">
		/// Pointer to a <see cref="JOYINFOEX"/> structure that contains extended position information and button status of the joystick. You must set the dwSize and dwFlags members or joyGetPosEx will fail. The information returned from joyGetPosEx depends on the flags you specify in dwFlags.
		/// </param>
		/// <returns>
		/// Returns JOYERR_NOERROR if successful or one of the following error values.
		/// <para>
		/// Returns JOYERR_NOERROR if successful or one of the following error values.
		/// </para>
		/// <para>
		/// <see cref="MMSYSERR_NODRIVER"/> - The joystick driver is not present.
		/// <see cref="MMSYSERR_INVALPARAM"/> - An invalid parameter was passed.
		/// <see cref="JOYERR_UNPLUGGED"/> - The specified joystick is not connected to the system.
		/// <see cref="JOYERR_PARMS"/> - The specified joystick identifier is invalid.
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function provides access to extended devices such as rudder pedals, point-of-view hats, devices with a large number of buttons, and coordinate systems using up to six axes. For joystick devices that use three axes or fewer and have fewer than four buttons, use the joyGetPos function.
		/// </remarks>
		[DllImport(DLLName)]
		public static extern uint joyGetPosEx(uint uJoyID, ref JOYINFOEX pji);

		/// <summary>
		/// The joyGetThreshold function queries a joystick for its current movement threshold.
		/// </summary>
		/// <param name="uJoyID">
		/// Identifier of the joystick. Valid values for uJoyID range from 0 to 15.
		/// </param>
		/// <param name="puThreshold">
		/// Pointer to a variable that contains the movement threshold value.
		/// </param>
		/// <returns>
		/// <para>
		/// Returns JOYERR_NOERROR if successful or one of the following error values.
		/// </para>
		/// <para>
		/// <see cref="MMSYSERR_NODRIVER"/> - The joystick driver is not present.
		/// <see cref="MMSYSERR_INVALPARAM"/> - An invalid parameter was passed.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The movement threshold is the distance the joystick must be moved before a joystick position-change message (<see cref="MM_JOY1MOVE"/>, <see cref="MM_JOY1ZMOVE"/>, <see cref="MM_JOY2MOVE"/>, or <see cref="MM_JOY2ZMOVE"/>) is sent to a window that has captured the device. The threshold is initially zero.
		/// </remarks>
		[DllImport(DLLName)]
		public static extern uint joyGetThreshold(uint uJoyID, ref uint puThreshold);

		/// <summary>
		/// The joyReleaseCapture function releases the specified captured joystick.
		/// </summary>
		/// <param name="uJoyID">
		/// Identifier of the joystick. Valid values for uJoyID range from 0 to 15.
		/// </param>
		/// <returns>
		/// <para>
		/// Returns <see cref="JOYERR_NOERROR"/> if successful or one of the following error values.
		/// </para>
		/// <para>
		/// <see cref="MMSYSERR_NODRIVER"/> - The joystick driver is not present.
		/// <see cref="MMSYSERR_INVALPARAM"/> - Windows 95/98/Me: The specified joystick device identifier uJoyID is invalid. Windows NT/2000/XP: The specified joystick identifier is valid, but the joystick has not been captured.
		/// <see cref="JOYERR_PARMS"/> - Windows NT/2000/XP: The specified joystick device identifier uJoyID is invalid.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Windows 95/98/Me: This method returns JOYERR_NOERROR when passed a valid joystick identifier that has not been captured.
		/// </remarks>
		[DllImport(DLLName)]
		public static extern uint joyReleaseCapture(uint uJoyID);

		/// <summary>
		/// The joySetCature function captures a joystick by causing its messages to be sent to the specified window.
		/// </summary>
		/// <param name="hwnd">
		/// Handle to the window to receive the joystick messages.
		/// </param>
		/// <param name="uJoyID">
		/// Identifier of the joystick. Valid values for uJoyID range from 0 to 15.
		/// </param>
		/// <param name="uPeriod">
		/// Polling frequency, in milliseconds.
		/// </param>
		/// <param name="fChanged">
		/// Change position flag. Specify TRUE for this parameter to send messages only when the position changes by a value greater than the joystick movement threshold. Otherwise, messages are sent at the polling frequency specified in uPeriod.
		/// </param>
		/// <returns>
		/// <para>
		/// Returns JOYERR_NOERROR if successful or one of the following error values.
		/// </para>
		/// <para>
		/// <see cref="MMSYSERR_NODRIVER"/> - The joystick driver is not present.
		/// <see cref="MMSYSERR_INVALPARAM"/> - Windows 95/98/Me: Invalid joystick ID or hwnd is NULL.
		/// <see cref="JOYERR_NOCANDO"/> - Cannot capture joystick input because a required service (such as a Windows timer) is unavailable.
		/// <see cref="JOYERR_UNPLUGGED"/> - The specified joystick is not connected to the system.
		/// <see cref="JOYERR_PARMS"/> - Windows NT/2000/XP: Invalid joystick ID or hwnd is NULL.
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function fails if the specified joystick is currently captured. Call the joyReleaseCapture function to release the captured joystick, or destroy the window to release the joystick automatically.
		/// </remarks>
		[DllImport(DLLName)]
		public static extern uint joySetCapture(IntPtr hwnd, uint uJoyID, uint uPeriod, bool fChanged);

		/// <summary>
		/// The joySetThreshold function sets the movement threshold of a joystick.
		/// </summary>
		/// <param name="uJoyID">
		/// Identifier of the joystick. Valid values for uJoyID range from 0 to 15.
		/// </param>
		/// <param name="uThreshold">
		/// New movement threshold.
		/// </param>
		/// <returns>
		/// <para>
		/// Returns JOYERR_NOERROR if successful or one of the following error values.
		/// </para>
		/// <para>
		/// <see cref="MMSYSERR_NODRIVER"/> - The joystick driver is not present.
		/// <see cref="JOYERR_PARMS"/> - The specified joystick device identifier uJoyID is invalid.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The movement threshold is the distance the joystick must be moved before a joystick position-change message (<see cref="MM_JOY1MOVE"/>, <see cref="MM_JOY1ZMOVE"/>, <see cref="MM_JOY2MOVE"/>, or <see cref="MM_JOY2ZMOVE"/>) is sent to a window that has captured the device. The threshold is initially zero.
		/// </remarks>
		[DllImport(DLLName)]
		public static extern uint joySetThreshold(uint uJoyID, uint uThreshold);
	}
}
