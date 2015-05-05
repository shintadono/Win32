using System;
using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Specifies an access mask defining all the generic access types to an object.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct GENERIC_MAPPING
	{
		/// <summary>
		/// Specifies an access mask defining read access to an object.
		/// </summary>
		public ACCESS_MASK GenericRead;

		/// <summary>
		/// Specifies an access mask defining write access to an object.
		/// </summary>
		public ACCESS_MASK GenericWrite;

		/// <summary>
		/// Specifies an access mask defining execute access to an object.
		/// </summary>
		public ACCESS_MASK GenericExecute;

		/// <summary>
		/// Specifies an access mask defining all possible types of access to an object.
		/// </summary>
		public ACCESS_MASK GenericAll;
	}
}
