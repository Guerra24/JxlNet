using System;
using System.Runtime.InteropServices;

namespace JxlNet;

public static unsafe partial class JxlThreads
{
    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, EntryPoint = "JxlResizableParallelRunner", ExactSpelling = true)]
    [return: NativeTypeName("JxlParallelRetCode")]
    public static extern int _JxlResizableParallelRunner(void* runner_opaque, void* jpegxl_opaque, [NativeTypeName("JxlParallelRunInit")] IntPtr init, [NativeTypeName("JxlParallelRunFunction")] IntPtr func, [NativeTypeName("uint32_t")] uint start_range, [NativeTypeName("uint32_t")] uint end_range);

    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* JxlResizableParallelRunnerCreate([NativeTypeName("const JxlMemoryManager *")] JxlMemoryManagerStruct* memory_manager);

    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlResizableParallelRunnerSetThreads(void* runner_opaque, [NativeTypeName("size_t")] UIntPtr num_threads);

    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint JxlResizableParallelRunnerSuggestThreads([NativeTypeName("uint64_t")] ulong xsize, [NativeTypeName("uint64_t")] ulong ysize);

    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlResizableParallelRunnerDestroy(void* runner_opaque);

    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, EntryPoint = "JxlThreadParallelRunner", ExactSpelling = true)]
    [return: NativeTypeName("JxlParallelRetCode")]
    public static extern int _JxlThreadParallelRunner(void* runner_opaque, void* jpegxl_opaque, [NativeTypeName("JxlParallelRunInit")] IntPtr init, [NativeTypeName("JxlParallelRunFunction")] IntPtr func, [NativeTypeName("uint32_t")] uint start_range, [NativeTypeName("uint32_t")] uint end_range);

    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* JxlThreadParallelRunnerCreate([NativeTypeName("const JxlMemoryManager *")] JxlMemoryManagerStruct* memory_manager, [NativeTypeName("size_t")] UIntPtr num_worker_threads);

    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void JxlThreadParallelRunnerDestroy(void* runner_opaque);

    [DllImport("jxl_threads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr JxlThreadParallelRunnerDefaultNumWorkerThreads();
}
