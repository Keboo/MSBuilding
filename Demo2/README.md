# Demo 1 - Custom Project
This demo expands on the use of target and dependencies to provide more performant [incremental builds](https://learn.microsoft.com/visualstudio/msbuild/how-to-build-incrementally?WT.mc_id=DT-MVP-5003472) and ordering of targets.

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
The most important concept in this demo is the [target ordering](https://learn.microsoft.com/visualstudio/msbuild/target-build-order?WT.mc_id=DT-MVP-5003472) that occurs by setting the BeforeTargets/AfterTargets attributes. In addtion, take note of the `DefaultTargets` and `InitialTargets` specified on the root Project element.

You may notice that when running `dotnet build` you see the output "Initialized CSC" twice. This is because the default behavior of `dotnet build` is to first call the "Restore" target, then call the "Build" target. If you wish to disable the first call, you can append `--no-build` to the `dotnet build` command.

The other key concept is the incremental build that is done using the the Inputs and Outputs on the Build target. These enable [incremental builds](https://learn.microsoft.com/visualstudio/msbuild/how-to-build-incrementally?WT.mc_id=DT-MVP-5003472). If you run `dotnet build` twice you will notice that the build target is only called the first time. If you make a change to one of the coder files, or the output file and re-run `dotnet build` it will then trigger the task to run.

Finally, this example introduces the Clean target. This is another default target that dotnet will try to invoke when you run the `dotnet clean` command. This target simply cleans up our output directory ("/bin/*")