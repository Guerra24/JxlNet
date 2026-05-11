using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void JxlImageOutRunCallback(void* run_opaque, [NativeTypeName("size_t")] nuint thread_id, [NativeTypeName("size_t")] nuint x, [NativeTypeName("size_t")] nuint y, [NativeTypeName("size_t")] nuint num_pixels, [NativeTypeName("const void *")] void* pixels);
