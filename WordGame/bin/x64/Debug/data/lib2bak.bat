@echo off
setlocal EnableDelayedExpansion
echo ****************************************************
echo ***  This Batch Processes every lib.xlsx file    ***
echo ***       To rename their name as lib.bak        ***
echo ***       Developed By HaoyuSun On 20210331      ***
echo ****************************************************

for /r .\ %%i in (lib.xlsx) do (
    rem echo %%~dpi
    rem echo %%i
    rem set newname=lib.bak
    rem set abspath= %%~dpi!newname!
    rem echo !abspath!
    rem copy %%i !abspath!
    del /p %%i
)

pause