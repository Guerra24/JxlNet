namespace JxlNet;

public unsafe partial struct JxlColorEncoding
{
    public JxlColorSpace color_space;

    public JxlWhitePoint white_point;

    [NativeTypeName("double[2]")]
    public fixed double white_point_xy[2];

    public JxlPrimaries primaries;

    [NativeTypeName("double[2]")]
    public fixed double primaries_red_xy[2];

    [NativeTypeName("double[2]")]
    public fixed double primaries_green_xy[2];

    [NativeTypeName("double[2]")]
    public fixed double primaries_blue_xy[2];

    public JxlTransferFunction transfer_function;

    public double gamma;

    public JxlRenderingIntent rendering_intent;
}
