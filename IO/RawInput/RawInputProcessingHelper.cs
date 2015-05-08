using System;
using System.Collections.Generic;
using System.Threading;
using HANDLE=System.IntPtr;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Helps to determine the device handler for incomming <see cref="WM.INPUT">WM_INPUT</see> messages.
	/// </summary>
	/// <remarks>
	/// The following code shows a simple usage of two devices. Creates an instance of <see cref="RawInputProcessingHelper{T}"/>,
	/// adds handler, updates the devices lists by timer and handles incoming <see cref="WM.INPUT">WM_INPUT</see> message by
	/// overloading <c>WndProc</c> method.
	/// <code>
	/// public partial class MyForm : Form
	/// {
	/// 	enum MyDevices
	/// 	{
	/// 		None=0,
	/// 		SpaceMouse=1,
	/// 		SoftMouse3D=2,
	/// 	}
	/// 
	/// 	const uint VendorID_Logitech=0x046d; // SpaceMouses, SpaceNavigators, etc.
	/// 	const uint VendorID_GGS=0x241f; // Softmouse 3D
	/// 
	/// 	RawInputProcessingHelper&lt;MyDevices&gt; rawInputProcessingHelper=new RawInputProcessingHelper&lt;MyDevices&gt;();
	/// 
	/// 	public MyForm()
	/// 	{
	/// 		InitializeComponent();
	/// 
	/// 		// Add handler to processing helper
	/// 		rawInputProcessingHelper.AddHandler(MyDevices.SpaceMouse, (info) =&gt; { return info.dwType==RIM_TYPE.HID&amp;&amp;info.hid.usUsage==HID_USAGE_GENERIC_DESKTOP.MULTIAXIS_CONTROLLER&amp;&amp;info.hid.usUsagePage==HID_USAGE_PAGE.GENERIC_DESKTOP&amp;&amp;info.hid.dwVendorId==VendorID_Logitech; });
	/// 		rawInputProcessingHelper.AddHandler(MyDevices.SoftMouse3D, (info) =&gt; { return info.dwType==RIM_TYPE.HID&amp;&amp;info.hid.usUsage==HID_USAGE_GENERIC_DESKTOP.JOYSTICK&amp;&amp;info.hid.usUsagePage==HID_USAGE_PAGE.GENERIC_DESKTOP&amp;&amp;info.hid.dwVendorId==VendorID_GGS; });
	/// 
	/// 		// Inital update of devices
	/// 		rawInputProcessingHelper.UpdateDevices();
	/// 
	///			// Register the supported devices
	/// 		bool err;
	/// 		err=RawInput.RegisterRawInputDevice(RIDEV.NONE, HID_USAGE_PAGE.GENERIC_DESKTOP, HID_USAGE_GENERIC_DESKTOP.MULTIAXIS_CONTROLLER); // SpaceMouse
	/// 		err=RawInput.RegisterRawInputDevice(RIDEV.NONE, HID_USAGE_PAGE.GENERIC_DESKTOP, HID_USAGE_GENERIC_DESKTOP.JOYSTICK); // SoftMouse3D
	/// 	}
	/// 
	/// 	[PermissionSet(SecurityAction.Demand, Name="FullTrust")]
	/// 	protected override void WndProc(ref Message m)
	/// 	{
	/// 		if(m.Msg==WM.INPUT)
	/// 		{
	/// 			uint size;
	/// 			switch(rawInputProcessingHelper.GetHandlerFromWmInput(m.LParam, out size))
	/// 			{
	/// 				case MyDevices.SpaceMouse: ProcessInputSpaceMouse(m, size); break;
	/// 				case MyDevices.SoftMouse3D: ProcessInputSoftMouse3D(m, size); break;
	/// 				default: break;
	/// 			}
	/// 		}
	/// 
	/// 		base.WndProc(ref m);
	/// 	}
	/// 
	/// 	// Use a timer to update the devices.
	/// 	private void timerUpdateDevices_Tick(object sender, EventArgs e)
	/// 	{
	/// 		rawInputProcessingHelper.UpdateDevices();
	/// 	}
	/// }
	/// </code>
	/// </remarks>
	public class RawInputProcessingHelper<T>
	{
		// To become thread safe, and to remain fast while updating the list of devices, we keep two lists, that will be swap, if necessary.
		Dictionary<HANDLE, T> front=new Dictionary<HANDLE, T>();
		Dictionary<HANDLE, T> back=new Dictionary<HANDLE, T>();

		Dictionary<T, Func<RID_DEVICE_INFO, bool>> handler=new Dictionary<T, Func<RID_DEVICE_INFO, bool>>();

		/// <summary>
		/// Adds a new handler for input devices detection.
		/// </summary>
		/// <param name="id">An instance of the identifier.</param>
		/// <param name="func">A function to determine, if the device can be handled by the entity represented by <paramref name="id"/>.</param>
		/// <returns><b>true</b> if the handler is replaced; otherwise, <b>false</b>.</returns>
		public bool AddHandler(T id, Func<RID_DEVICE_INFO, bool> func)
		{
			if(func==null) throw new ArgumentNullException("func");

			lock(handler)
			{
				bool ret=handler.ContainsKey(id);
				handler[id]=func;
				return ret;
			}
		}

		/// <summary>
		/// Removes a handler for input devices detection.
		/// </summary>
		/// <param name="id">An instance of the identifier.</param>
		/// <returns><b>true</b> if the handler is successfully found and removed; otherwise, <b>false</b>.
		/// This method returns <b>false</b> if <paramref name="id"/> is not found.</returns>
		public bool RemoveHandler(T id)
		{
			lock(handler)
			{
				return handler.Remove(id);
			}
		}

		/// <summary>
		/// Identifies the handler for a device.
		/// </summary>
		/// <param name="lParam">The handle to a raw input dataset.</param>
		/// <returns>The id of the handler.</returns>
		public T GetHandlerFromWmInput(IntPtr lParam)
		{
			RAWINPUTHEADER rih=RawInput.GetRawInputDataHeader(lParam);

			T ret;
			if(!front.TryGetValue(rih.hDevice, out ret)) return default(T);

			return ret;
		}

		/// <summary>
		/// Identifies the handler for a device.
		/// </summary>
		/// <param name="lParam">The handle to a raw input dataset.</param>
		/// <param name="rih">Returns the <see cref="RAWINPUTHEADER"/> of the raw input dataset.</param>
		/// <returns>The id of the handler.</returns>
		public T GetHandlerFromWmInput(IntPtr lParam, out RAWINPUTHEADER rih)
		{
			rih=RawInput.GetRawInputDataHeader(lParam);

			T ret;
			if(!front.TryGetValue(rih.hDevice, out ret)) return default(T);

			return ret;
		}

		/// <summary>
		/// Identifies the handler for a device.
		/// </summary>
		/// <param name="lParam">The handle to a raw input dataset.</param>
		/// <param name="size">Returns the size of the raw input dataset.</param>
		/// <returns>The id of the handler.</returns>
		public T GetHandlerFromWmInput(IntPtr lParam, out uint size)
		{
			RAWINPUTHEADER rih=RawInput.GetRawInputDataHeader(lParam);
			size=rih.dwSize;

			T ret;
			if(!front.TryGetValue(rih.hDevice, out ret)) return default(T);

			return ret;
		}

		/// <summary>
		/// Identifies the handler for a device.
		/// </summary>
		/// <param name="device">The handle to the device.</param>
		/// <returns>The id of the handler.</returns>
		public T GetHandler(HANDLE device)
		{
			T ret;
			if(!front.TryGetValue(device, out ret)) return default(T);

			return ret;
		}

		/// <summary>
		/// Enumerate devices and determines the handlers/ids.
		/// </summary>
		/// <remarks>To avoid conflicks between threads accessing the object, this method
		/// should only be call from one thread, maybe in regular intervals (not to short
		/// ones; maybe every 10 sec).
		/// </remarks>
		/// <returns>The number of handled devices.</returns>
		public int UpdateDevices()
		{
			var allDevices=RawInput.EnumerateDevices();

			// Remove old entries
			back.Clear();

			// If we find a change, we will swap front and back.
			bool foundNew=false;

			// Lock changes to the handlers, while inspecting the devices.
			lock(handler)
			{
				foreach(var device in allDevices)
				{
					// Query device info.
					var deviceInfo=RawInput.GetRawInputDeviceInfo(device.Item1);

					// If device was known, test it's old handler first.
					if(front.ContainsKey(device.Item1))
					{
						T id=front[device.Item1];
						if(handler.ContainsKey(id)&&handler[id](deviceInfo))
						{
							back.Add(device.Item1, id);
							continue;
						}
					}

					// Find the handler
					foreach(var idHandler in handler)
					{
						if(idHandler.Value(deviceInfo))
						{
							back.Add(device.Item1, idHandler.Key);
							foundNew=true;
							break;
						}
					}
				}
			}

			// If something changed, swap the dictionaries.
			if(foundNew||back.Count!=front.Count) back=Interlocked.Exchange(ref front, back);

			return front.Count;
		}
	}
}
