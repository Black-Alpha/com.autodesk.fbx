# FbxSharp Project : FBX SDK C# bindings

## Requirements

* [FBX SDK](http://www.autodesk.com/products/fbx/overview) 2016.0 or 2017.1
* [cmake](https://cmake.org/download/) 3.7.2
* [swig](http://www.swig.org/download.html) 3.0.12
* [NUNIT](http://www.nunit.org/) 3.x
* [Python](https://www.python.org/downloads/) 2.7.x or 3.x
* Windows: [Visual Studio Community 2015](https://www.visualstudio.com/downloads/)
* Ubuntu: ???
* OSX: [Xcode](https://developer.apple.com/xcode/features/) 7.3 with command-line tools installed

Newer versions of each software likely also work, except for the FBX SDK. To support newer (or older) versions of FBX SDK, you need to edit the FindFBXSDK.cmake file.

## Installing from source

First, get the requirements above. Then:
```
git clone https://github.com/Unity-Technologies/FbxSharp.git
```
This project uses git submodules. After cloning you need to enter the FbxSharp directory and do:
```
git submodule update --init --recursive
```
If you are developing FbxSharp, you will need to re-issue that command whenever submodules are updated. See e.g.
https://gist.github.com/gitaarik/8735255


Copy-paste to begin developing for OSX or linux:
```
# get the source
git clone https://github.com/Unity-Technologies/FbxSharp.git
pushd FbxSharp
git submodule update --init --recursive
popd

# build the project
mkdir FbxSharpBuild
cd FbxSharpBuild
cmake ../FbxSharp
make && make install

# run the sample Unity code
BUILD_PATH=`pwd`
if test `uname -s` = 'Darwin' ; then
  UNITY3D_PATH=/Applications/Unity/Unity.app/Contents/MacOS
else
  UNITY3D_PATH=/opt/Unity/Editor/Unity
fi
LD_LIBRARY_PATH=$LD_LIBRARY_PATH:${BUILD_PATH}/tests/UnityTests/Assets/Plugins/fbxsdk MONO_LOG_MASK=dll ${UNITY3D_PATH}/Unity -projectpath ${BUILD_PATH}/tests/UnityTests
```

Copy-paste to begin developing for Windows:
```
# get the source
git clone https://github.com/Unity-Technologies/FbxSharp.git
pushd FbxSharp
git submodule update --init --recursive
popd

# build the project
mkdir FbxSharpBuild
cd FbxSharpBuild
cmake ../FbxSharp -G"Visual Studio 14 2015 Win64"
cmake --build . --target INSTALL --config Release

# run the sample Unity code
"C:/Program Files/Unity/Editor/Unity.exe" -projectpath %cd%/tests/UnityTests
```

To build a release version, give `cmake` the `-DCMAKE_BUILD_TYPE=Release` flag.

## Overview

**Writing C# code**
```
// Using FbxSdk Assembly

using FbxSdk;

// global functions found in FbxSdk.Globals
var a = FbxSdk.Globals.FbxGetDataTypeNameForIO(b);

var sdkManager = FbxManager.Create();

sdkManager.Destroy();
```

**What gets installed into your Unity Project**
```
{unity_project}/Assets/Plugins/
    fbxsdk/
        libfbxsdk_csharp.so
        csharp/
               FbxManager.cs
               ...
```               

## How to do out-of-source build

### Building on OSX and Linux
```
# Define where the FBX SDK source is, and where you want to do your build.
export FBXSDK_CSHARP_PATH=~/Development/FbxSharp
mkdir FbxSharpBuild
cd FbxSharpBuild

cmake $FBXSDK_CSHARP_PATH
make 
make install
```

### Building on Windows 
```
REM Win10
mkdir FbxSharpBuild
cd FbxSharpBuild

cmake %FBXSDK_CSHARP_PATH -G"Visual Studio 14 2015 Win64" -DCMAKE_BUILD_TYPE=Release
cmake --build . --target INSTALL --config Release
```

Note: For out of source builds the entire Unity project at test/UnityTests will be copied over.

### Running UnitTests

**Requires** [Unity 5.6+](https://store.unity.com/)

**OSX**
```
export FBXSDK_CSHARP_PATH=~/Development/FbxSharp
export UNITY3D_PATH=/Applications/Unity
export FBXSDK_PATH=/Applications/Autodesk/FBX\ SDK/2017.1

# finding fbxsdk_csharp linked against fbxsdk dynamic library
DYLD_LIBRARY_PATH=$DYLD_LIBRARY_PATH:${BUILD_PATH}/tests/UnityTests/Assets/Plugins/fbxsdk:${FBXSDK_PATH}/lib/clang/release MONO_LOG_MASK=dll ${UNITY3D_PATH}/Unity.app/Contents/MacOS/Unity -projectpath ${BUILD_PATH}/tests/UnityTests

# finding fbxsdk_csharp linked against fbxsdk static library
LD_LIBRARY_PATH=$LD_LIBRARY_PATH:${BUILD_PATH}/tests/UnityTests/Assets/Plugins/fbxsdk MONO_LOG_MASK=dll ${UNITY3D_PATH}/Unity.app/Contents/MacOS/Unity -projectpath ${BUILD_PATH}/tests/UnityTests
```

OR ```make tests``` with makefile generated by cmake

**Ubuntu**

```
export FBXSDK_CSHARP_PATH=~/Development/FbxSharp
export UNITY3D_PATH=/opt/Unity/Editor/Unity

LD_LIBRARY_PATH=$LD_LIBRARY_PATH:${BUILD_PATH}/tests/UnityTests/Assets/Plugins/fbxsdk MONO_LOG_MASK=dll ${UNITY3D_PATH}/Unity -projectpath ${BUILD_PATH}/tests/UnityTests
```

OR ```make tests``` with makefile generated by cmake cmake

**Windows**

```
${UNITY3D_PATH}/Unity.exe -projectpath ${FBXSDK_CSHARP_PATH}/tests/UnityTests
```

OR ```cmake --build . --target RUN_TESTS```
