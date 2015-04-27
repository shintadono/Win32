using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using HANDLE=System.IntPtr;
using HRAWINPUT=System.IntPtr;
using LRESULT=System.IntPtr;
using WPARAM=System.UIntPtr;

namespace Win32.RawInput
{
	/// <summary>
	/// Class for managing human interface devices.
	/// </summary>
	[SuppressUnmanagedCodeSecurity()]
	[CLSCompliant(false)]
	public class RawInput
	{
		const string DLLName="User32.dll";
		const string GetRawInputDeviceInfoW="GetRawInputDeviceInfoW";

		#region Functions
		/// <summary>
		/// Calls the default raw input procedure to provide default processing for any raw input messages that an application
		/// does not process. This function ensures that every message is processed. <b>DefRawInputProc</b> is called with the
		/// same parameters received by the window procedure.
		/// </summary>
		/// <param name="paRawInput">An array of pointer to <see cref="RAWINPUT"/> structures.</param>
		/// <param name="nInput">The number of <see cref="RAWINPUT"/> structures pointed to by <paramref name="paRawInput"/> array.</param>
		/// <param name="cbSizeHeader">The size, in bytes, of the <see cref="RAWINPUTHEADER"/> structure.</param>
		/// <returns>If successful, the function returns <b>S_OK</b> (IntPtr.Zero). Otherwise it returns an error value.</returns>
		[DllImport(DLLName)]
		public extern static LRESULT DefRawInputProc([In] IntPtr[] paRawInput, int nInput, uint cbSizeHeader);

		/// <summary>
		/// Performs a buffered read of the raw input data.
		/// </summary>
		/// <remarks>
		/// <para>Using <see cref="GetRawInputBuffer"/>, the raw input data is buffered in the array of
		/// <see cref="RAWINPUT"/> structures. For an unbuffered read, listen to
		/// <see cref="WM.INPUT">WM_INPUT</see> and use the message details to read the raw input data.
		/// </para>
		/// <para>The <see cref="NEXTRAWINPUTBLOCK"/> methode allows an application to traverse an array
		/// of <see cref="RAWINPUT"/> structures.</para>
		/// <para><b>Note:</b> To get the correct size of the raw input buffer, do not use 
		/// <paramref name="pcbSize"/>, use <paramref name="pcbSize"/>*8 instead.</para>
		/// </remarks>
		/// <param name="pData">A pointer to a buffer of <see cref="RAWINPUT"/> structures that contain the
		/// raw input data. If <b>null</b> (IntPtr.Zero), the minimum required buffer, in bytes, is returned
		/// in <paramref name="pcbSize"/>.</param>
		/// <param name="pcbSize">The size, in bytes, of a <see cref="RAWINPUT"/> structure.</param>
		/// <param name="cbSizeHeader">The size, in bytes, of the <see cref="RAWINPUTHEADER"/> structure.</param>
		/// <returns>
		/// <para>If <paramref name="pData"/> is <b>null</b> and the function is successful, the return value
		/// is zero (0). If <paramref name="pData"/> is not <b>null</b> and the function is successful, the return
		/// value is the number of <see cref="RAWINPUT"/> structures written to <paramref name="pData"/>.</para>
		/// <para>If an error occurs, the return value is <see cref="uint.MaxValue"/> (-1). Call
		/// <see cref="WinKernel.GetLastError"/> for the error code.</para>
		/// </returns>
		[DllImport(DLLName)]
		public extern static uint GetRawInputBuffer(IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

		/// <summary>
		/// Retrieves the raw input from the specified device.
		/// </summary>
		/// <remarks>
		/// <see cref="GetRawInputData"/> gets the raw input one <see cref="RAWINPUT"/> structure at a time.
		/// In contrast, <see cref="GetRawInputBuffer"/> gets an array of <see cref="RAWINPUT"/> structures.
		/// </remarks>
		/// <param name="hRawInput">A handle to the <see cref="RAWINPUT"/> structure. This comes from the
		/// <b>lParam</b> in <see cref="WM.INPUT">WM_INPUT</see>.</param>
		/// <param name="uiCommand">The command flag. See <see cref="RID"/> for more information.</param>
		/// <param name="pData">A pointer to the data that comes from the <see cref="RAWINPUT"/> structure.
		/// This depends on the value of <paramref name="uiCommand"/>. If pData is <b>null</b> (IntPtr.Zero),
		/// the required size of the buffer is returned in <paramref name="pcbSize"/>.</param>
		/// <param name="pcbSize">The size, in bytes, of the data in <paramref name="pData"/>.</param>
		/// <param name="cbSizeHeader">The size, in bytes, of the <see cref="RAWINPUTHEADER"/> structure.</param>
		/// <returns>
		/// <para>If <paramref name="pData"/> is <b>null</b> (IntPtr.Zero) and the function is successful,
		/// the return value is zero (0). If <paramref name="pData"/> is not <b>null</b> (IntPtr.Zero) and the
		/// function is successful, the return value is the number of bytes copied into pData.</para>
		/// <para>If there is an error, the return value is <see cref="uint.MaxValue"/> (-1).</para>
		/// </returns>
		[DllImport(DLLName)]
		public extern static uint GetRawInputData(HRAWINPUT hRawInput, RID uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

		/// <summary>
		/// Retrieves information about the raw input device.
		/// (Use only in environments that have <see cref="Marshal.SystemDefaultCharSize"/> == 2.)
		/// </summary>
		/// <param name="hDevice">A handle to the raw input device. This comes from the <b>lParam</b> of the
		/// <see cref="WM.INPUT">WM_INPUT</see> message, from the <see cref="RAWINPUTHEADER.hDevice">hDevice</see>
		/// member of <see cref="RAWINPUTHEADER"/>, or from <see cref="GetRawInputDeviceList"/>. It can also be
		/// <b>null</b> (IntPtr.Zero) if an application inserts input data, for example, by using <b>SendInput</b>.</param>
		/// <param name="uiCommand">Specifies what data will be returned in <paramref name="pData"/>. See
		/// <see cref="RIDI"/> for more information.</param>
		/// <param name="pData">A pointer to a buffer that contains the information specified by <paramref name="uiCommand"/>.
		/// If <paramref name="uiCommand"/> is <see cref="RIDI.DEVICEINFO"/>, set the <see cref="RID_DEVICE_INFO.cbSize">cbSize</see>
		/// member of <see cref="RID_DEVICE_INFO"/> to <b>sizeof(RID_DEVICE_INFO)</b> before calling <see cref="O:Win32.RawInput.RawInput.GetRawInputDeviceInfo"/>.</param>
		/// <param name="pcbSize">The size, in bytes or characters (if <paramref name="uiCommand"/> is <see cref="RIDI.DEVICENAME"/>),
		/// of the data in <paramref name="pData"/>.</param>
		/// <returns>
		/// <para>If successful, this function returns a non-negative number indicating the number of bytes or characters
		/// (if <paramref name="uiCommand"/> is <see cref="RIDI.DEVICENAME"/>) copied to <paramref name="pData"/>.</para>
		/// <para>If <paramref name="pData"/> is not large enough for the data, the function returns
		/// <see cref="uint.MaxValue"/> (-1). If <paramref name="pData"/> is <b>null</b> (IntPtr.Zero), the function
		/// returns a value of zero (0). In both of these cases, <paramref name="pcbSize"/> is set to the minimum size
		/// required for the <paramref name="pData"/> buffer.</para>
		/// <para>Call <see cref="WinKernel.GetLastError"/> to identify any other errors.</para>
		/// </returns>
		[DllImport(DLLName, EntryPoint=GetRawInputDeviceInfoW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public extern static uint GetRawInputDeviceInfo(HANDLE hDevice, RIDI uiCommand, IntPtr pData, ref uint pcbSize);

		/// <summary>
		/// Enumerates the raw input devices attached to the system.
		/// </summary>
		/// <remarks>
		/// <para>The devices returned from this function are the mouse, the keyboard, and other Human Interface Device (HID) devices.</para>
		/// <para>To get more detailed information about the attached devices, call <see cref="O:Win32.RawInput.RawInput.GetRawInputDeviceInfo"/> using
		/// the <see cref="RAWINPUTDEVICELIST.hDevice">hDevice</see> from <see cref="RAWINPUTDEVICELIST"/>.</para>
		/// </remarks>
		/// <param name="pRawInputDeviceList">An array of <see cref="RAWINPUTDEVICELIST"/> structures for the devices attached to
		/// the system. If <b>null</b>, the number of devices are returned in <paramref name="puiNumDevices"/>.</param>
		/// <param name="puiNumDevices">If <paramref name="pRawInputDeviceList"/> is <b>null</b>, the function
		/// populates this variable with the number of devices attached to the system; otherwise, this variable specifies
		/// the number of <see cref="RAWINPUTDEVICELIST"/> structures that can be contained in the buffer to which
		/// <paramref name="pRawInputDeviceList"/> points. If this value is less than the number of devices attached to the
		/// system, the function returns the actual number of devices in this variable and fails with
		/// <see cref="ERROR.INSUFFICIENT_BUFFER"/>.</param>
		/// <param name="cbSize">The size of a <see cref="RAWINPUTDEVICELIST"/> structure, in bytes.</param>
		/// <returns>
		/// <para>If the function is successful, the return value is the number of devices stored in the buffer pointed
		/// to by <paramref name="pRawInputDeviceList"/>.</para>
		/// <para>On any other error, the function returns <see cref="uint.MaxValue"/> (-1) and
		/// <see cref="WinKernel.GetLastError"/> returns the error indication.</para>
		/// </returns>
		[DllImport(DLLName)]
		public extern static uint GetRawInputDeviceList([Out, MarshalAs(UnmanagedType.LPArray)] RAWINPUTDEVICELIST[] pRawInputDeviceList, ref uint puiNumDevices, uint cbSize);

		/// <summary>
		/// Retrieves the information about the raw input devices for the current application.
		/// </summary>
		/// <remarks>
		/// To receive raw input from a device, an application must register it by using <see cref="RegisterRawInputDevices"/>.
		/// </remarks>
		/// <param name="pRawInputDevices">An array of <see cref="RAWINPUTDEVICE"/> structures for the application.</param>
		/// <param name="puiNumDevices">The number of <see cref="RAWINPUTDEVICE"/> structures in <paramref name="pRawInputDevices"/>.</param>
		/// <param name="cbSize">The size, in bytes, of a <see cref="RAWINPUTDEVICE"/> structure.</param>
		/// <returns>
		/// <para>If successful, the function returns a non-negative number that is the number of <see cref="RAWINPUTDEVICE"/>
		/// structures written to the buffer.</para>
		/// <para>If the <paramref name="pRawInputDevices"/> buffer is too small or <b>null</b> (IntPtr.Zero), the function sets
		/// the last error as <see cref="ERROR.INSUFFICIENT_BUFFER"/>, returns <see cref="uint.MaxValue"/> (-1), and sets
		/// <paramref name="puiNumDevices"/> to the required number of devices. If the function fails for any other reason, it
		/// returns <see cref="uint.MaxValue"/> (-1). For more details, call <see cref="WinKernel.GetLastError"/>.</para>
		/// </returns>
		[DllImport(DLLName)]
		public extern static uint GetRegisteredRawInputDevices([Out, MarshalAs(UnmanagedType.LPArray)] RAWINPUTDEVICE[] pRawInputDevices, ref uint puiNumDevices, uint cbSize);

		/// <summary>
		/// Registers the devices that supply the raw input data.
		/// </summary>
		/// <remarks>
		/// <para>To receive <see cref="WM.INPUT">WM_INPUT</see> messages, an application must first register the raw input
		/// devices using <see cref="RegisterRawInputDevices"/>. By default, an application does not receive raw input.</para>
		/// <para>To receive <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> messages, an application must
		/// specify the <see cref="RIDEV.DEVNOTIFY"/> flag for each device class that is specified by the
		/// <see cref="RAWINPUTDEVICE.usUsagePage">usUsagePage</see> and <see cref="RAWINPUTDEVICE.usUsage">usUsage</see>
		/// fields of the <see cref="RAWINPUTDEVICE"/> structure. By default, an application does not receive
		/// <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> notifications for raw input device arrival and removal.</para>
		/// <para>If a <see cref="RAWINPUTDEVICE"/> structure has the <see cref="RIDEV.REMOVE"/> flag set and the
		/// <see cref="RAWINPUTDEVICE.hwndTarget">hwndTarget</see> parameter is not set to <b>null</b> (IntPtr.Zero),
		/// then parameter validation will fail.</para>
		/// </remarks>
		/// <param name="pRawInputDevices">An array of <see cref="RAWINPUTDEVICE"/> structures that represent the
		/// devices that supply the raw input.</param>
		/// <param name="uiNumDevices">The number of <see cref="RAWINPUTDEVICE"/> structures pointed to by
		/// <paramref name="pRawInputDevices"/>.</param>
		/// <param name="cbSize">The size, in bytes, of a <see cref="RAWINPUTDEVICE"/> structure.</param>
		/// <returns><b>true</b> if the function succeeds; otherwise, <b>false</b>. If the function fails, call
		/// <see cref="WinKernel.GetLastError"/> for more information.</returns>
		[DllImport(DLLName)]
		public extern static bool RegisterRawInputDevices([In] RAWINPUTDEVICE[] pRawInputDevices, uint uiNumDevices, uint cbSize);
		#endregion

		#region Macros
		static IntPtr RAWINPUT_ALIGN(IntPtr x)
		{
			if(IntPtr.Size==sizeof(int))
			{
				uint s=(uint)IntPtr.Size-1;
				return (IntPtr)(((uint)x+s)&~s);
			}
			else
			{
				ulong s=(ulong)IntPtr.Size-1;
				return (IntPtr)(((ulong)x+s)&~s);
			}
		}

		/// <summary>
		/// Retrieves the location of the next structure in an array of <see cref="RAWINPUT"/> structures.
		/// </summary>
		/// <remarks>This macro is called repeatedly to traverse an array of <see cref="RAWINPUT"/> structures.</remarks>
		/// <param name="ptr">A pointer to a structure in an array of <see cref="RAWINPUT"/> structures.</param>
		/// <returns>The return value is a pointer to the next structure in the array of <see cref="RAWINPUT"/> structures.</returns>
		public static unsafe RAWINPUT* NEXTRAWINPUTBLOCK(RAWINPUT* ptr)
		{
			return (RAWINPUT*)RAWINPUT_ALIGN((IntPtr)ptr+(int)ptr->header.dwSize);
		}

		/// <summary>
		/// Use this methode to get the input code of a <see cref="WM.INPUT">WM_INPUT</see> message from wParam.
		/// </summary>
		/// <param name="wParam">The <b>wParam</b> of a <see cref="WM.INPUT">WM_INPUT</see> message.</param>
		/// <returns>The input code of a <see cref="WM.INPUT">WM_INPUT</see> message as <see cref="RIM"/>.</returns>
		public static RIM GET_RAWINPUT_CODE_WPARAM(WPARAM wParam) { return (RIM)((int)wParam&0xff); }

		/// <summary>
		/// Use this methode to get the input code of a <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> message from wParam.
		/// </summary>
		/// <param name="wParam">The <b>wParam</b> of a <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> message.</param>
		/// <returns>The input code of a <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> message as <see cref="GIDC"/>.</returns>
		public static GIDC GET_RAWINPUT_DEVICE_CHANGE_CODE_WPARAM(WPARAM wParam) { return (GIDC)((int)wParam&0xff); }
		#endregion

		#region Helper/Overloads
		[DllImport(DLLName, EntryPoint=GetRawInputDeviceInfoW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		extern static uint GetRawInputDeviceInfo(HANDLE hDevice, RIDI uiCommand, StringBuilder pData, ref uint pcbSize);

		[DllImport(DLLName, EntryPoint=GetRawInputDeviceInfoW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		extern static uint GetRawInputDeviceInfo(HANDLE hDevice, RIDI uiCommand, ref RID_DEVICE_INFO pData, ref uint pcbSize);

		[DllImport(DLLName, EntryPoint=GetRawInputDeviceInfoW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		extern static uint GetRawInputDeviceInfo(HANDLE hDevice, RIDI uiCommand, byte[] pData, ref uint pcbSize);

		[DllImport(DLLName, EntryPoint="RegisterRawInputDevices")]
		extern static bool RegisterRawInputDevice([In] ref RAWINPUTDEVICE pRawInputDevice, uint uiNumDevices, uint cbSize);

		/// <summary>
		/// Retrieves the device name of a raw input device.
		/// </summary>
		/// <param name="hDevice">A handle to the raw input device. This comes from the <b>lParam</b> of the
		/// <see cref="WM.INPUT">WM_INPUT</see> message, from the <see cref="RAWINPUTHEADER.hDevice">hDevice</see>
		/// member of <see cref="RAWINPUTHEADER"/>, or from <see cref="GetRawInputDeviceList"/>. It can also be
		/// <b>null</b> (IntPtr.Zero) if an application inserts input data, for example, by using <b>SendInput</b>.</param>
		/// <returns>The device name of the raw input device.</returns>
		public static string GetRawInputDeviceName(HANDLE hDevice)
		{
			uint size=0;
			uint err=GetRawInputDeviceInfo(hDevice, RIDI.DEVICENAME, IntPtr.Zero, ref size);
			if(err==uint.MaxValue) throw new Exception(string.Format("Error determining device name (length). (Error code: 0x{0:X8})", WinKernel.GetLastError()));

			size=Math.Max(err, size)+1;

			StringBuilder tmp=new StringBuilder((int)size);
			err=GetRawInputDeviceInfo(hDevice, RIDI.DEVICENAME, tmp, ref size);
			if(err==uint.MaxValue) throw new Exception(string.Format("Error determining device name. (Error code: 0x{0:X8})", WinKernel.GetLastError()));

			return tmp.ToString();
		}

		/// <summary>
		/// Retrieves information about the raw input device.
		/// </summary>
		/// <param name="hDevice">A handle to the raw input device. This comes from the <b>lParam</b> of the
		/// <see cref="WM.INPUT">WM_INPUT</see> message, from the <see cref="RAWINPUTHEADER.hDevice">hDevice</see>
		/// member of <see cref="RAWINPUTHEADER"/>, or from <see cref="GetRawInputDeviceList"/>. It can also be
		/// <b>null</b> (IntPtr.Zero) if an application inserts input data, for example, by using <b>SendInput</b>.</param>
		/// <returns>The information about the raw input device.</returns>
		public static RID_DEVICE_INFO GetRawInputDeviceInfo(HANDLE hDevice)
		{
			uint size=(uint)Marshal.SizeOf(typeof(RID_DEVICE_INFO));

			RID_DEVICE_INFO ret=new RID_DEVICE_INFO();
			ret.cbSize=size;

			uint err=GetRawInputDeviceInfo(hDevice, RIDI.DEVICEINFO, ref ret, ref size);
			if(err==uint.MaxValue) throw new Exception(string.Format("Error determining device information. (Error code: 0x{0:X8})", WinKernel.GetLastError()));

			return ret;
		}

		/// <summary>
		/// Retrieves the preparsed data of a raw input device.
		/// </summary>
		/// <param name="hDevice">A handle to the raw input device. This comes from the <b>lParam</b> of the
		/// <see cref="WM.INPUT">WM_INPUT</see> message, from the <see cref="RAWINPUTHEADER.hDevice">hDevice</see>
		/// member of <see cref="RAWINPUTHEADER"/>, or from <see cref="GetRawInputDeviceList"/>. It can also be
		/// <b>null</b> (IntPtr.Zero) if an application inserts input data, for example, by using <b>SendInput</b>.</param>
		/// <returns>The preparsed data of raw input device.</returns>
		public static byte[] GetRawInputDevicePreparsedData(HANDLE hDevice)
		{
			uint size=0;
			uint err=GetRawInputDeviceInfo(hDevice, RIDI.PREPARSEDDATA, IntPtr.Zero, ref size);
			if(err==uint.MaxValue) throw new Exception(string.Format("Error determining preparsed data of device (length). (Error code: 0x{0:X8})", WinKernel.GetLastError()));

			byte[] ret=new byte[size];

			err=GetRawInputDeviceInfo(hDevice, RIDI.PREPARSEDDATA, ret, ref size);
			if(err==uint.MaxValue) throw new Exception(string.Format("Error determining preparsed data of device. (Error code: 0x{0:X8})", WinKernel.GetLastError()));

			return ret;
		}

		/// <summary>
		/// Returns a list of raw input device handles and raw input device types.
		/// </summary>
		/// <returns>The list of raw input device handles and raw input device types.</returns>
		public static List<Tuple<HANDLE, RIM_TYPE>> EnumerateDevices()
		{
			uint size=(uint)Marshal.SizeOf(typeof(RAWINPUTDEVICELIST));

			uint deviceCount=0;

			uint err=GetRawInputDeviceList(null, ref deviceCount, size);
			if(err==uint.MaxValue) throw new Exception(string.Format("Error enumerating raw input devices. (Error code: 0x{0:X8})", WinKernel.GetLastError()));

			if(deviceCount==0) return new List<Tuple<LRESULT, RIM_TYPE>>();

			RAWINPUTDEVICELIST[] tmp=new RAWINPUTDEVICELIST[deviceCount+16]; // Just a few more, for the case they just got attached.
			err=GetRawInputDeviceList(tmp, ref deviceCount, size);
			if(err==uint.MaxValue) throw new Exception(string.Format("Error enumerating raw input devices. (Error code: 0x{0:X8})", WinKernel.GetLastError()));

			List<Tuple<LRESULT, RIM_TYPE>> ret=new List<Tuple<LRESULT, RIM_TYPE>>();
			for(int i=0; i<deviceCount; i++) ret.Add(new Tuple<LRESULT, RIM_TYPE>(tmp[i].hDevice, tmp[i].dwType));

			return ret;
		}

		/// <summary>
		/// Registers the devices that supply the raw input data.
		/// </summary>
		/// <remarks>
		/// <para>To receive <see cref="WM.INPUT">WM_INPUT</see> messages, an application must first register the raw input
		/// devices using <see cref="RegisterRawInputDevices"/>. By default, an application does not receive raw input.</para>
		/// <para>To receive <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> messages, an application must
		/// specify the <see cref="RIDEV.DEVNOTIFY"/> flag for each device class that is specified by the
		/// <see cref="RAWINPUTDEVICE.usUsagePage">usUsagePage</see> and <see cref="RAWINPUTDEVICE.usUsage">usUsage</see>
		/// fields of the <see cref="RAWINPUTDEVICE"/> structure. By default, an application does not receive
		/// <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see> notifications for raw input device arrival and removal.</para>
		/// <para>If a <see cref="RAWINPUTDEVICE"/> structure has the <see cref="RIDEV.REMOVE"/> flag set and the
		/// <see cref="RAWINPUTDEVICE.hwndTarget">hwndTarget</see> parameter is not set to <b>null</b> (IntPtr.Zero),
		/// then parameter validation will fail.</para>
		/// </remarks>
		/// <param name="pRawInputDevice">A <see cref="RAWINPUTDEVICE"/> structure that represent the
		/// devices that supply the raw input.</param>
		/// <returns><b>true</b> if the function succeeds; otherwise, <b>false</b>. If the function fails, call
		/// <see cref="WinKernel.GetLastError"/> for more information.</returns>
		public static bool RegisterRawInputDevice(RAWINPUTDEVICE pRawInputDevice)
		{
			return RegisterRawInputDevice(ref pRawInputDevice, 1, (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICE)));
		}

		[DllImport(DLLName, EntryPoint="GetRawInputData")]
		extern static uint GetRawInputDataH(HRAWINPUT hRawInput, RID uiCommand, ref RAWINPUTHEADER pData, ref uint pcbSize, uint cbSizeHeader);

		/// <summary>
		/// Retrieves the raw input header from the specified device.
		/// </summary>
		/// <remarks>See <see cref="GetRawInputData"/> for more information.</remarks>
		/// <param name="hRawInput">A handle to the <see cref="RAWINPUT"/> structure. This comes from the
		/// <b>lParam</b> in <see cref="WM.INPUT">WM_INPUT</see>.</param>
		/// <returns>The raw input header as <see cref="RAWINPUTHEADER"/>.</returns>
		public static RAWINPUTHEADER GetRawInputDataHeader(HRAWINPUT hRawInput)
		{
			uint size=RAWINPUTHEADER.SIZE;

			RAWINPUTHEADER ret=new RAWINPUTHEADER();
			ret.dwSize=size;

			uint err=GetRawInputDataH(hRawInput, RID.HEADER, ref ret, ref size, RAWINPUTHEADER.SIZE);
			if(err==uint.MaxValue) throw new Exception(string.Format("Error getting header of WM_INPUT data. (Error code: 0x{0:X8})", WinKernel.GetLastError()));

			return ret;
		}

		/// <summary>
		/// Retrieves the raw input data from the specified device.
		/// </summary>
		/// <remarks>See <see cref="GetRawInputData"/> for more information.</remarks>
		/// <typeparam name="T">A <b>struct</b> that will be the type of the returned data.</typeparam>
		/// <param name="hRawInput">A handle to the <see cref="RAWINPUT"/> structure. This comes from the
		/// <b>lParam</b> in <see cref="WM.INPUT">WM_INPUT</see>.</param>
		/// <param name="size">Size of the <see cref="RAWINPUT"/> structure. Can be queried using
		/// <see cref="GetRawInputDataHeader"/>; the size is stored in <see cref="RAWINPUTHEADER.dwSize"/>.</param>
		/// <param name="offset">An offset to the start of the data, to be returned, in the resulting data of a
		/// <see cref="GetRawInputData"/> call, without the <see cref="RAWINPUTHEADER"/>, which is omitted anyway.</param>
		/// <returns>The raw input header as specified when called.</returns>
		public unsafe static T GetRawInputData<T>(HRAWINPUT hRawInput, int size, int offset=0) where T : struct
		{
			if(size<(uint)Marshal.SizeOf(typeof(T))) throw new ArgumentOutOfRangeException("size", "Must be greater than or equal to sizeof(RAWINPUT).");

			IntPtr buffer=Marshal.AllocHGlobal(size);
			uint dwSize=(uint)size;

			try
			{
				uint err=GetRawInputData(hRawInput, RID.INPUT, buffer, ref dwSize, RAWINPUTHEADER.SIZE);
				if(err==uint.MaxValue) throw new Exception(string.Format("Error getting WM_INPUT data. (Error code: 0x{0:X8})", WinKernel.GetLastError()));

				return (T)Marshal.PtrToStructure(buffer+(int)RAWINPUTHEADER.SIZE+offset, typeof(T));
			}
			finally
			{
				Marshal.FreeHGlobal(buffer);
			}
		}
		#endregion
	}
}
