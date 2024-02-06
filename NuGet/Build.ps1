nuget.exe pack CustomSdk -Verbosity detailed
# Remove from the NuGet cache to ensure all builds get the latest
Remove-Item "$env:USERPROFILE\.nuget\packages\customsdk" -ErrorAction Ignore -Recurse