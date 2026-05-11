using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void JxlImageOutCallback(void* opaque, [NativeTypeName("size_t")] nuint x, [NativeTypeName("size_t")] nuint y, [NativeTypeName("size_t")] nuint num_pixels, [NativeTypeName("const void *")] void* pixels);
