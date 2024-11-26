[CmdletBinding()]
Param(
  [Parameter(Mandatory=$true, Position=0)]
  [ValidateSet('x64-windows','arm64-windows')]
  [string]$triplet,
  [Parameter(Mandatory=$true, Position=1)]
  [string]$libjxl
)

if ($triplet -eq "x64-windows") {
	$arch="x64"
} else {
	$arch="ARM64"
}

$ErrorActionPreference = "Stop"

$currentDirectory = Get-Location

$vsPath = &"${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" -property installationpath
Import-Module (Join-Path $vsPath "Common7\Tools\Microsoft.VisualStudio.DevShell.dll")
Enter-VsDevShell -VsInstallPath $vsPath -SkipAutomaticLocation -DevCmdArguments "-arch=$($arch.ToLower())"

cd $libjxl
cmake `
-B"build-$triplet" `
-A $arch `
-DCMAKE_CXX_FLAGS="/MP /EHsc" `
-DCMAKE_C_FLAGS="/MP" `
-DBUILD_TESTING=OFF `
-DCMAKE_BUILD_TYPE=Release `
-DJPEGXL_STATIC=OFF `
-DJPEGXL_ENABLE_TOOLS=OFF `
-DJPEGXL_ENABLE_JPEGLI_LIBJPEG=OFF `
-DJPEGXL_ENABLE_OPENEXR=OFF `
-DJPEGXL_ENABLE_PLUGINS=OFF `
-DJPEGXL_ENABLE_TCMALLOC=OFF `
-DJPEGXL_ENABLE_VIEWERS=OFF `
-DJPEGXL_ENABLE_DEVTOOLS=OFF `
-DJPEGXL_ENABLE_JNI=OFF `
-DVCPKG_TARGET_TRIPLET=$triplet

cmake --build "build-$triplet" --config Release

cd $currentDirectory
