@echo off

set TOKEN=5309086930:AAEtHYYPnOFpM0A6tdPFWxSn0jAVhEpvwcU

py %~dp0teleg_bot.py

call %~dp0venv\Scripts\activate

cd %~dp0

pause