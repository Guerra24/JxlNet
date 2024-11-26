namespace JxlNet;

public partial struct JxlFrameHeader
{
    [NativeTypeName("uint32_t")]
    public uint duration;

    [NativeTypeName("uint32_t")]
    public uint timecode;

    [NativeTypeName("uint32_t")]
    public uint name_length;

    public int is_last;

    public JxlLayerInfo layer_info;
}
