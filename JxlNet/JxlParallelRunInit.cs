using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
[return: NativeTypeName("JxlParallelRetCode")]
public unsafe delegate int JxlParallelRunInit(void* jpegxl_opaque, [NativeTypeName("size_t")] UIntPtr num_threads);
