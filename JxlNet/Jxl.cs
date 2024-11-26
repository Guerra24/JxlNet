using System;
using System.Runtime.InteropServices;

namespace JxlNet;

public static unsafe partial class Jxl
{
    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint JxlDecoderVersion();

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlSignature JxlSignatureCheck([NativeTypeName("const uint8_t *")] byte* buf, [NativeTypeName("size_t")] UIntPtr len);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("JxlDecoder *")]
    public static extern JxlDecoderStruct* JxlDecoderCreate([NativeTypeName("const JxlMemoryManager *")] JxlMemoryManagerStruct* memory_manager);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderReset([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderDestroy([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderRewind([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderSkipFrames([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("size_t")] UIntPtr amount);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSkipCurrentFrame([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetParallelRunner([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("JxlParallelRunner")] IntPtr parallel_runner, void* parallel_runner_opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr JxlDecoderSizeHintBasicInfo([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSubscribeEvents([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, int events_wanted);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetKeepOrientation([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, int skip_reorientation);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetUnpremultiplyAlpha([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, int unpremul_alpha);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetRenderSpotcolors([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, int render_spotcolors);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetCoalescing([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, int coalescing);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderProcessInput([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetInput([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr JxlDecoderReleaseInput([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlDecoderCloseInput([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetBasicInfo([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, JxlBasicInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetExtraChannelInfo([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("size_t")] UIntPtr index, JxlExtraChannelInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetExtraChannelName([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("size_t")] UIntPtr index, [NativeTypeName("char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetColorAsEncodedProfile([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, JxlColorProfileTarget target, JxlColorEncoding* color_encoding);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetICCProfileSize([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, JxlColorProfileTarget target, [NativeTypeName("size_t *")] UIntPtr* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetColorAsICCProfile([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, JxlColorProfileTarget target, [NativeTypeName("uint8_t *")] byte* icc_profile, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetPreferredColorProfile([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlColorEncoding *")] JxlColorEncoding* color_encoding);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetDesiredIntensityTarget([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, float desired_intensity_target);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetOutputColorProfile([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlColorEncoding *")] JxlColorEncoding* color_encoding, [NativeTypeName("const uint8_t *")] byte* icc_data, [NativeTypeName("size_t")] UIntPtr icc_size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetCms([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, JxlCmsInterface cms);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderPreviewOutBufferSize([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("size_t *")] UIntPtr* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetPreviewOutBuffer([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, void* buffer, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetFrameHeader([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, JxlFrameHeader* header);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetFrameName([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetExtraChannelBlendInfo([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("size_t")] UIntPtr index, JxlBlendInfo* blend_info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderImageOutBufferSize([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("size_t *")] UIntPtr* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetImageOutBuffer([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, void* buffer, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetImageOutCallback([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("JxlImageOutCallback")] IntPtr callback, void* opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetMultithreadedImageOutCallback([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("JxlImageOutInitCallback")] IntPtr init_callback, [NativeTypeName("JxlImageOutRunCallback")] IntPtr run_callback, [NativeTypeName("JxlImageOutDestroyCallback")] IntPtr destroy_callback, void* init_opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderExtraChannelBufferSize([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, [NativeTypeName("size_t *")] UIntPtr* size, [NativeTypeName("uint32_t")] uint index);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetExtraChannelBuffer([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* format, void* buffer, [NativeTypeName("size_t")] UIntPtr size, [NativeTypeName("uint32_t")] uint index);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetJPEGBuffer([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("uint8_t *")] byte* data, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr JxlDecoderReleaseJPEGBuffer([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetBoxBuffer([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("uint8_t *")] byte* data, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr JxlDecoderReleaseBoxBuffer([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetDecompressBoxes([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, int decompress);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetBoxType([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("JxlBoxType")] sbyte* type, int decompressed);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetBoxSizeRaw([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("uint64_t *")] ulong* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderGetBoxSizeContents([NativeTypeName("const JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("uint64_t *")] ulong* size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetProgressiveDetail([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, JxlProgressiveDetail detail);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr JxlDecoderGetIntendedDownsamplingRatio([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderFlushImage([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlDecoderStatus JxlDecoderSetImageOutBitDepth([NativeTypeName("JxlDecoder *")] JxlDecoderStruct* dec, [NativeTypeName("const JxlBitDepth *")] JxlBitDepth* bit_depth);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint JxlEncoderVersion();

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("JxlEncoder *")]
    public static extern JxlEncoderStruct* JxlEncoderCreate([NativeTypeName("const JxlMemoryManager *")] JxlMemoryManagerStruct* memory_manager);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderReset([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderDestroy([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderSetCms([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, JxlCmsInterface cms);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetParallelRunner([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("JxlParallelRunner")] IntPtr parallel_runner, void* parallel_runner_opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderError JxlEncoderGetError([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderProcessOutput([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("uint8_t **")] byte** next_out, [NativeTypeName("size_t *")] UIntPtr* avail_out);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameHeader([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("const JxlFrameHeader *")] JxlFrameHeader* frame_header);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelBlendInfo([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("size_t")] UIntPtr index, [NativeTypeName("const JxlBlendInfo *")] JxlBlendInfo* blend_info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameName([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("const char *")] sbyte* frame_name);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameBitDepth([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("const JxlBitDepth *")] JxlBitDepth* bit_depth);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderAddJPEGFrame([NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("const uint8_t *")] byte* buffer, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderAddImageFrame([NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* pixel_format, [NativeTypeName("const void *")] void* buffer, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetOutputProcessor([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("struct JxlEncoderOutputProcessor")] JxlEncoderOutputProcessor output_processor);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderFlushInput([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderAddChunkedFrame([NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, int is_last_frame, [NativeTypeName("struct JxlChunkedFrameInputSource")] JxlChunkedFrameInputSource chunked_frame_input);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelBuffer([NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("const JxlPixelFormat *")] JxlPixelFormat* pixel_format, [NativeTypeName("const void *")] void* buffer, [NativeTypeName("size_t")] UIntPtr size, [NativeTypeName("uint32_t")] uint index);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderAddBox([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("const JxlBoxType")] sbyte* type, [NativeTypeName("const uint8_t *")] byte* contents, [NativeTypeName("size_t")] UIntPtr size, int compress_box);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderUseBoxes([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderCloseBoxes([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderCloseFrames([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderCloseInput([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetColorEncoding([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("const JxlColorEncoding *")] JxlColorEncoding* color);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetICCProfile([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("const uint8_t *")] byte* icc_profile, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderInitBasicInfo(JxlBasicInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderInitFrameHeader(JxlFrameHeader* frame_header);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderInitBlendInfo(JxlBlendInfo* blend_info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetBasicInfo([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("const JxlBasicInfo *")] JxlBasicInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetUpsamplingMode([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("int64_t")] long factor, [NativeTypeName("int64_t")] long mode);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderInitExtraChannelInfo(JxlExtraChannelType type, JxlExtraChannelInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelInfo([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("size_t")] UIntPtr index, [NativeTypeName("const JxlExtraChannelInfo *")] JxlExtraChannelInfo* info);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelName([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("size_t")] UIntPtr index, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr size);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderFrameSettingsSetOption([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, JxlEncoderFrameSettingId option, [NativeTypeName("int64_t")] long value);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderFrameSettingsSetFloatOption([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, JxlEncoderFrameSettingId option, float value);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderUseContainer([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, int use_container);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderStoreJPEGMetadata([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, int store_jpeg_metadata);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetCodestreamLevel([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, int level);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int JxlEncoderGetRequiredCodestreamLevel([NativeTypeName("const JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameLossless([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, int lossless);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetFrameDistance([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, float distance);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern JxlEncoderStatus JxlEncoderSetExtraChannelDistance([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("size_t")] UIntPtr index, float distance);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float JxlEncoderDistanceFromQuality(float quality);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("JxlEncoderFrameSettings *")]
    public static extern JxlEncoderFrameSettingsStruct* JxlEncoderFrameSettingsCreate([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc, [NativeTypeName("const JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* source);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlColorEncodingSetToSRGB(JxlColorEncoding* color_encoding, int is_gray);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlColorEncodingSetToLinearSRGB(JxlColorEncoding* color_encoding, int is_gray);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderAllowExpertOptions([NativeTypeName("JxlEncoder *")] JxlEncoderStruct* enc);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderSetDebugImageCallback([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("JxlDebugImageCallback")] IntPtr callback, void* opaque);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderCollectStats([NativeTypeName("JxlEncoderFrameSettings *")] JxlEncoderFrameSettingsStruct* frame_settings, [NativeTypeName("JxlEncoderStats *")] JxlEncoderStatsStruct* stats);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const JxlCmsInterface *")]
    public static extern JxlCmsInterface* JxlGetDefaultCms();

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("JxlEncoderStats *")]
    public static extern JxlEncoderStatsStruct* JxlEncoderStatsCreate();

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderStatsDestroy([NativeTypeName("JxlEncoderStats *")] JxlEncoderStatsStruct* stats);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr JxlEncoderStatsGet([NativeTypeName("const JxlEncoderStats *")] JxlEncoderStatsStruct* stats, JxlEncoderStatsKey key);

    [DllImport("jxl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlEncoderStatsMerge([NativeTypeName("JxlEncoderStats *")] JxlEncoderStatsStruct* stats, [NativeTypeName("const JxlEncoderStats *")] JxlEncoderStatsStruct* other);
}
