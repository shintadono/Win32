using System;
using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Contains the security descriptor for an object and specifies whether the handle
	/// retrieved by specifying this structure is inheritable.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct SECURITY_ATTRIBUTES
	{
		/// <summary>
		/// The size, in bytes, of this structure. Set this value to the size of the
		/// <see cref="SECURITY_ATTRIBUTES"/> structure.
		/// </summary>
		public uint nLength;

		/// <summary>
		/// A pointer to a <b>SECURITY_DESCRIPTOR</b> structure that controls access
		/// to the object. Default security descriptor is null (IntPtr.Zero).
		/// </summary>
		public IntPtr lpSecurityDescriptor;

		/// <summary>
		/// A <b>bool</b> value that specifies whether the returned handle is
		/// inherited when a new process is created. If this member is <b>true</b>,
		/// the new process inherits the handle.
		/// </summary>
		public bool bInheritHandle;
	}
}
