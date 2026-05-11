using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void JxlParallelRunFunction(void* jpegxl_opaque, [NativeTypeName("uint32_t")] uint value, [NativeTypeName("size_t")] nuint thread_id);
