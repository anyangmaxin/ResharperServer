@echo off
%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\installutil.exe %~dp0\ResharperServerService.exe
echo currentpath:%~dp0
pause