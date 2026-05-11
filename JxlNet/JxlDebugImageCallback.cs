using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void JxlDebugImageCallback(void* opaque, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("size_t")] nuint xsize, [NativeTypeName("size_t")] nuint ysize, [NativeTypeName("const JxlColorEncoding *")] JxlColorEncoding* color, [NativeTypeName("const uint16_t *")] ushort* pixels);
