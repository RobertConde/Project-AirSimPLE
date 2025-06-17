setlocal
@echo off
set RUNUAT_BAT="C:\Program Files\Epic Games\UE_5.2\Engine\Build\Batchfiles\RunUAT.bat"
set PROJECT_PATH="%~dp0\AirSimPLE\AirSimPLE.uproject"
@echo on

%RUNUAT_BAT% -nop4 BuildCookRun -clean -project=%PROJECT_PATH% -targetplatform=Win64 -build -cook -skipcookingeditorcontent -compressed -stage -nodebuginfo -package

endlocal
