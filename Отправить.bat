@echo off
chcp 1251

set /p MyMsg1="Enter Message: "

git pull

git add -A
git commit -m "%MyMsg1%"
git push
