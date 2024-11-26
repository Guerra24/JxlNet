using System;

namespace JxlNet;

public unsafe partial struct JxlChunkedFrameInputSource
{
    public void* opaque;

    [NativeTypeName("void (*)(void *, JxlPixelFormat *)")]
    public IntPtr get_color_channels_pixel_format;

    [NativeTypeName("const void *(*)(void *, size_t, size_t, size_t, size_t, size_t *)")]
    public IntPtr get_color_channel_data_at;

    [NativeTypeName("void (*)(void *, size_t, JxlPixelFormat *)")]
    public IntPtr get_extra_channel_pixel_format;

    [NativeTypeName("const void *(*)(void *, size_t, size_t, size_t, size_t, size_t, size_t *)")]
    public IntPtr get_extra_channel_data_at;

    [NativeTypeName("void (*)(void *, const void *)")]
    public IntPtr release_buffer;
}
