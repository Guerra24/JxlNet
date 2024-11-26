using System;

namespace JxlNet;

public partial struct JxlColorProfile
{
    [NativeTypeName("__AnonymousRecord_cms_interface_L49_C3")]
    public _icc_e__Struct icc;

    public JxlColorEncoding color_encoding;

    [NativeTypeName("size_t")]
    public UIntPtr num_channels;

    public unsafe partial struct _icc_e__Struct
    {
        [NativeTypeName("const uint8_t *")]
        public byte* data;

        [NativeTypeName("size_t")]
        public UIntPtr size;
    }
}
