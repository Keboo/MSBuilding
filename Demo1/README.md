# Demo 1 - Custom Project
This demo starts with showing a custom project that will be compiled with MSBuild. The compilation is simulated by concatenating the names inside of *.coder files

## Running
Execute:
```cli
dotnet build
```

## Points of interest
The primary purpose of this first example is to familiarize yourself with the [basic MSBuild concepts](https://learn.microsoft.com/visualstudio/msbuild/msbuild-concepts?WT.mc_id=DT-MVP-5003472) namely [Properties](https://learn.microsoft.com/visualstudio/msbuild/msbuild-properties?WT.mc_id=DT-MVP-5003472), [Items](https://learn.microsoft.com/visualstudio/msbuild/msbuild-items?WT.mc_id=DT-MVP-5003472), [Tasks](https://learn.microsoft.com/visualstudio/msbuild/msbuild-tasks?WT.mc_id=DT-MVP-5003472), and [Targets](https://learn.microsoft.com/visualstudio/msbuild/msbuild-targets).

The `CompileCoders` target, demonstrates [batching](https://learn.microsoft.com/visualstudio/msbuild/msbuild-batching?WT.mc_id=DT-MVP-5003472 ) by iterating through all of the items in the Coders set and reading the lines into another set of Items. The target then transforms this set into multiple command-line options (similar to: `--coders "Kevin" --coders "Heather"`).

Though the sample can be executed with `dotnet build` it is also possible to directly invoke a single target with the `-t` option. In this example it skip the Message task for displaying "Starting build". 
```cli
dotnet build -t:CompileCoders
```
