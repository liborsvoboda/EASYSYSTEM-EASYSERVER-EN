@ECHO OFF
wmic process where CommandLine='"dotnet"  EASYDATACenter.dll' get ProcessId > dotnetPID.txt

