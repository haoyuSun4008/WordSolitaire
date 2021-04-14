@echo off
setlocal EnableDelayedExpansion
echo ****************************************************
echo ***    This Batch Processes every .xlsx file     ***
echo ***       To rename their name as lib.xlsx       ***
echo ***       Developed By HaoyuSun On 20210326      ***
echo ****************************************************

pause

for /r .\ %%i in (*.xlsx) do (
    rem echo %%~dpi
    set newname=lib.xlsx
    set abspath= %%~dpi!newname!
    rem echo !abspath!
    rem suppress over-written promoting
    copy /Y %%i !abspath!
    rem del /q %%i
)

pause