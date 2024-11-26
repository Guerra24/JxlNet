namespace JxlNet;

public partial struct JxlBitDepth
{
    public JxlBitDepthType type;

    [NativeTypeName("uint32_t")]
    public uint bits_per_sample;

    [NativeTypeName("uint32_t")]
    public uint exponent_bits_per_sample;
}
