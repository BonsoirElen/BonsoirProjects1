@echo off
chcp 1251

cd ".."
%MYNET_PATH%\csc.exe -target:exe -out:"���������������.exe" -define:DEBUG *.cs
pause
