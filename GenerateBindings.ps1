[CmdletBinding()]
Param(
  [Parameter(Mandatory=$true, Position=0)]
  [string]$include
)

$vsPath = &"${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" -property installationpath
Import-Module (Join-Path $vsPath "Common7\Tools\Microsoft.VisualStudio.DevShell.dll")
Enter-VsDevShell -VsInstallPath $vsPath -SkipAutomaticLocation

ClangSharpPInvokeGenerator `
-c compatible-codegen generate-file-scoped-namespaces multi-file generate-helper-types `
-F $include `
-I $include `
-f jxl\decode.h `
-f jxl\encode.h `
-f jxl\memory_manager.h `
-f jxl\types.h `
-f jxl\codestream_header.h `
-f jxl\cms.h `
-f jxl\cms_interface.h `
-f jxl\color_encoding.h `
-f jxl\stats.h `
-n JxlNet `
-m Jxl `
-l jxl `
-o .\JXLNet\

ClangSharpPInvokeGenerator `
-c compatible-codegen generate-file-scoped-namespaces multi-file generate-helper-types `
-F $include `
-I $include `
-f jxl\parallel_runner.h `
-f jxl\resizable_parallel_runner.h `
-f jxl\thread_parallel_runner.h `
-r JxlThreadParallelRunner=_JxlThreadParallelRunner JxlResizableParallelRunner=_JxlResizableParallelRunner `
-n JxlNet `
-m JxlThreads `
-l jxl_threads `
-o .\JXLNet\
