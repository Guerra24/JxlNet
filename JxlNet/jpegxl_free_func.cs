using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void jpegxl_free_func(void* opaque, void* address);
