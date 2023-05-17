@ECHO OFF

SET VALUE=%~1
rem GOTO:%~1

IF NOT DEFINED VALUE (
	ECHO Bad Argument : %1
	ECHO USE ARGUMENT: INSTALL OR UNINSTALL OR START OR STOP
	PAUSE
	GOTO:EOF
) ELSE (

IF "%1"=="INSTALL" GOTO:%~1
IF "%1"=="START" GOTO:%~1
IF "%1"=="STOP" GOTO:%~1
IF "%1"=="UNINSTALL" GOTO:%~1

ECHO Bad Argument : %1
ECHO USE ARGUMENT: INSTALL OR UNINSTALL OR START OR STOP
PAUSE
GOTO:EOF
)


:INSTALL
REM INSTALL COMMAND
REM installutil.exe EASYDATACenterWS.exe
SET ACTPATH=%~dp0EASYDATACenterWS.exe
echo %ACTPATH%
sc.exe create EASYDATACenterWS binpath= %ACTPATH% type= share start= auto
REM PAUSE
GOTO FOR_ALL

:START
REM INSTALL COMMAND
net start EASYDATACenterWS
REM PAUSE
GOTO FOR_ALL

:STOP
REM INSTALL COMMAND
net stop EASYDATACenterWS
REM PAUSE
GOTO FOR_ALL

:UNINSTALL
REM UNINSTALL COMMAND
REM installutil.exe /u EASYDATACenterWS.exe
sc.exe delete EASYDATACenterWS
REM PAUSE
GOTO FOR_ALL



:FOR_ALL
REM INFO FOR ALL