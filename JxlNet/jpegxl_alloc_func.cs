using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void* jpegxl_alloc_func(void* opaque, [NativeTypeName("size_t")] UIntPtr size);
