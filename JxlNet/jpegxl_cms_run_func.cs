using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int jpegxl_cms_run_func(void* user_data, [NativeTypeName("size_t")] UIntPtr thread, [NativeTypeName("const float *")] float* input_buffer, float* output_buffer, [NativeTypeName("size_t")] UIntPtr num_pixels);
