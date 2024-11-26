using System;

namespace JxlNet;

public partial struct JxlPixelFormat
{
    [NativeTypeName("uint32_t")]
    public uint num_channels;

    public JxlDataType data_type;

    public JxlEndianness endianness;

    [NativeTypeName("size_t")]
    public UIntPtr align;
}
