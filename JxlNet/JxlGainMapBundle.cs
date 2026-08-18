namespace JxlNet;

public unsafe partial struct JxlGainMapBundle
{
    [NativeTypeName("uint8_t")]
    public byte jhgm_version;

    [NativeTypeName("uint16_t")]
    public ushort gain_map_metadata_size;

    [NativeTypeName("const uint8_t *")]
    public byte* gain_map_metadata;

    public int has_color_encoding;

    public JxlColorEncoding color_encoding;

    [NativeTypeName("uint32_t")]
    public uint alt_icc_size;

    [NativeTypeName("const uint8_t *")]
    public byte* alt_icc;

    [NativeTypeName("uint32_t")]
    public uint gain_map_size;

    [NativeTypeName("const uint8_t *")]
    public byte* gain_map;
}
