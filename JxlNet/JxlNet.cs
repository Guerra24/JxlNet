using System.Reflection;
using System.Runtime.InteropServices;

namespace JxlNet;

public static partial class Jxl
{
    public static readonly nint JxlResizableParallelRunner;
    public static readonly nint JxlThreadParallelRunner;

    public static bool IsAvailable { get; }

    static Jxl()
    {
        try
        {
            NativeLibrary.Load("brotlicommon", Assembly.GetExecutingAssembly(), null);
            NativeLibrary.Load("brotlidec", Assembly.GetExecutingAssembly(), null);
            NativeLibrary.Load("brotlienc", Assembly.GetExecutingAssembly(), null);
            NativeLibrary.Load("jxl_cms", Assembly.GetExecutingAssembly(), null);
            NativeLibrary.Load("jxl", Assembly.GetExecutingAssembly(), null);

            var jxl_threads = NativeLibrary.Load("jxl_threads", Assembly.GetExecutingAssembly(), null);
            JxlResizableParallelRunner = NativeLibrary.GetExport(jxl_threads, "JxlResizableParallelRunner");
            JxlThreadParallelRunner = NativeLibrary.GetExport(jxl_threads, "JxlThreadParallelRunner");

            IsAvailable = true;
        }
        catch { }
    }
}
