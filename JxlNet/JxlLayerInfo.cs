namespace JxlNet;

public partial struct JxlLayerInfo
{
    public int have_crop;

    [NativeTypeName("int32_t")]
    public int crop_x0;

    [NativeTypeName("int32_t")]
    public int crop_y0;

    [NativeTypeName("uint32_t")]
    public uint xsize;

    [NativeTypeName("uint32_t")]
    public uint ysize;

    public JxlBlendInfo blend_info;

    [NativeTypeName("uint32_t")]
    public uint save_as_reference;
}
