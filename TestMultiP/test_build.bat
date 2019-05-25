@echo off
set MYBUILD=BUILDNUGET
msbuild.exe TestMultiP.csproj  /t:restore,rebuild "/p:Platform=AnyCPU"