using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace Win32
{
	/// <summary>
	/// Class for file operations.
	/// </summary>
	[SuppressUnmanagedCodeSecurity()]
	public static class FileOperations
	{
		const string DLLName="Kernel32.dll";
		const string CreateFileW="CreateFileW";

		/// <summary>
		/// Is returns by some file operations, denoting an error has occurred.
		/// </summary>
		public static readonly IntPtr INVALID_HANDLE_VALUE=(IntPtr)(-1);

		/// <summary>
		/// If <see cref="O:SetFilePointer"/> returns this value and <see cref="WinKernel.GetLastError"/>
		/// returns NO_ERROR (0), it is the position of the file pointer, and not an error.
		/// </summary>
		public const uint INVALID_SET_FILE_POINTER=0xFFFFFFFF;

		/// <summary>
		/// If <see cref="O:GetFileSize"/> returns this value and <see cref="WinKernel.GetLastError"/>
		/// returns NO_ERROR (0), it is the position of the file pointer, and not an error.
		/// </summary>
		public const uint INVALID_FILE_SIZE=0xFFFFFFFF;

		#region CreateFile
		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);
		
		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);
		
		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A pointer to a <see cref="SECURITY_ATTRIBUTES"/> structure. Can be null (IntPtr.Zero).</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_ATTRIBUTE dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FILE_FLAG dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, SECURITY dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, FileFlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FileAccess dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, FILE_GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, GENERIC dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, STANDARD_RIGHTS dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, ACCESS_MASK dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		/// <summary>
		/// Creates or opens a file and I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened.</param>
		/// <param name="dwDesiredAccess">The requested access to the file or device.</param>
		/// <param name="dwShareMode">The requested sharing mode of the file or device.</param>
		/// <param name="lpSecurityAttributes">A <see cref="SECURITY_ATTRIBUTES"/> structure.</param>
		/// <param name="dwCreationDisposition">An action to take on a file or device that exists or does not exist.</param>
		/// <param name="dwFlagsAndAttributes">The file or device attributes and flags.</param>
		/// <param name="hTemplateFile">A valid handle to a template file with the <see cref="GENERIC.READ"/> access right. Can be null (IntPtr.Zero).</param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified file or device. If the function fails,
		/// the return value is <see cref="INVALID_HANDLE_VALUE"/>. To get extended error information, call <see cref="WinKernel.GetLastError"/>.</returns>
		[DllImport(DLLName, EntryPoint=CreateFileW, ExactSpelling=true, CharSet=CharSet.Unicode)]
		public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);
		#endregion

		/// <summary>
		/// Closes an file or I/O device.
		/// </summary>
		/// <param name="hFile">The handle to the file or device.</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool CloseHandle(IntPtr hFile);

		#region GetFileSize/Ex
		/// <summary>
		/// Retrieves the size of the specified file, in bytes.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="lpFileSizeHigh">A pointer to a <b>uint</b> variable to receive the high order 32
		/// bits of the file size. If the parameter is null (IntPtr.Zero) no high order bits are returned.</param>
		/// <returns>If the function succeeds, the return value is the low-order 32 bit of the file size;
		/// otherwise <see cref="INVALID_FILE_SIZE"/> is returned.</returns>
		[DllImport(DLLName)]
		public static extern uint GetFileSize(IntPtr hFile, IntPtr lpFileSizeHigh);

		/// <summary>
		/// Retrieves the size of the specified file, in bytes.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="lpFileSizeHigh">Receive the high order 32 bits of the file size.</param>
		/// <returns>If the function succeeds, the return value is the low-order 32 bit of the file size;
		/// otherwise <see cref="INVALID_FILE_SIZE"/> is returned.</returns>
		[DllImport(DLLName)]
		public static extern uint GetFileSize(IntPtr hFile, out uint lpFileSizeHigh);

		/// <summary>
		/// Retrieves the size of the specified file, in bytes.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="lpFileSize">Receive the file size.</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool GetFileSizeEx(IntPtr hFile, out long lpFileSize);
		#endregion

		#region ReadFile
		/// <summary>
		/// Reads data from the specified file or I/O device.
		/// </summary>
		/// <param name="hFile">A handle to the file or device.</param>
		/// <param name="lpBuffer">The buffer that receives the data read.</param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <param name="lpNumberOfBytesRead">A pointer to a <b>uint</b> to receives the number
		/// of bytes written when using a synchronous <paramref name="hFile"/> parameter.
		/// Can be null (IntPtr.Zero), if <paramref name="lpOverlapped"/> is not null (IntPtr.Zero).</param>
		/// <param name="lpOverlapped">A pointer to a <see cref="NativeOverlapped"/> structure.
		/// Can be null (IntPtr.Zero).</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, IntPtr lpNumberOfBytesRead, IntPtr lpOverlapped);

		/// <summary>
		/// Reads data from the specified file or I/O device.
		/// </summary>
		/// <param name="hFile">A handle to the file or device.</param>
		/// <param name="lpBuffer">The buffer that receives the data read.</param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <param name="lpNumberOfBytesRead">Receives the number of bytes read when using
		/// a synchronous <paramref name="hFile"/> parameter.</param>
		/// <param name="lpOverlapped">A pointer to a <see cref="NativeOverlapped"/> structure.
		/// Can be null (IntPtr.Zero).</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);

		/// <summary>
		/// Reads data from the specified file or I/O device.
		/// </summary>
		/// <param name="hFile">A handle to the file or device.</param>
		/// <param name="lpBuffer">The buffer that receives the data read.</param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <param name="lpNumberOfBytesRead">A pointer to a <b>uint</b> to receives the number
		/// of bytes written when using a synchronous <paramref name="hFile"/> parameter.
		/// Can be null (IntPtr.Zero), if <paramref name="lpOverlapped"/> is not null (IntPtr.Zero).</param>
		/// <param name="lpOverlapped">A <see cref="NativeOverlapped"/> structure.</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, IntPtr lpNumberOfBytesRead, ref NativeOverlapped lpOverlapped);

		/// <summary>
		/// Reads data from the specified file or I/O device.
		/// </summary>
		/// <param name="hFile">A handle to the file or device.</param>
		/// <param name="lpBuffer">The buffer that receives the data read.</param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <param name="lpNumberOfBytesRead">Receives the number of bytes read when using
		/// a synchronous <paramref name="hFile"/> parameter.</param>
		/// <param name="lpOverlapped">A <see cref="NativeOverlapped"/> structure.</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, ref NativeOverlapped lpOverlapped);
		#endregion

		/// <summary>
		/// Sets the physical file size for the specified file to the current position of the file pointer.
		/// </summary>
		/// <param name="hFile">A handle to the file to be extended or truncated.</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool SetEndOfFile(IntPtr hFile);

		#region SetFilePointer/Ex
		/// <summary>
		/// Moves the file pointer of the specified file.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="lDistanceToMove">The low order 32-bits of a signed value that specifies the number of bytes to move the file pointer.</param>
		/// <param name="lpDistanceToMoveHigh">A pointer to the high order 32-bits of a signed value that specifies the number of bytes to move
		/// the file pointer. This variable also recieves the new file pointer. If this parameter is null (IntPtr.Zero), the new file pointer is
		/// not returned.</param>
		/// <param name="dwMoveMethod">The starting point for the file pointer move.</param>
		/// <returns>If successful returns the low order 32-bits of the new file pointer position, otherwise <see cref="INVALID_SET_FILE_POINTER"/>.</returns>
		[DllImport(DLLName)]
		public static extern uint SetFilePointer(IntPtr hFile, int lDistanceToMove, IntPtr lpDistanceToMoveHigh, FilePointerMoveMethod dwMoveMethod);

		/// <summary>
		/// Moves the file pointer of the specified file.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="lDistanceToMove">The low order 32-bits of a signed value that specifies the number of bytes to move the file pointer.</param>
		/// <param name="lpDistanceToMoveHigh">A pointer to the high order 32-bits of a signed value that specifies the number of bytes to move
		/// the file pointer. This variable also recieves the new file pointer. If this parameter is null (IntPtr.Zero), the new file pointer is
		/// not returned.</param>
		/// <param name="dwMoveMethod">The starting point for the file pointer move.</param>
		/// <returns>If successful returns the low order 32-bits of the new file pointer position, otherwise <see cref="INVALID_SET_FILE_POINTER"/>.</returns>
		[DllImport(DLLName)]
		public static extern uint SetFilePointer(IntPtr hFile, uint lDistanceToMove, IntPtr lpDistanceToMoveHigh, FilePointerMoveMethod dwMoveMethod);

		/// <summary>
		/// Moves the file pointer of the specified file.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="lDistanceToMove">The low order 32-bits of a signed value that specifies the number of bytes to move the file pointer.</param>
		/// <param name="lpDistanceToMoveHigh">The high order 32-bits of a signed value that specifies the number of bytes to move the file pointer.
		/// This variable also recieves the new file pointer.</param>
		/// <param name="dwMoveMethod">The starting point for the file pointer move.</param>
		/// <returns>If successful returns the low order 32-bits of the new file pointer position, otherwise <see cref="INVALID_SET_FILE_POINTER"/>.</returns>
		[DllImport(DLLName)]
		public static extern uint SetFilePointer(IntPtr hFile, uint lDistanceToMove, ref int lpDistanceToMoveHigh, FilePointerMoveMethod dwMoveMethod);

		/// <summary>
		/// Moves the file pointer of the specified file.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="liDistanceToMove">The number of bytes to move the file pointer. A positive value
		/// moves the pointer forward in the file and a negative value moves the file pointer backward.</param>
		/// <param name="lpNewFilePointer">A pointer to a <b>long</b> variable to receive the new file pointer.
		/// If this parameter is null (IntPtr.Zero), the new file pointer is not returned.</param>
		/// <param name="dwMoveMethod">The starting point for the file pointer move.</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool SetFilePointerEx(IntPtr hFile, long liDistanceToMove, IntPtr lpNewFilePointer, FilePointerMoveMethod dwMoveMethod);

		/// <summary>
		/// Moves the file pointer of the specified file.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="liDistanceToMove">The number of bytes to move the file pointer. A positive value
		/// moves the pointer forward in the file and a negative value moves the file pointer backward.</param>
		/// <param name="lpNewFilePointer">Rreceive the new file pointer.</param>
		/// <param name="dwMoveMethod">The starting point for the file pointer move.</param>
		/// <returns><b>true</b> if successful; otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool SetFilePointerEx(IntPtr hFile, long liDistanceToMove, out long lpNewFilePointer, FilePointerMoveMethod dwMoveMethod);
		#endregion

		#region WriteFile
		/// <summary>
		/// Writes data to the specified file or input/output (I/O) device.
		/// </summary>
		/// <param name="hFile">Handle to the file or input/output (I/O) device.</param>
		/// <param name="lpBuffer">The buffer containing the data to be written.</param>
		/// <param name="nNumberOfBytesToWrite">The number of bytes to be written.</param>
		/// <param name="lpNumberOfBytesWritten">Receives the number of bytes written when using
		/// a synchronous <paramref name="hFile"/> parameter.</param>
		/// <param name="lpOverlapped">A pointer to a <see cref="NativeOverlapped"/> structure.
		/// Can be null (IntPtr.Zero).</param>
		/// <returns>
		/// <para>If the function succeeds, the return value is <b>true</b>.</para>
		/// <para>If the function fails, or is completing asynchronously, the return value is <b>false</b>.
		/// To get extended error information, call the <see cref="WinKernel.GetLastError"/> function.</para>
		/// <para><b>Note:</b> The <see cref="WinKernel.GetLastError"/> code <see cref="ERROR.IO_PENDING">
		/// ERROR_IO_PENDING</see> is not a failure; it designates the write operation is pending completion
		/// asynchronously.</para>
		/// </returns>
		[DllImport(DLLName)]
		public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);

		/// <summary>
		/// Writes data to the specified file or input/output (I/O) device.
		/// </summary>
		/// <param name="hFile">Handle to the file or input/output (I/O) device.</param>
		/// <param name="lpBuffer">The buffer containing the data to be written.</param>
		/// <param name="nNumberOfBytesToWrite">The number of bytes to be written.</param>
		/// <param name="lpNumberOfBytesWritten">A pointer to a <b>uint</b> to receives the number
		/// of bytes written when using a synchronous <paramref name="hFile"/> parameter.
		/// Can be null (IntPtr.Zero), if <paramref name="lpOverlapped"/> is not null (IntPtr.Zero).</param>
		/// <param name="lpOverlapped">A pointer to a <see cref="NativeOverlapped"/> structure.
		/// Can be null (IntPtr.Zero).</param>
		/// <returns>
		/// <para>If the function succeeds, the return value is <b>true</b>.</para>
		/// <para>If the function fails, or is completing asynchronously, the return value is <b>false</b>.
		/// To get extended error information, call the <see cref="WinKernel.GetLastError"/> function.</para>
		/// <para><b>Note:</b> The <see cref="WinKernel.GetLastError"/> code <see cref="ERROR.IO_PENDING">
		/// ERROR_IO_PENDING</see> is not a failure; it designates the write operation is pending completion
		/// asynchronously.</para>
		/// </returns>
		[DllImport(DLLName)]
		public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, IntPtr lpNumberOfBytesWritten, IntPtr lpOverlapped);

		/// <summary>
		/// Writes data to the specified file or input/output (I/O) device.
		/// </summary>
		/// <param name="hFile">Handle to the file or input/output (I/O) device.</param>
		/// <param name="lpBuffer">The buffer containing the data to be written.</param>
		/// <param name="nNumberOfBytesToWrite">The number of bytes to be written.</param>
		/// <param name="lpNumberOfBytesWritten">Receives the number of bytes written when using
		/// a synchronous <paramref name="hFile"/> parameter.</param>
		/// <param name="lpOverlapped">A <see cref="NativeOverlapped"/> structure.</param>
		/// <returns>
		/// <para>If the function succeeds, the return value is <b>true</b>.</para>
		/// <para>If the function fails, or is completing asynchronously, the return value is <b>false</b>.
		/// To get extended error information, call the <see cref="WinKernel.GetLastError"/> function.</para>
		/// <para><b>Note:</b> The <see cref="WinKernel.GetLastError"/> code <see cref="ERROR.IO_PENDING">
		/// ERROR_IO_PENDING</see> is not a failure; it designates the write operation is pending completion
		/// asynchronously.</para>
		/// </returns>
		[DllImport(DLLName)]
		public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, ref NativeOverlapped lpOverlapped);

		/// <summary>
		/// Writes data to the specified file or input/output (I/O) device.
		/// </summary>
		/// <param name="hFile">Handle to the file or input/output (I/O) device.</param>
		/// <param name="lpBuffer">The buffer containing the data to be written.</param>
		/// <param name="nNumberOfBytesToWrite">The number of bytes to be written.</param>
		/// <param name="lpNumberOfBytesWritten">A pointer to a <b>uint</b> to receives the number
		/// of bytes written when using a synchronous <paramref name="hFile"/> parameter.
		/// Can be null (IntPtr.Zero), if <paramref name="lpOverlapped"/> is not null (IntPtr.Zero).</param>
		/// <param name="lpOverlapped">A <see cref="NativeOverlapped"/> structure.</param>
		/// <returns>
		/// <para>If the function succeeds, the return value is <b>true</b>.</para>
		/// <para>If the function fails, or is completing asynchronously, the return value is <b>false</b>.
		/// To get extended error information, call the <see cref="WinKernel.GetLastError"/> function.</para>
		/// <para><b>Note:</b> The <see cref="WinKernel.GetLastError"/> code <see cref="ERROR.IO_PENDING">
		/// ERROR_IO_PENDING</see> is not a failure; it designates the write operation is pending completion
		/// asynchronously.</para>
		/// </returns>
		[DllImport(DLLName)]
		public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, IntPtr lpNumberOfBytesWritten, ref NativeOverlapped lpOverlapped);
		#endregion
	}
}
