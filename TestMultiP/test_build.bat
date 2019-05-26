@echo off
rem set MYBUILD=BUILDNUGET
rem msbuild.exe TestMultiP.csproj  /t:restore,rebuild "/p:Platform=AnyCPU"
msbuild.exe TestMultiP.csproj  /t:restore,rebuild "/p:Platform=AnyCPU" /p:MyBuildProp=BuildNuget