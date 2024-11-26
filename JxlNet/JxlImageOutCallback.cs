using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void JxlImageOutCallback(void* opaque, [NativeTypeName("size_t")] UIntPtr x, [NativeTypeName("size_t")] UIntPtr y, [NativeTypeName("size_t")] UIntPtr num_pixels, [NativeTypeName("const void *")] void* pixels);
