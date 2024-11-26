namespace JxlNet;

public enum JxlEncoderError
{
    JXL_ENC_ERR_OK = 0,
    JXL_ENC_ERR_GENERIC = 1,
    JXL_ENC_ERR_OOM = 2,
    JXL_ENC_ERR_JBRD = 3,
    JXL_ENC_ERR_BAD_INPUT = 4,
    JXL_ENC_ERR_NOT_SUPPORTED = 0x80,
    JXL_ENC_ERR_API_USAGE = 0x81,
}
