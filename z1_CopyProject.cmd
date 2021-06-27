@echo off

if not %OldProject%.==. goto Start

set     OldProject=e05_Parse_Many_Nested_Profiles
set     NewProject=e06_Get_Many_Values_From_A_Single_Key

:Start
if not exist %OldProject%\*.* goto EOF
if not exist %NewProject%\*.* goto Continue

echo.
echo First, please remove the "%NewProject%" folder.
pause
goto EOF


:Continue
xcopy /s/e %OldProject% %NewProject%\

cd %NewProject%

:: Replace old with new names (within files).
ReplaceText.exe -OldText="%OldProject%" -NewText="%NewProject%" -Files=Properties\*.* -Files=Resources\*.* -Files=*.aspx -Files=*.cmd -Files=*.cs -Files=*.csproj -Files="*.csproj (4.x)" -Files=*.md -Files=*.ndoc -Files=*.resx -Files=*.sql -Files=*.txt -Files=*.vbproj -Files=*.vb -Files=*.xaml  -SaveProfile=False -DisplayResults=False -SearchOnly=False

:: Replace old with new names (within folder names).
dir /ad/b | findstr "%OldProject%" > %~n0RenameFilelist.cmd
ReplaceText.exe -Files=%~n0RenameFilelist.cmd -OldText="^(.*)%OldProject%(.*)$" -NewText="ren \q$1%OldProject%$2\q \q$1%NewProject%$2\q" -OldText=\r\q -NewText=\q -OldText=\n -NewText=\r\n -UseRegularExpressions -UseSpecialCharacters -RegexOptions=2 -SaveProfile=False -DisplayResults=False -SearchOnly=False
call %~n0RenameFilelist.cmd

:: Replace old with new names (within filenames).
dir /s/b | findstr "%OldProject%\." > %~n0RenameFilelist.cmd
ReplaceText.exe -Files=%~n0RenameFilelist.cmd -OldText="^(.*)\\\\(.*)%OldProject%\.(.*?)$" -NewText="ren \q$1\\$2%OldProject%.$3\q \q$2%NewProject%.$3\q" -OldText=\r\q -NewText=\q -OldText=\n -NewText=\r\n -UseRegularExpressions -UseSpecialCharacters -RegexOptions=2 -SaveProfile=False -DisplayResults=False -SearchOnly=False
call %~n0RenameFilelist.cmd

del  %~n0RenameFilelist.cmd
del /s %NewProject%.user
del /s %NewProject%.suo

rd /s/q bin
rd /s/q obj

cd..
