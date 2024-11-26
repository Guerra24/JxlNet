using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void jpegxl_cms_destroy_func(void* param0);
