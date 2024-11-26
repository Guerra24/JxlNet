using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate float* jpegxl_cms_get_buffer_func(void* user_data, [NativeTypeName("size_t")] UIntPtr thread);
