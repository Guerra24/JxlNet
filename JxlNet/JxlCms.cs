using System.Runtime.InteropServices;

namespace JxlNet;

public static unsafe partial class JxlCms
{
    [DllImport("jxl_cms", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const JxlCmsInterface *")]
    public static extern JxlCmsInterface* JxlGetDefaultCms();
}
