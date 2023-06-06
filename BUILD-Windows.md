# Build on Windows Notes
* Clone recursive
```
git clone --recursive https://github.com/nietras/CNTK
```
>* Download CUDA Toolkit 10.0 and install (don't install driver since old!)
>  https://developer.nvidia.com/cuda-10.0-download-archive?target_os=Windows&target_arch=x86_64&target_version=10&target_type=exenetwork
* Download CUDA Toolkit 10.2 plus patches and install (don't install driver since old!)
  https://developer.nvidia.com/cuda-10.2-download-archive?target_os=Windows&target_arch=x86_64&target_version=10&target_type=exenetwork
* To support VS2019 fix `C:\git\oss\CNTK\Tools\devInstall\Windows\helper\Operations.ps1` 
  * `OpCheckVS2017` => `OpCheckVS2019`
* Run `C:\git\oss\CNTK\Tools\devInstall\Windows\DevInstall.ps1`
```
                                                                                                                                                                                                                                                                                                                                                                        This script will setup the CNTK Development Environment on your machine.                                                                                                            More help is given by calling get-help .\devInstall.ps1                                                                                                                                                                                                                                                                                                                 The script will analyse your machine and will determine which components are required.                                                                                              The required components will be downloaded into [c:\installCacheCntk]                                                                                                               Repeated operation of this script will reuse already downloaded components.                                                                                                                                                                                                                                                                                             
1 - I agree and want to continue
Q - Quit the installation process

1
Determining Operations to perform. This will take a moment...
Scan System for installed programs
Checking for Visual Studio 2019
Checking for NVidia Cuda 10.0
Checking for NVidia CUDNN 7.3.1 for CUDA 10.0 in c:\local\cudnn-10.0-v7.3.1
Checking for NVidia CUB 1.8.0 in c:\local\cub-1.8.0
Checking for CMake 3.6.2 in C:\Program Files\cmake\bin
Checking for installed MSMPI 70
Checking for installed MSMPI 70 SDK
Checking for Boost 1.60.0 in c:\local\boost_1_60_0-msvc-14.0
Checking for MKLML and MKL-DNN 0.12 CNTK Prebuild in c:\local\mklml-mkldnn-0.12
Checking for SWIG 3.0.10 in c:\local\swigwin-3.0.10
Checking for ProtoBuf 3.1.0 Source in c:\local\src\protobuf-3.1.0
Checking for ProtoBuf 3.1.0 VS17 CNTK Prebuild in c:\local\protobuf-3.1.0-vs17
Checking for zlib / libzip from source in c:\local\src
Checking for ZLib VS17 CNTK Prebuild in c:\local\zlib-vs17
Checking for OpenCV-3.1 in c:\local\Opencv3.1.0
Checking for Anaconda3-4.1.1 in c:\local\Anaconda3-4.1.1-Windows-x86_64
Checking for Python 35 Environment in c:\local\Anaconda3-4.1.1-Windows-x86_64
Checking pre-requisites finished


The following operations will be performed:
 * Installing NVidia CUDNN 7.3.1 for CUDA 10.0
 * Installing NVidia CUB 1.8.0
 * Installing CMake 3.6.2
 * Installing MSMPI 70
 * Installing MSMPI 70 SDK
 * Installing Boost 1.60.0
 * Installing MKLML and MKL-DNN 0.12 CNTK Prebuild
 * Installing SWIG 3.0.10
 * Installing ProtoBuf 3.1.0 Source
 * Installing ProtoBuf 3.1.0 VS17 CNTK Prebuild
 * Installing zlib / libzip from source
 * Installing ZLib VS17 CNTK Prebuild
 * Installing OpenCV-3.1
 * Installing Anaconda3-4.1.1
 * Creating Python 35 Environment

Do you want to continue? (y/n)
y
Performing download operations
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/cudnn/7.3.1/cudnn-10.0-windows10-x64-v7.3.1.20.zip], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/cub/1.8.0/cub-1.8.0.zip], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/cmake/3.6.2/cmake-3.6.2-win64-x64.msi], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/msmpi/70/MSMpiSetup.exe], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/msmpisdk/70/msmpisdk.msi], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/boost/1.60.0/boost_1_60_0-msvc-14.0-64.exe], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/mkl-dnn/0.12/mklml-mkldnn-0.12.zip], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/swig/3.0.10/swigwin-3.0.10.zip], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/protobuf/3.1.0/protobuf-3.1.0.zip], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/protobuf/3.1.0/protobuf-3.1.0-vs17.zip], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/zlib/1.2.8/zlib128.zip], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/libzip/1.1.3/libzip-1.1.3.tar.gz], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/zlib/vs17/zlib-vs17.zip], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/opencv/3.1.0/opencv-3.1.0.exe], please be patient....
Downloading [https://cntkbuildstorage.blob.core.windows.net/cntk-ci-dependencies/anaconda3/4.1.1/Anaconda3-4.1.1-Windows-x86_64.exe], please be patient....
Download operations finished

Performing install operations
Installing NVidia CUDNN 7.3.1 for CUDA 10.0
Installing NVidia CUB 1.8.0
Installing CMake 3.6.2
Installing MSMPI 70
Installing MSMPI 70 SDK
Installing Boost 1.60.0
Installing MKLML and MKL-DNN 0.12 CNTK Prebuild
Installing SWIG 3.0.10
Installing ProtoBuf 3.1.0 Source
Installing ProtoBuf 3.1.0 VS17 CNTK Prebuild
Installing zlib / libzip from source
Installing ZLib VS17 CNTK Prebuild
Installing OpenCV-3.1
Installing Anaconda3-4.1.1
.... This will take some time. Please be patient ....
Creating Python 35 Environment
Exception caught - function main / failure
System.Management.Automation.RuntimeException: Running [start-process  env create --file "C:\git\oss\CNTK\scripts\install\windows\conda-windows-cntk-py35-environment.yml" --prefix c:\local\Anaconda3-4.1.1-Windows-x86_64\envs\cntk-py35] failed with exit code [1]
```
* Visual Studio Installer
  * **Windows 10 SDK (10.0.16299.0)**
  * **MSVC v141  VS 2017 C++ x64/86 build tools (v14.16)**
* Set Environment Variables
```
setx CNTK_ENABLE_ASGD false
setx MKL_PATH c:\local\mklml-mkldnn-0.12
setx BOOST_INCLUDE_PATH c:\local\boost_1_60_0-msvc-14.0
setx BOOST_LIB_PATH c:\local\boost_1_60_0-msvc-14.0\lib64-msvc-14.0
setx PROTOBUF_PATH c:\local\protobuf-3.1.0-vs17
setx CUDNN_PATH c:\local\cudnn-10.0-v7.3.1\cuda
setx OPENCV_PATH_V31 c:\local\Opencv3.1.0\build
setx ZLIB_PATH c:\local\zlib-vs17
setx CUB_PATH c:\local\cub-1.8.0\
setx SWIG_PATH C:\local\swigwin-3.0.10
```
* Restart the shell afterwards or use `set` not `setx`
* Follow https://docs.microsoft.com/en-us/cognitive-toolkit/setup-cntk-with-script-on-windows
* Then https://docs.microsoft.com/en-us/cognitive-toolkit/setup-cntk-on-windows#building-cntk

# CUDA 10.2 - First step to see if can build
Focus on building `Common` project first.


`CUDA_PATH_V10_2` and related are pre-defined environment variables.

Fix warning treated as error in `GPUMatrix.cu`, `GPUSparseMatrix.cu`, `GPUTensor.cu` by inserting:
```
#pragma warning(disable : 4324) // 'thrust::detail::aligned_type<2>::type': structure was padded due to alignment
```
at the top of the file.

See https://github.com/nietras/CNTK/pull/1/files

# Add SWIG Generated C++ and C#
See https://github.com/nietras/CNTK/pull/3/files

# Define new nuget packages
* Searching for `*.nuspec` only shows the following files:
```
CNTK\bindings\csharp\CNTKLibraryManagedDll\obj\Debug\Cntk.Core.Managed-d.2.7.0.nuspec
CNTK\bindings\csharp\CNTKLibraryManagedDll\obj\Release\Cntk.Core.Managed.2.7.0.nuspec
CNTK\bindings\csharp\CNTKLibraryManagedDll\obj\Release_CpuOnly\Cntk.Core.Managed.2.7.0.nuspec
CNTK\Source\Multiverso\binding\C#\NuGet\MultiversoCLR.nuspec
CNTK\Source\CNTKv2LibraryDll\proto\onnx\onnxruntime\cmake\external\protobuf\csharp\Google.Protobuf.Tools.nuspec
CNTK\Source\CNTKv2LibraryDll\proto\onnx\onnxruntime\tools\nuget\template.nuspec
```
Hence, only `Cntk.Core.Managed` appears present here, but the project itself
defines the package, so one can just `pack` the `CNTKLibraryManagedDll` project.
But what about the other projects then? Could not find any nuspec or similar for this,
so recreating from the official packages on nuget.

[https://www.nuget.org/packages?q=Cntk](https://www.nuget.org/packages?q=Cntk)

Hence downloading the following packages and unzipping them:

https://www.nuget.org/packages/CNTK.GPU/2.8.0-rc0.dev20200201
https://www.nuget.org/packages/CNTK.Deps.cuDNN/2.8.0-rc0.dev20200201
https://www.nuget.org/packages/CNTK.Deps.Cuda/2.8.0-rc0.dev20200201
https://www.nuget.org/packages/CNTK.Deps.MKL/2.8.0-rc0.dev20200201
https://www.nuget.org/packages/CNTK.Deps.OpenCV.Zip/2.8.0-rc0.dev20200201


For `CNTK.GPU` package copy contents of:
```
C:\git\oss\CNTK\Source\CNTKv2LibraryDll\API
```
to
```
C:\git\oss\CNTK\PackageSpecs\nietras.cntk.gpu\build\native\include
```
Then copy binary files to the different packages from:
```
C:\git\oss\CNTK\x64\Release
```

TODO: Create a script for this.

Then created packages in `PackageSpecs` based on the above downloaded
packages, unzipping them and then manually modifying them to match
the latest version.


# CUDA 11 - Modifications to support Ampere GPUs
https://github.com/microsoft/CNTK/issues/3835

## Look at changes in other repo for reference
https://github.com/haryngod/CNTK/tree/2.7-cuda-11.1

## Downloads
* CUDA 11.4 https://developer.download.nvidia.com/compute/cuda/11.4.0/network_installers/cuda_11.4.0_win10_network.exe
* cuDNN 8.2.2 https://developer.nvidia.com/compute/machine-learning/cudnn/secure/8.2.2/11.4_07062021/cudnn-11.4-windows-x64-v8.2.2.26.zip (need login)
* OpenCV 4.5.3 https://sourceforge.net/projects/opencvlibrary/files/4.5.3/opencv-4.5.3-vc14_vc15.exe/download 

# Update Environment Variables
```
setx CNTK_ENABLE_ASGD false
setx MKL_PATH c:\local\mklml-mkldnn-0.12
setx BOOST_INCLUDE_PATH c:\local\boost_1_60_0-msvc-14.0
setx BOOST_LIB_PATH c:\local\boost_1_60_0-msvc-14.0\lib64-msvc-14.0
setx PROTOBUF_PATH c:\local\protobuf-3.1.0-vs17
setx CUDNN_PATH C:\local\cudnn-11.4-windows-x64-v8.2.2.26\cuda
setx OPENCV_PATH_V31 c:\local\Opencv3.1.0\build
setx ZLIB_PATH c:\local\zlib-vs17
setx CUB_PATH "C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.4"
setx SWIG_PATH C:\local\swigwin-3.0.10
```
Note that `CUB` is part of CUDA now.

IMPORTANT: Remember to restart your shell/powershell window after, then check variables e.g. via:
```
gci env:
```

## 11.1
Change some environment variables.
```
setx CUB_PATH "C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.1"
```
Some warnings with 11.1.1 due to deprecated methods, disabling the warnings in `fpgeneric.h`.

Release then builds, but Debug does not. Don't care about Debug so moving on.

## 11.4
Change some environment variables.
```
setx CUB_PATH "C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.4"
setx CUDA_PATH "C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.4"
```
Last one is due to installing CUDA 11.1 after installing 11.4 and hence the 
environment variables got overwritten.

Probably best to simply reinstall CUDA 11.4 to be sure everything defined correctly.

This fails spectacularly with a lot of errors when trying to compile `MathCUDA`project in `CNTK.sln`.

Most of these appear to be yet another step from CUDA in instantiating templates,
so more overloads are needed in `MathCUDA`. Fixed these one by one.

Additionally, a ton of warnings specifically due to some of the template 
instantiations being for integer types, and a lot of the code assumes floating points,
so lots of warnings around truncations or similar. Did not fix these, just
disabled treating warnings as errors.

Most of Debug configuration now builds again.

# CUDA 11.8 - Modifications to support Ada Lovelace 40-series GPUs

## Modifications
 * Try using Visual Studio 2022 to build CNTK as of 11.4 first
 * Install MSVC++ v141 x86/x64 build tools via Visual Studio Installer
 * Appears CUDA 11.4 is not integrated with VS 2022 as `CUDA 11.4.props` are missing.
 * Try reinstalling CUDA 11.4
 * Apparently only CUDA 11.6+ works with 2022 see
   https://quasar.ugent.be/files/doc/cuda-msvc-compatibility.html
 * Try using latest CUDA 11.x instead, skipping 12.x since likely breaking
   changes. Must restart VS and shells after so 
   `CUDA_PATH_V11_8=C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8` 
   is set.
 * Replace 11.4/11_4 with 11.8/11_8 in all files that appears relevant.

## Downloads
* CUDA 11.8 https://developer.download.nvidia.com/compute/cuda/11.8.0/network_installers/cuda_11.8.0_windows_network.exe 
* cuDNN 8.9.1.23 https://developer.nvidia.com/downloads/compute/cudnn/secure/8.9.1/local_installers/11.8/cudnn-windows-x86_64-8.9.1.23_cuda11-archive.zip/ (need login),
  extract to `c:\local` as given in environment variables below.

# Update Environment Variables
```
setx CNTK_ENABLE_ASGD false
setx MKL_PATH c:\local\mklml-mkldnn-0.12
setx BOOST_INCLUDE_PATH c:\local\boost_1_60_0-msvc-14.0
setx BOOST_LIB_PATH c:\local\boost_1_60_0-msvc-14.0\lib64-msvc-14.0
setx PROTOBUF_PATH c:\local\protobuf-3.1.0-vs17  // NOTE REPLACED BY VCPKG VERSION LATER
setx CUDNN_PATH C:\local\cudnn-windows-x86_64-8.9.1.23_cuda11-archive
setx OPENCV_PATH_V31 c:\local\Opencv3.1.0\build
setx ZLIB_PATH c:\local\zlib-vs17
setx CUDA_PATH "C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8"
setx CUB_PATH "C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8"
setx SWIG_PATH C:\local\swigwin-3.0.10
```
Note that `CUB` is part of CUDA now.

IMPORTANT: Remember to restart your shell/powershell window after, then check variables e.g. via:
```
gci env:
```

## Visual Studio Issues
Several issues encountered in Visual Studio which simply says there are issues
with configurations. No indication of what or where. To resolve had to "Unload
Project" for some projects that appeared to have issues like
`CNTKLibraryCSEvalExamplesTest.standard.csproj`. Also simply removed `AnyCPU`
from configuration and only focusing on `Release` + `x64`.

## Build Issues
First errors appear in `MatchCUDA` project in particular in `GPUSparseMatrix.cu`:
```
1>C:\git\oss\CNTK\Source\Math>"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\bin\nvcc.exe" -gencode=arch=compute_61,code=\"sm_61,compute_61\" -gencode=arch=compute_75,code=\"sm_75,compute_75\" -gencode=arch=compute_80,code=\"sm_80,compute_80\" -gencode=arch=compute_86,code=\"sm_86,compute_86\" -gencode=arch=compute_90,code=\"sm_90,compute_90\" --use-local-env -ccbin "C:\Program Files\Microsoft Visual Studio\2022\Preview\VC\Tools\MSVC\14.16.27023\bin\HostX64\x64" -x cu   -IC:\git\oss\CNTK\Source\Common\include -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8" -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\include" -I"C:\local\cudnn-windows-x86_64-8.9.1.23_cuda11-archive\include" -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\include"   -lineinfo  --keep-dir C:\git\oss\CNTK\x64\.build\Release\Source\Math\\MathCUDA -use_fast_math -maxrregcount=0  --machine 64 --compile -cudart static -Xcudafe "--diag_suppress=field_without_dll_interface" -Xcompiler "/wd 4819"   -DNO_SYNC -DWIN32 -D_WINDOWS -D_USRDLL -DMATH_EXPORTS -DUSE_CUDNN -D_UNICODE -DUNICODE -DNDEBUG -D"CNTK_VERSION=\"2.8.2\"" -D"CNTK_VERSION_BANNER=\"2.8.2\"" -D"CNTK_COMPONENT_VERSION=\"2.8.2\"" -DHAS_MPI=1 -DCUDA_NO_HALF -D__CUDA_NO_HALF_OPERATORS__ -Xcompiler "/EHsc /W4 /nologo /O2 /FdC:\git\oss\CNTK\x64\.build\Release\Source\Math\\MathCUDA\MathCUDA.pdb /FS   /MD " -o C:\git\oss\CNTK\x64\.build\Release\Source\Math\MathCUDA\GPUSparseMatrix.cu.obj "C:\git\oss\CNTK\Source\Math\GPUSparseMatrix.cu"
1>c:\program files\nvidia gpu computing toolkit\cuda\v11.8\include\cub\util_cpp_dialect.cuh:129: warning: CUB requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define CUB_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\thrust/detail/config/cpp_dialect.h:118: warning: Thrust requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define THRUST_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>c:\program files\nvidia gpu computing toolkit\cuda\v11.8\include\cub\util_cpp_dialect.cuh:129: warning: CUB requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define CUB_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\thrust/detail/config/cpp_dialect.h:118: warning: Thrust requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define THRUST_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>c:\program files\nvidia gpu computing toolkit\cuda\v11.8\include\cub\util_cpp_dialect.cuh:129: warning: CUB requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define CUB_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\thrust/detail/config/cpp_dialect.h:118: warning: Thrust requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define THRUST_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>c:\program files\nvidia gpu computing toolkit\cuda\v11.8\include\cub\util_cpp_dialect.cuh:129: warning: CUB requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define CUB_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\thrust/detail/config/cpp_dialect.h:118: warning: Thrust requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define THRUST_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>c:\program files\nvidia gpu computing toolkit\cuda\v11.8\include\cub\util_cpp_dialect.cuh:129: warning: CUB requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define CUB_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\thrust/detail/config/cpp_dialect.h:118: warning: Thrust requires at least MSVC 2019 (19.20/16.0/14.20). MSVC 2017 is deprecated but still supported. MSVC 2017 support will be removed in a future release. Define THRUST_IGNORE_DEPRECATED_CPP_DIALECT to suppress this message.
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\cub/device/dispatch/dispatch_segmented_sort.cuh(338): error : invalid combination of type specifiers
1>
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\cub/device/dispatch/dispatch_segmented_sort.cuh(338): error : expected an identifier
1>
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\cub/device/dispatch/dispatch_segmented_sort.cuh(379): error : expected a member name
1>
1>3 errors detected in the compilation of "C:/git/oss/CNTK/Source/Math/GPUSparseMatrix.cu".
1>GPUSparseMatrix.cu
1>C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Microsoft\VC\v170\BuildCustomizations\CUDA 11.8.targets(785,9): error MSB3721: The command ""C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\bin\nvcc.exe" -gencode=arch=compute_61,code=\"sm_61,compute_61\" -gencode=arch=compute_75,code=\"sm_75,compute_75\" -gencode=arch=compute_80,code=\"sm_80,compute_80\" -gencode=arch=compute_86,code=\"sm_86,compute_86\" -gencode=arch=compute_90,code=\"sm_90,compute_90\" --use-local-env -ccbin "C:\Program Files\Microsoft Visual Studio\2022\Preview\VC\Tools\MSVC\14.16.27023\bin\HostX64\x64" -x cu   -IC:\git\oss\CNTK\Source\Common\include -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8" -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\include" -I"C:\local\cudnn-windows-x86_64-8.9.1.23_cuda11-archive\include" -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\include"   -lineinfo  --keep-dir C:\git\oss\CNTK\x64\.build\Release\Source\Math\\MathCUDA -use_fast_math -maxrregcount=0  --machine 64 --compile -cudart static -Xcudafe "--diag_suppress=field_without_dll_interface" -Xcompiler "/wd 4819"   -DNO_SYNC -DWIN32 -D_WINDOWS -D_USRDLL -DMATH_EXPORTS -DUSE_CUDNN -D_UNICODE -DUNICODE -DNDEBUG -D"CNTK_VERSION=\"2.8.2\"" -D"CNTK_VERSION_BANNER=\"2.8.2\"" -D"CNTK_COMPONENT_VERSION=\"2.8.2\"" -DHAS_MPI=1 -DCUDA_NO_HALF -D__CUDA_NO_HALF_OPERATORS__ -Xcompiler "/EHsc /W4 /nologo /O2 /FdC:\git\oss\CNTK\x64\.build\Release\Source\Math\\MathCUDA\MathCUDA.pdb /FS   /MD " -o C:\git\oss\CNTK\x64\.build\Release\Source\Math\MathCUDA\GPUSparseMatrix.cu.obj "C:\git\oss\CNTK\Source\Math\GPUSparseMatrix.cu"" exited with code 2.
```
Ignoring warnings first and trying to figure out the error. Googled and found:
https://forums.developer.nvidia.com/t/cub-1-5-fails-to-build-when-windows-h-was-previously-included/210367
Hence, the issue appears to relate to CUB version and a bug in that, and thus the warnings appear relevant.
So first trying to define those preprocessor constants, first in the top of the file `GPUSparseMatrix.cu`:
```cpp
#define CUB_IGNORE_DEPRECATED_CPP_DIALECT
#define THRUST_IGNORE_DEPRECATED_CPP_DIALECT
```
This did not solve it, and as it is claimed this bug is fixed in CUDA 11.8 this
might be due to MSVC++ version, so trying to update that which is the
`PlatformToolset` defined in `CNTK.Cpp.props`, set this to `v143`. Also search
for `v141` and replace where relevant e.g.
`<PlatformToolset>v141</PlatformToolset>`.

Reload solution, then try building just `GPUSparseMatrix.cu` again.
Unfortunately, this fails but know without the warnings:
```
1>Compiling CUDA source file GPUSparseMatrix.cu...
1>
1>C:\git\oss\CNTK\Source\Math>"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\bin\nvcc.exe" -gencode=arch=compute_61,code=\"sm_61,compute_61\" -gencode=arch=compute_75,code=\"sm_75,compute_75\" -gencode=arch=compute_80,code=\"sm_80,compute_80\" -gencode=arch=compute_86,code=\"sm_86,compute_86\" -gencode=arch=compute_90,code=\"sm_90,compute_90\" --use-local-env -ccbin "C:\Program Files\Microsoft Visual Studio\2022\Preview\VC\Tools\MSVC\14.37.32705\bin\HostX64\x64" -x cu   -IC:\git\oss\CNTK\Source\Common\include -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8" -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\include" -I"C:\local\cudnn-windows-x86_64-8.9.1.23_cuda11-archive\include" -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\include"   -lineinfo  --keep-dir C:\git\oss\CNTK\x64\.build\Release\Source\Math\\MathCUDA -use_fast_math -maxrregcount=0  --machine 64 --compile -cudart static -Xcudafe "--diag_suppress=field_without_dll_interface" -Xcompiler "/wd 4819"   -DNO_SYNC -DWIN32 -D_WINDOWS -D_USRDLL -DMATH_EXPORTS -DUSE_CUDNN -D_UNICODE -DUNICODE -DNDEBUG -D"CNTK_VERSION=\"2.8.2\"" -D"CNTK_VERSION_BANNER=\"2.8.2\"" -D"CNTK_COMPONENT_VERSION=\"2.8.2\"" -DHAS_MPI=1 -DCUDA_NO_HALF -D__CUDA_NO_HALF_OPERATORS__ -Xcompiler "/EHsc /W4 /nologo /O2 /FdC:\git\oss\CNTK\x64\Release\Cntk.Math.Cuda-2.8.2.pdb /FS   /MD " -o C:\git\oss\CNTK\x64\.build\Release\Source\Math\MathCUDA\GPUSparseMatrix.cu.obj "C:\git\oss\CNTK\Source\Math\GPUSparseMatrix.cu"
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\cub/device/dispatch/dispatch_segmented_sort.cuh(338): error : invalid combination of type specifiers
1>
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\cub/device/dispatch/dispatch_segmented_sort.cuh(338): error : expected an identifier
1>
1>C:/Program Files/NVIDIA GPU Computing Toolkit/CUDA/v11.8/include\cub/device/dispatch/dispatch_segmented_sort.cuh(379): error : expected a member name
1>
1>3 errors detected in the compilation of "C:/git/oss/CNTK/Source/Math/GPUSparseMatrix.cu".
1>GPUSparseMatrix.cu
1>C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Microsoft\VC\v170\BuildCustomizations\CUDA 11.8.targets(785,9): error MSB3721: The command ""C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\bin\nvcc.exe" -gencode=arch=compute_61,code=\"sm_61,compute_61\" -gencode=arch=compute_75,code=\"sm_75,compute_75\" -gencode=arch=compute_80,code=\"sm_80,compute_80\" -gencode=arch=compute_86,code=\"sm_86,compute_86\" -gencode=arch=compute_90,code=\"sm_90,compute_90\" --use-local-env -ccbin "C:\Program Files\Microsoft Visual Studio\2022\Preview\VC\Tools\MSVC\14.37.32705\bin\HostX64\x64" -x cu   -IC:\git\oss\CNTK\Source\Common\include -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8" -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\include" -I"C:\local\cudnn-windows-x86_64-8.9.1.23_cuda11-archive\include" -I"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.8\include"   -lineinfo  --keep-dir C:\git\oss\CNTK\x64\.build\Release\Source\Math\\MathCUDA -use_fast_math -maxrregcount=0  --machine 64 --compile -cudart static -Xcudafe "--diag_suppress=field_without_dll_interface" -Xcompiler "/wd 4819"   -DNO_SYNC -DWIN32 -D_WINDOWS -D_USRDLL -DMATH_EXPORTS -DUSE_CUDNN -D_UNICODE -DUNICODE -DNDEBUG -D"CNTK_VERSION=\"2.8.2\"" -D"CNTK_VERSION_BANNER=\"2.8.2\"" -D"CNTK_COMPONENT_VERSION=\"2.8.2\"" -DHAS_MPI=1 -DCUDA_NO_HALF -D__CUDA_NO_HALF_OPERATORS__ -Xcompiler "/EHsc /W4 /nologo /O2 /FdC:\git\oss\CNTK\x64\Release\Cntk.Math.Cuda-2.8.2.pdb /FS   /MD " -o C:\git\oss\CNTK\x64\.build\Release\Source\Math\MathCUDA\GPUSparseMatrix.cu.obj "C:\git\oss\CNTK\Source\Math\GPUSparseMatrix.cu"" exited with code 2.
```
The github issue ["Fix segmented sort compilation in case of
windows.h"](https://github.com/NVIDIA/cub/pull/423) says this is fixed in CUB
1.16.0 but that this isn't available in CUDA until 12.x... it also says the
issue is related to `windows.h` inclusion. Based on this looking at
`stdafx.h` which defines:
```cpp
#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN // Exclude rarely-used stuff from Windows headers
#define NOMINMAX
#include "Windows.h"
#endif
```
so then adding the following at top of `GPUSparseMatrix.cu`:
```cpp
#include "stdafx.h"
```
this resolves build errors in that file and the `MathCUDA` project, but then
other projects fail with miscellaneuous errors, some of these are warnings
treated as errors, those warnings will then be disabled.

Then there are issues with protobuf:
```
1>------ Build started: Project: CNTKv2LibraryDll, Configuration: Release x64 ------
1>Serialization.cpp
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\hash.h(245,50): error C2143: syntax error: missing ',' before '<'
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\hash.h(246,2): message : see reference to class template instantiation 'google::protobuf::hash<Key>' being compiled
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\hash.h(259,14): error C2039: 'hash_compare': is not a member of 'std'
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\common.h(88,11): message : see declaration of 'std'
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\hash.h(259,14): error C2504: 'hash_compare': base class undefined
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\hash.h(259,42): error C2143: syntax error: missing ',' before '<'
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\hash.h(404,29): error C2064: term does not evaluate to a function taking 1 arguments
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\hash.h(245,22): error C2039: 'hash_compare': is not a member of 'std'
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\common.h(88,11): message : see declaration of 'std'
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\map.h(1728,48): message : see reference to class template instantiation 'google::protobuf::hash<google::protobuf::int64>' being compiled
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\stubs\hash.h(245,22): error C2504: 'hash_compare': base class undefined
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\map.h(1728,48): error C2064: term does not evaluate to a function taking 1 arguments
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\map.h(1730,48): error C2064: term does not evaluate to a function taking 1 arguments
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\map.h(1732,49): error C2064: term does not evaluate to a function taking 1 arguments
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\map.h(1734,49): error C2064: term does not evaluate to a function taking 1 arguments
1>c:\local\protobuf-3.1.0-vs17\include\google\protobuf\map.h(1736,26): error C2064: term does not evaluate to a function taking 1 arguments
1>Done building project "CNTKv2LibraryDll.vcxproj" -- FAILED.
```
This is an old version so not sure how to resolve. Try to use `vcpkg` for this.
First install via Visual Studio Installer. Then use:
```
C:\git\oss\cntk\vcpkg install protobuf protobuf:x64-windows
```
```
C:\git\oss\cntk\vcpkg integrate project
```
 * Go to Tools->NuGet Package Manager->Package Manager Console
 * Select CNTKv2LibraryDll in Default project
* Then paste: `Install-Package "vcpkg.C.ProgramFiles.MicrosoftVisualStudio.2022.Preview.VC.vcpkg" -Source "C:\git\oss\CNTK"`
* Did not appear to work as thought, so instead hacked changes to
  `CNTK.Cpp.props` to point to new protobuf.
* Then used `generate-proto-code.ps1` to generate cpp code for proto files given
  protobuf library updated.
* Fix miscelleneous errors by hacking source code.
* Add Save overload that takes ModelFormat to FunctionShim (hopefully we no
  longer need python part for this then).
* Finally, the project appears to build, albeit with version 2.8.2.
* Due to vcpkg defaulting to linking to dynamic library, this means CNTK dlls
  have dependency on libprotobuf.dll, to fix this have to change vcpkg
  properties for CNTKv2LibraryDll to `Use Static Libraries=Yes` and `Use Dynamic
  CRT=Yes`.
* Trying to run tests in a library and this fails, figure need to update NVidia
  dlls incl. `nvml.dll` and new dependency to `zlibwapi.dll` from `C:\Program
  Files\Microsoft Office\root\Office16\ODBC Drivers\Salesforce\lib`. 
* Still fails... some kind of issue with
  `nvmlDeviceGetComputeRunningProcesses_v3` definition in `nvml.dll`, this is
  from latest 535 driver version, so not sure what is wrong.
* Appears some issue with still referring to CUDA 11.4 due to environment variable,
* and some issues in `BestGpu.cpp` that hopefully resolved now.