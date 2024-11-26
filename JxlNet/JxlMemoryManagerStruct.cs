using System;

namespace JxlNet;

public unsafe partial struct JxlMemoryManagerStruct
{
    public void* opaque;

    [NativeTypeName("jpegxl_alloc_func")]
    public IntPtr alloc;

    [NativeTypeName("jpegxl_free_func")]
    public IntPtr free;
}
