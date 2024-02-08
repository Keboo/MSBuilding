# You many need to make sure nuget.exe is installed first - https://learn.microsoft.com/nuget/install-nuget-client-tools?tabs=windows#nugetexe-cli
nuget.exe pack CustomSdk -Verbosity detailed
# Remove from the NuGet cache to ensure all builds get the latest
Remove-Item "$env:USERPROFILE\.nuget\packages\customsdk" -ErrorAction Ignore -Recurse
