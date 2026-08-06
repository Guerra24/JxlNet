using System.Reflection;
using System.Runtime.InteropServices;

namespace JxlNet;

public static partial class Jxl
{
    public static bool IsAvailable { get; }

    static Jxl()
    {
        try
        {
            NativeLibrary.Load("jxl", Assembly.GetExecutingAssembly(), null);
            IsAvailable = true;
        }
        catch { }
    }
}

public static partial class JxlCms
{
    public static bool IsAvailable { get; }

    static JxlCms()
    {
        try
        {
            NativeLibrary.Load("jxl_cms", Assembly.GetExecutingAssembly(), null);
            IsAvailable = true;
        }
        catch { }
    }
}

public static partial class JxlThreads
{
    public static readonly nint JxlResizableParallelRunner;
    public static readonly nint JxlThreadParallelRunner;

    public static bool IsAvailable { get; }

    static JxlThreads()
    {
        try
        {
            var jxl_threads = NativeLibrary.Load("jxl_threads", Assembly.GetExecutingAssembly(), null);
            JxlResizableParallelRunner = NativeLibrary.GetExport(jxl_threads, "JxlResizableParallelRunner");
            JxlThreadParallelRunner = NativeLibrary.GetExport(jxl_threads, "JxlThreadParallelRunner");
            IsAvailable = true;
        }
        catch { }
    }
}
