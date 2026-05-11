using System.Runtime.CompilerServices;

namespace JxlNet;

public partial struct JxlColorEncoding
{
    public JxlColorSpace color_space;

    public JxlWhitePoint white_point;

    [NativeTypeName("double[2]")]
    public _white_point_xy_e__FixedBuffer white_point_xy;

    public JxlPrimaries primaries;

    [NativeTypeName("double[2]")]
    public _primaries_red_xy_e__FixedBuffer primaries_red_xy;

    [NativeTypeName("double[2]")]
    public _primaries_green_xy_e__FixedBuffer primaries_green_xy;

    [NativeTypeName("double[2]")]
    public _primaries_blue_xy_e__FixedBuffer primaries_blue_xy;

    public JxlTransferFunction transfer_function;

    public double gamma;

    public JxlRenderingIntent rendering_intent;

    [InlineArray(2)]
    public partial struct _white_point_xy_e__FixedBuffer
    {
        public double e0;
    }

    [InlineArray(2)]
    public partial struct _primaries_red_xy_e__FixedBuffer
    {
        public double e0;
    }

    [InlineArray(2)]
    public partial struct _primaries_green_xy_e__FixedBuffer
    {
        public double e0;
    }

    [InlineArray(2)]
    public partial struct _primaries_blue_xy_e__FixedBuffer
    {
        public double e0;
    }
}
