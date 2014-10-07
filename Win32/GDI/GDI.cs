using System.Runtime.InteropServices;
using System.Security;
using HANDLE=System.IntPtr;
using HDC=System.IntPtr;

namespace Win32
{
	/// <summary>
	/// Native GDI calls.
	/// </summary>
	[SuppressUnmanagedCodeSecurity()]
	public static class GDI
	{
		const string DLLName="GDI32.dll";

		/// <summary>
		/// Selects an object into the specified device context. The new object replaces the previous object of the same type.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="hgdiobj">The handle to the object to be selected.</param>
		/// <returns>If the selected object is not a region and the function succeeds, the return value is a handle to the object being replaced. Otherwise <b>HGDI_ERROR</b> (-1) is returned.</returns>
		[DllImport(DLLName)]
		public static extern HANDLE SelectObject(HDC hdc, HANDLE hgdiobj);

		/// <summary>
		/// Deletes on object.
		/// </summary>
		/// <param name="hObject">The handle to the object to be deleted.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b> is returned.</returns>
		[DllImport(DLLName)]
		public static extern bool DeleteObject(HANDLE hObject);

		/// <summary>
		/// Retrieves a handle to one of the stock pens, brushes, fonts, or palettes.
		/// </summary>
		/// <param name="fnObject">The type of the stock object.</param>
		/// <returns>The handle to the requested object.</returns>
		[DllImport(DLLName)]
		public static extern HANDLE GetStockObject(StockObjectType fnObject);
	}
}
