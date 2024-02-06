# Demo 3 - SDKs
This demo takes the example project forward to using MSBuild SDK NuGet packages.
Some common examples of these can been seen in the [MSBuildSdks repository](https://github.com/microsoft/MSBuildSdks)
That repository also outline [what is an SDK project](https://github.com/microsoft/MSBuildSdks?tab=readme-ov-file#what-are-msbuild-sdks).

## Running
Execute:
```cli
dotnet build
```
Cleanup:
```cli
dotnet clean
```

## Points of interest
For this the SDK NuGet package is compiled from the `../NuGet` directory.

The SDK is referenced in the first line of the project file: `<Project Sdk="CustomSdk/1.0.0">`.

We are able to reference this SDK as a NuGet package, because the `nuget.config` in the root of the repository adds an addtional [NuGet source](https://learn.microsoft.com/nuget/reference/nuget-config-file?WT.mc_id=DT-MVP-5003472#package-source-sections) using a local folder. This folder is also the default output directory where the compiled NuGet package (*.nupkg) is placed. 

Within `NuGet/CustomSdk/Sdk` you will find the props/targets files. 

The targets filenow uses a [custom MSBuild task](https://learn.microsoft.com/visualstudio/msbuild/tutorial-custom-task-code-generation?WT.mc_id=DT-MVP-5003472) rather than invoking the CSC CLI as was previously done.

The props file show conditionally setting the `LoggingVerbosity` property. If left un-set it will default to high. However you can change this by specifying the desired value on the command line.

```cli
dotnet build -p:LoggingVerbosity=high
```

