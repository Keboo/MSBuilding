# MSBuilding
This is a simple learning project showing the capabilities of MSBuild.

## Prerequisites (must available on your PATH)
- [dotnet SDK 8.0](https://dotnet.microsoft.com/download)
- [NuGet CLI](https://www.nuget.org/downloads)

# Compile and run the demos
Before running any of the demos, run the `Build.ps1` script that will compile everything needed. This script assumes that the working directory is the root of the repository.

Alternatively you can compile individual components as described below.

Each Demo contains its own README file with direction for running it as well as points of interest. 

For all of the demo app commands you can attach the `-bl` switch to the end of the command to generate a binary log file. This can be opened and viewed with the tools linked below and is invaluable when debugging the MSBuild process. More details on these log files can be found [here](https://msbuildlog.com/)

Additionally all of the commands can be modified with the verbosity option (`-v` or `--verbosity`) to see more or less output. The allowed values are: q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic].

## Compiling CoderStringConcat
From the root of the repository run `dotnet publish CoderStringConcat`. The .NET 8 SDK will default the configuration of the command to be "Release".

## Compiling the CustomSdk/NuGet package
There is a build script `./NuGet/Build.ps1` that can be used to compile the NuGet package.
Before running this the `CoderStringConcat` solution must be published (see above).
This script will also remove any prior versions of the CustomSdk NuGet package from your NuGet cache. It assumes the default cache location of `$env:USERPROFILE\.nuget`


# Additional Resources
- [MSBuild Docs](https://learn.microsoft.com/visualstudio/msbuild/msbuild?WT.mc_id=DT-MVP-5003472)
- [MSBuild Task Reference](https://learn.microsoft.com/visualstudio/msbuild/msbuild-task-reference?WT.mc_id=DT-MVP-5003472)
- [MSBuild repository](https://github.com/dotnet/msbuild)
- [MSBuildSdks](https://github.com/microsoft/MSBuildSdks)
- [Customize you build](https://learn.microsoft.com/visualstudio/msbuild/customize-your-build?WT.mc_id=DT-MVP-5003472)
- [Customize build by folder](https://learn.microsoft.com/visualstudio/msbuild/customize-by-directory?WT.mc_id=DT-MVP-5003472)

## Tools
- [MSBuild Binary and Structured Log Viewer](https://msbuildlog.com/)
- [Visual Studio - Project System Tools 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.ProjectSystemTools2022)
- [Experimental: MS Build Structured Log Viewer](https://marketplace.visualstudio.com/items?itemName=lambdageek.msbuild-structured-log-viewer)

## Authoring Custom Tasks
- [Writing a custom task](https://learn.microsoft.com/en-us/visualstudio/msbuild/task-writing?WT.mc_id=DT-MVP-5003472)
- [Testing a custom task](https://learn.microsoft.com/visualstudio/msbuild/tutorial-test-custom-task?WT.mc_id=DT-MVP-5003472)