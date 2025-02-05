using System;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace JxlNet;

public static unsafe partial class JxlThreads
{
    public static readonly IntPtr JxlResizableParallelRunner;
    public static readonly IntPtr JxlThreadParallelRunner;

    static unsafe JxlThreads()
    {
#if NETSTANDARD || WINDOWS10_0_17763_0_OR_GREATER
        FreeLibrarySafeHandle jxl_threads;
        int versionMajor = Environment.OSVersion.Version.Major;
        int versionMinor = Environment.OSVersion.Version.Minor;
        double version = versionMajor + (double)versionMinor / 10;
        if (version >= 6.2)
        {
            uint length = 0;
            WIN32_ERROR result;
            fixed (char* buf = new char[0])
            {
                result = PInvoke.GetCurrentPackageFullName(ref length, buf);
            }
            fixed (char* buf = new char[length])
            {
                result = PInvoke.GetCurrentPackageFullName(ref length, buf);
            }
            if (result != WIN32_ERROR.APPMODEL_ERROR_NO_PACKAGE)
            {
                jxl_threads = PInvoke.LoadPackagedLibrary("jxl_threads");
                JxlResizableParallelRunner = PInvoke.GetProcAddress(jxl_threads, "JxlResizableParallelRunner").Value;
                JxlThreadParallelRunner = PInvoke.GetProcAddress(jxl_threads, "JxlThreadParallelRunner").Value;
                return;
            }
        }
        jxl_threads = PInvoke.LoadLibrary("jxl_threads");
        JxlResizableParallelRunner = PInvoke.GetProcAddress(jxl_threads, "JxlResizableParallelRunner").Value;
        JxlThreadParallelRunner = PInvoke.GetProcAddress(jxl_threads, "JxlThreadParallelRunner").Value;
#else
        var jxl_threads = NativeLibrary.Load("jxl_threads");
        JxlResizableParallelRunner = NativeLibrary.GetExport(jxl_threads, "JxlResizableParallelRunner");
        JxlThreadParallelRunner = NativeLibrary.GetExport(jxl_threads, "JxlThreadParallelRunner");
#endif
    }
}
