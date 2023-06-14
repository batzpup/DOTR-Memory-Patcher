
using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;


namespace DOTRModder
{
    static internal class Mem
    {
        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }
        [Flags]
        public enum FlNewProtect : uint
        {
            PAGE_NOACCESS = 0x01,
            PAGE_READONLY = 0x02,
            PAGE_READWRITE = 0x04,
            PAGE_WRITECOPY = 0x08,
            PAGE_EXECUTE = 0x10,
            PAGE_EXECUTE_READ = 0x20,
            PAGE_EXECUTE_READWRITE = 0x40,
            PAGE_EXECUTE_WRITECOPY = 0x80,
            PAGE_GUARD = 0x100,
            PAGE_NOCACHE = 0x200,
            PAGE_WRITECOMBINE = 0x400,
        }
        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VirtualMemoryOperation = 0x00000008,
            VirtualMemoryRead = 0x00000010,
            VirtualMemoryWrite = 0x00000020,
            DuplicateHandle = 0x00000040,
            CreateProcess = 0x000000080,
            SetQuota = 0x00000100,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            QueryLimitedInformation = 0x00001000,
            Synchronize = 0x00100000
        } 
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            UInt32 nSize,
            out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            [MarshalAs(UnmanagedType.AsAny)] object lpBuffer,
            int dwSize,
            out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            [Out] byte[] lpBuffer,
            int dwSize,
            out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            [Out, MarshalAs(UnmanagedType.AsAny)] object lpBuffer,
            int dwSize,
            out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            IntPtr lpBuffer,
            int dwSize,
            out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
            public static extern IntPtr OpenProcess(
            uint processAccess,
            bool bInheritHandle,
            uint processId);
        public static IntPtr OpenProcess(Process proc, ProcessAccessFlags flags)
        {
            return OpenProcess((uint)flags, false, (uint)proc.Id);
        }

       [DllImport("kernel32.dll", SetLastError = true)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress,
         UIntPtr dwSize, FlNewProtect flNewProtect, out uint lpflOldProtect);
        public static IntPtr GetModuleBaseAddress(Process process, string name)
        {
            IntPtr hModuleBaseAddress = IntPtr.Zero;
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName == name)
                {
                    hModuleBaseAddress = module.BaseAddress;
                    break;
                }
            }
            return hModuleBaseAddress;
        }


        public static void PatchEx(IntPtr dstAddr, byte[] srcAddr, int size, IntPtr hProcess)
        {
            uint oldProtectionRight;
          
            VirtualProtectEx(hProcess, dstAddr, (uint)size, FlNewProtect.PAGE_EXECUTE_READWRITE, out oldProtectionRight);
            WriteProcessMemory(hProcess, dstAddr, srcAddr, (uint)size, out _);
            VirtualProtectEx(hProcess, dstAddr, (uint)size, (FlNewProtect)oldProtectionRight, out _);
          
            /* string byteString = "";
            foreach (var data in srcAddr)
            {
               
                byteString += $"0x{data.ToString("X")},";
            }
            //MessageBox.Show($"Patching 0x{dstAddr.ToString("X")} with {byteString} in 0x{hProcess.ToString("X")}");
            */
        }

        [DllImport("msvcrt.dll", EntryPoint = "memset", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern IntPtr MemSet(IntPtr dest, int c, int byteCount);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool DebugActiveProcess(uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool DebugActiveProcessStop(uint dwProcessId);

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        public static void NopMips(IntPtr dstAddr, uint NumberOfInstructions,IntPtr hproc)
        {
            
            uint size = NumberOfInstructions * 4;
            uint oldProtectionRight;
            byte[] bytes = new byte[size];
            for (int i = 0; i < size; i++)
            {
                bytes[i] = 0;
            }
            VirtualProtectEx(hproc, dstAddr, (uint)size, FlNewProtect.PAGE_EXECUTE_READWRITE, out oldProtectionRight);
            WriteProcessMemory(hproc, dstAddr, bytes, (uint)size, out _);
            VirtualProtectEx(hproc, dstAddr, (uint)size, (FlNewProtect)oldProtectionRight, out _);

        }
        public static void SuspendProcess(this Process process)
        {
            foreach (ProcessThread thread in process.Threads)
            {
                var pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id);
                if (pOpenThread == IntPtr.Zero)
                {
                    break;
                }
                SuspendThread(pOpenThread);
            }
        }
        public static void ResumeProcess(this Process process)
        {
            foreach (ProcessThread thread in process.Threads)
            {
                var pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id);
                if (pOpenThread == IntPtr.Zero)
                {
                    break;

                }
                ResumeThread(pOpenThread);
            }
        }


    }
}
