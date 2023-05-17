<a name='assembly'></a>
# EASY-SYSTEM-Builder & EASY-DATA-Center & Visual Studio Help

---
## Create Linux service and control for BACKEND
* Service Files are on Debian in folder: /lib/systemd/system
* add this code to 'PropertyGroup'
```
create file: dotnet-Project-service.service
```
---
## How to Create/Control LINUX service
* command list
```
systemctl enable dotnet-TABackend-service.service
systemctl start dotnet-TABackend-service.service
systemctl status dotnet-TABackend-service.service
systemctl stop dotnet-TABackend-service.service
```
---
## Linux Run project dll command
* command list
```
dotnet application.dll
```
---
## WINDOWS OS HELP & TIPS
* Install Backend 'EXE' file as Windows service by SC/InstalUtil/ utility
* Windows Service utilities and Service control from command Line examples are in 'WinServiceUtilities' folder

---