using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void JxlImageOutRunCallback(void* run_opaque, [NativeTypeName("size_t")] UIntPtr thread_id, [NativeTypeName("size_t")] UIntPtr x, [NativeTypeName("size_t")] UIntPtr y, [NativeTypeName("size_t")] UIntPtr num_pixels, [NativeTypeName("const void *")] void* pixels);
