using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void* jpegxl_cms_init_func(void* init_data, [NativeTypeName("size_t")] UIntPtr num_threads, [NativeTypeName("size_t")] UIntPtr pixels_per_thread, [NativeTypeName("const JxlColorProfile *")] JxlColorProfile* input_profile, [NativeTypeName("const JxlColorProfile *")] JxlColorProfile* output_profile, float intensity_target);
