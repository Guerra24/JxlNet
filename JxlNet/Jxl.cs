using System;
using System.Runtime.InteropServices;

namespace JxlNet;

public static unsafe partial class Jxl
{
    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint JxlDecoderVersion();

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlSignature JxlSignatureCheck([NativeTypeName("const uint8_t *")] byte* buf, [NativeTypeName("size_t")] nuint len);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoder* JxlDecoderCreate([NativeTypeName("const JxlMemoryManager *")] JxlMemoryManagerStruct* memory_manager);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderReset(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderDestroy(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderRewind(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderSkipFrames(JxlDecoder* dec, [NativeTypeName("size_t")] nuint amount);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSkipCurrentFrame(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetParallelRunner(JxlDecoder* dec, [NativeTypeName("JxlParallelRunner")] IntPtr parallel_runner, void* parallel_runner_opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint JxlDecoderSizeHintBasicInfo([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSubscribeEvents(JxlDecoder* dec, int events_wanted);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetKeepOrientation(JxlDecoder* dec, int skip_reorientation);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetUnpremultiplyAlpha(JxlDecoder* dec, int unpremul_alpha);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetRenderSpotcolors(JxlDecoder* dec, int render_spotcolors);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetCoalescing(JxlDecoder* dec, int coalescing);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderProcessInput(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetInput(JxlDecoder* dec, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint JxlDecoderReleaseInput(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderCloseInput(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetBasicInfo([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, JxlBasicInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetExtraChannelInfo([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("size_t")] nuint index, JxlExtraChannelInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetExtraChannelName([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("size_t")] nuint index, [NativeTypeName("char *")] sbyte* name, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetColorAsEncodedProfile([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, JxlColorProfileTarget target, JxlColorEncoding* color_encoding);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetICCProfileSize([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, JxlColorProfileTarget target, [NativeTypeName("size_t *")] nuint* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetColorAsICCProfile([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, JxlColorProfileTarget target, [NativeTypeName("uint8_t *")] byte* icc_profile, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetPreferredColorProfile(JxlDecoder* dec, [NativeTypeName("const JxlColorEncoding *")] JxlColorEncoding* color_encoding);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetDesiredIntensityTarget(JxlDecoder* dec, float desired_intensity_target);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetOutputColorProfile(JxlDecoder* dec, [NativeTypeName("const JxlColorEncoding *")] JxlColorEncoding* color_encoding, [NativeTypeName("const uint8_t *")] byte* icc_data, [NativeTypeName("size_t")] nuint icc_size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetCms(JxlDecoder* dec, JxlCmsInterface cms);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderPreviewOutBufferSize([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("size_t *")] nuint* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetPreviewOutBuffer(JxlDecoder* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, void* buffer, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetFrameHeader([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, JxlFrameHeader* header);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetFrameName([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("char *")] sbyte* name, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetExtraChannelBlendInfo([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("size_t")] nuint index, JxlBlendInfo* blend_info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderImageOutBufferSize([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("size_t *")] nuint* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetImageOutBuffer(JxlDecoder* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, void* buffer, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetImageOutCallback(JxlDecoder* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("JxlImageOutCallback")] IntPtr callback, void* opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetMultithreadedImageOutCallback(JxlDecoder* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("JxlImageOutInitCallback")] IntPtr init_callback, [NativeTypeName("JxlImageOutRunCallback")] IntPtr run_callback, [NativeTypeName("JxlImageOutDestroyCallback")] IntPtr destroy_callback, void* init_opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderExtraChannelBufferSize([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("size_t *")] nuint* size, [NativeTypeName("uint32_t")] uint index);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetExtraChannelBuffer(JxlDecoder* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, void* buffer, [NativeTypeName("size_t")] nuint size, [NativeTypeName("uint32_t")] uint index);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetJPEGBuffer(JxlDecoder* dec, [NativeTypeName("uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint JxlDecoderReleaseJPEGBuffer(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetBoxBuffer(JxlDecoder* dec, [NativeTypeName("uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint JxlDecoderReleaseBoxBuffer(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetDecompressBoxes(JxlDecoder* dec, int decompress);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetBoxType(JxlDecoder* dec, [NativeTypeName("JxlBoxType")] sbyte* type, int decompressed);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetBoxSizeRaw([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("uint64_t *")] ulong* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetBoxSizeContents([NativeTypeName("const JxlDecoder *")] JxlDecoder* dec, [NativeTypeName("uint64_t *")] ulong* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetProgressiveDetail(JxlDecoder* dec, JxlProgressiveDetail detail);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint JxlDecoderGetIntendedDownsamplingRatio(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderFlushImage(JxlDecoder* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetImageOutBitDepth(JxlDecoder* dec, [NativeTypeName("const JxlBitDepth *")] JxlBitDepth* bit_depth);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint JxlEncoderVersion();

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoder* JxlEncoderCreate([NativeTypeName("const JxlMemoryManager *")] JxlMemoryManagerStruct* memory_manager);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderReset(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderDestroy(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderSetCms(JxlEncoder* enc, JxlCmsInterface cms);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetParallelRunner(JxlEncoder* enc, [NativeTypeName("JxlParallelRunner")] IntPtr parallel_runner, void* parallel_runner_opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderError JxlEncoderGetError(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderProcessOutput(JxlEncoder* enc, [NativeTypeName("uint8_t **")] byte** next_out, [NativeTypeName("size_t *")] nuint* avail_out);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameHeader(JxlEncoderFrameSettings* frame_settings, [NativeTypeName("const JxlFrameHeader *")] JxlFrameHeader* frame_header);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelBlendInfo(JxlEncoderFrameSettings* frame_settings, [NativeTypeName("size_t")] nuint index, [NativeTypeName("const JxlBlendInfo *")] JxlBlendInfo* blend_info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameName(JxlEncoderFrameSettings* frame_settings, [NativeTypeName("const char *")] sbyte* frame_name);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameBitDepth(JxlEncoderFrameSettings* frame_settings, [NativeTypeName("const JxlBitDepth *")] JxlBitDepth* bit_depth);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderAddJPEGFrame([NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettings* frame_settings, [NativeTypeName("const uint8_t *")] byte* buffer, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderAddImageFrame([NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettings* frame_settings, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* pixel_format, [NativeTypeName("const void *")] void* buffer, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetOutputProcessor(JxlEncoder* enc, [NativeTypeName("struct JxlEncoderOutputProcessor")] JxlEncoderOutputProcessor output_processor);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderFlushInput(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderAddChunkedFrame([NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettings* frame_settings, int is_last_frame, [NativeTypeName("struct JxlChunkedFrameInputSource")] JxlChunkedFrameInputSource chunked_frame_input);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelBuffer([NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettings* frame_settings, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* pixel_format, [NativeTypeName("const void *")] void* buffer, [NativeTypeName("size_t")] nuint size, [NativeTypeName("uint32_t")] uint index);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderAddBox(JxlEncoder* enc, [NativeTypeName("const JxlBoxType")] sbyte* type, [NativeTypeName("const uint8_t *")] byte* contents, [NativeTypeName("size_t")] nuint size, int compress_box);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderUseBoxes(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderCloseBoxes(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderCloseFrames(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderCloseInput(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetColorEncoding(JxlEncoder* enc, [NativeTypeName("const JxlColorEncoding *")] JxlColorEncoding* color);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetICCProfile(JxlEncoder* enc, [NativeTypeName("const uint8_t *")] byte* icc_profile, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderInitBasicInfo(JxlBasicInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderInitFrameHeader(JxlFrameHeader* frame_header);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderInitBlendInfo(JxlBlendInfo* blend_info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetBasicInfo(JxlEncoder* enc, [NativeTypeName("const JxlBasicInfo *")] JxlBasicInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetUpsamplingMode(JxlEncoder* enc, [NativeTypeName("int64_t")] long factor, [NativeTypeName("int64_t")] long mode);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderInitExtraChannelInfo(JxlExtraChannelType type, JxlExtraChannelInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelInfo(JxlEncoder* enc, [NativeTypeName("size_t")] nuint index, [NativeTypeName("const JxlExtraChannelInfo *")] JxlExtraChannelInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelName(JxlEncoder* enc, [NativeTypeName("size_t")] nuint index, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] nuint size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderFrameSettingsSetOption(JxlEncoderFrameSettings* frame_settings, JxlEncoderFrameSettingId option, [NativeTypeName("int64_t")] long value);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderFrameSettingsSetFloatOption(JxlEncoderFrameSettings* frame_settings, JxlEncoderFrameSettingId option, float value);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderUseContainer(JxlEncoder* enc, int use_container);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderStoreJPEGMetadata(JxlEncoder* enc, int store_jpeg_metadata);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetCodestreamLevel(JxlEncoder* enc, int level);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int JxlEncoderGetRequiredCodestreamLevel([NativeTypeName("const JxlEncoder *")] JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameLossless(JxlEncoderFrameSettings* frame_settings, int lossless);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameDistance(JxlEncoderFrameSettings* frame_settings, float distance);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelDistance(JxlEncoderFrameSettings* frame_settings, [NativeTypeName("size_t")] nuint index, float distance);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float JxlEncoderDistanceFromQuality(float quality);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderFrameSettings* JxlEncoderFrameSettingsCreate(JxlEncoder* enc, [NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettings* source);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlColorEncodingSetToSRGB(JxlColorEncoding* color_encoding, int is_gray);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlColorEncodingSetToLinearSRGB(JxlColorEncoding* color_encoding, int is_gray);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderAllowExpertOptions(JxlEncoder* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderSetDebugImageCallback(JxlEncoderFrameSettings* frame_settings, [NativeTypeName("JxlDebugImageCallback")] IntPtr callback, void* opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderCollectStats(JxlEncoderFrameSettings* frame_settings, JxlEncoderStats* stats);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStats* JxlEncoderStatsCreate();

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderStatsDestroy(JxlEncoderStats* stats);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint JxlEncoderStatsGet([NativeTypeName("const JxlEncoderStats *")] JxlEncoderStats* stats, JxlEncoderStatsKey key);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderStatsMerge(JxlEncoderStats* stats, [NativeTypeName("const JxlEncoderStats *")] JxlEncoderStats* other);
}
