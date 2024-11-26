using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void JxlDebugImageCallback(void* opaque, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("size_t")] UIntPtr xsize, [NativeTypeName("size_t")] UIntPtr ysize, [NativeTypeName("const JxlColorEncoding *")] JxlColorEncoding* color, [NativeTypeName("const uint16_t *")] ushort* pixels);
