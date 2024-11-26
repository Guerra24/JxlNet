using System;
using System.Runtime.InteropServices;

namespace JxlNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int jpegxl_cms_set_fields_from_icc_func(void* user_data, [NativeTypeName("const uint8_t *")] byte* icc_data, [NativeTypeName("size_t")] UIntPtr icc_size, JxlColorEncoding* c, int* cmyk);
