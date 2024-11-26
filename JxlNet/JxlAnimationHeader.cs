namespace JxlNet;

public partial struct JxlAnimationHeader
{
    [NativeTypeName("uint32_t")]
    public uint tps_numerator;

    [NativeTypeName("uint32_t")]
    public uint tps_denominator;

    [NativeTypeName("uint32_t")]
    public uint num_loops;

    public int have_timecodes;
}
