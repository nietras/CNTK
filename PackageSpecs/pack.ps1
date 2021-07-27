dotnet pack -c Release  /p:Platform=x64 "..\bindings\csharp\CNTKLibraryManagedDll\CNTKLibraryManagedDll.csproj" -o ./
./nuget.exe pack nietras.CNTK.GPU/nietras.CNTK.GPU.nuspec
./nuget.exe pack nietras.CNTK.Deps.Cuda/nietras.CNTK.Deps.Cuda.nuspec
./nuget.exe pack nietras.CNTK.Deps.MKL/nietras.CNTK.Deps.MKL.nuspec
./nuget.exe pack nietras.CNTK.Deps.OpenCV.Zip/nietras.CNTK.Deps.OpenCV.Zip.nuspec
./nuget.exe pack nietras.CNTK.Deps.cuDNN/nietras.CNTK.Deps.cuDNN.nuspecd
