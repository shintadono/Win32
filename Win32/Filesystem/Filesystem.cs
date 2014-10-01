using System;
using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Class for file system operations.
	/// </summary>
	public static class Filesystem
	{
		const string DLLName="Kernel32.dll";
		const string CreateHardLinkW="CreateHardLinkW";

		/// <summary>
		/// Creates a hard link between an existing file and a new file.
		/// </summary>
		/// <param name="lpFileName">The name of the new file.</param>
		/// <param name="lpExistingFileName">The name of the existing file.</param>
		/// <param name="p">Reserved; must be <b>0</b> (zero).</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint=CreateHardLinkW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern bool CreateHardLink(string lpFileName, string lpExistingFileName, IntPtr p);

		/// <summary>
		/// Creates a hard link between an existing file and a new file.
		/// </summary>
		/// <param name="newFileName">The name of the new file.</param>
		/// <param name="existingFileName">The name of the existing file.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool CreateHardLink(string newFileName, string existingFileName)
		{
			return CreateHardLink(newFileName, existingFileName, IntPtr.Zero);
		}
	}
}
