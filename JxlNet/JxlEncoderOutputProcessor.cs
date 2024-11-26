using System;

namespace JxlNet;

public unsafe partial struct JxlEncoderOutputProcessor
{
    public void* opaque;

    [NativeTypeName("void *(*)(void *, size_t *)")]
    public IntPtr get_buffer;

    [NativeTypeName("void (*)(void *, size_t)")]
    public IntPtr release_buffer;

    [NativeTypeName("void (*)(void *, uint64_t)")]
    public IntPtr seek;

    [NativeTypeName("void (*)(void *, uint64_t)")]
    public IntPtr set_finalized_position;
}
