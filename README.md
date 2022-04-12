# MSBuilding

## Prerequisites (must available on your PATH)
- [dotnet SDK](https://dotnet.microsoft.com/download); Alternatively MSBuild comes installed with [Visual Studio](https://visualstudio.microsoft.com/downloads/), or the [Build Tools for Visual Studio](https://visualstudio.microsoft.com/downloads/?q=build+tools)
- [NuGet CLI](https://www.nuget.org/downloads)

## Resources
- [MSBuild Docs](https://docs.microsoft.com/visualstudio/msbuild/msbuild)
- [MSBuildSdks](https://github.com/microsoft/MSBuildSdks)
- [MSBuild Binary and Structured Log Viewer](https://msbuildlog.com/)

## Build the CSC (CanSomeoneCode) tool
This tool is a simple stand in for any bigger tool (such as the C# csc.exe compiler).
```ps
PS> dotnet publish -c Release .\CanSomeoneCode\CanSomeoneCode.sln
```

## Build Custom SDK
Compile custom SDK by running the following from the root of the repository. This command can be run as changes are made to the SDK and will blow away the cahced copy in the local NuGet cache each time it is built. 
```ps
PS> rm ~\.nuget\packages\customsdk -Recurse -ErrorAction Ignore; nuget pack .\NuGet\CustomSdk\ -OutputDirectory .\NuGet\
```

## Build Custom Project
Compile the custom project by running from the root of the repository. The `-bl` switch will generate a `msbuild.binlog` file to diagnose the results.
```ps
dotnet build CustomProject -bl
```