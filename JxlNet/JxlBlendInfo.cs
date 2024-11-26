namespace JxlNet;

public partial struct JxlBlendInfo
{
    public JxlBlendMode blendmode;

    [NativeTypeName("uint32_t")]
    public uint source;

    [NativeTypeName("uint32_t")]
    public uint alpha;

    public int clamp;
}
