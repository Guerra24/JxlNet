using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
[return: NativeTypeName("JxlParallelRetCode")]
public unsafe delegate int JxlParallelRunner(void* runner_opaque, void* jpegxl_opaque, [NativeTypeName("JxlParallelRunInit")] IntPtr init, [NativeTypeName("JxlParallelRunFunction")] IntPtr func, [NativeTypeName("uint32_t")] uint start_range, [NativeTypeName("uint32_t")] uint end_range);
