using System;

namespace JxlNet;

public unsafe partial struct JxlCmsInterface
{
    public void* set_fields_data;

    [NativeTypeName("jpegxl_cms_set_fields_from_icc_func")]
    public IntPtr set_fields_from_icc;

    public void* init_data;

    [NativeTypeName("jpegxl_cms_init_func")]
    public IntPtr init;

    [NativeTypeName("jpegxl_cms_get_buffer_func")]
    public IntPtr get_src_buf;

    [NativeTypeName("jpegxl_cms_get_buffer_func")]
    public IntPtr get_dst_buf;

    [NativeTypeName("jpegxl_cms_run_func")]
    public IntPtr run;

    [NativeTypeName("jpegxl_cms_destroy_func")]
    public IntPtr destroy;
}
