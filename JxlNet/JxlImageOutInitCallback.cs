using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void* JxlImageOutInitCallback(void* init_opaque, [NativeTypeName("size_t")] nuint num_threads, [NativeTypeName("size_t")] nuint num_pixels_per_thread);
