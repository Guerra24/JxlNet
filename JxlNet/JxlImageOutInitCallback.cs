using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void* JxlImageOutInitCallback(void* init_opaque, [NativeTypeName("size_t")] UIntPtr num_threads, [NativeTypeName("size_t")] UIntPtr num_pixels_per_thread);
