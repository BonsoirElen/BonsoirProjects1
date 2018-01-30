@echo off
chcp 1251

cd ".."
%MYNET_PATH%\csc.exe -target:exe -out:"БонсуарГородки.exe" -define:DEBUG *.cs
pause
