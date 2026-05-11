using System.Runtime.CompilerServices;

namespace JxlNet;

public partial struct JxlExtraChannelInfo
{
    public JxlExtraChannelType type;

    [NativeTypeName("uint32_t")]
    public uint bits_per_sample;

    [NativeTypeName("uint32_t")]
    public uint exponent_bits_per_sample;

    [NativeTypeName("uint32_t")]
    public uint dim_shift;

    [NativeTypeName("uint32_t")]
    public uint name_length;

    public int alpha_premultiplied;

    [NativeTypeName("float[4]")]
    public _spot_color_e__FixedBuffer spot_color;

    [NativeTypeName("uint32_t")]
    public uint cfa_channel;

    [InlineArray(4)]
    public partial struct _spot_color_e__FixedBuffer
    {
        public float e0;
    }
}
