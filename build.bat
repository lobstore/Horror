@echo off
echo Build Start...
set projectpath="."
set buildpath=".\target\Horror.exe"
set logpath=".\buildlogs\logs.log"
Unity -quit -batchmode -projectpath %projectpath% -buildWindowsPlayer %buildpath% -logFile %logpath%
type ".\buildlogs\logs.log"
echo Build Complete!
pause