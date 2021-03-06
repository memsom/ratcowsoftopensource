@echo off
echo CAUTION: this will delete the file already created
pause

echo building file(s)

echo AbstractMainFormController.cs
.\tools\mvctool -a MainForm
del .\Controllers\AbstractControllers\AbstractMainFormController.cs
copy .\AbstractMainFormController.cs .\Controllers\AbstractControllers
rem Yes, should be using "move" but can easily disable this line
del .\AbstractMainFormController.cs
echo Built AbstractMainFormController.cs



echo AbstractInfoFormController.cs
.\tools\mvctool -a InfoForm
del .\Controllers\AbstractControllers\AbstractInfoFormController.cs
copy .\AbstractInfoFormController.cs .\Controllers\AbstractControllers
rem Yes, should be using "move" but can easily disable this line
del .\AbstractInfoFormController.cs
echo Built AbstractInfoFormController.cs




echo cleaning up
del temp.dll

echo DONE!
pause