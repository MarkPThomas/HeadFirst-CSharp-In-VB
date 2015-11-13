Option Strict On
Option Explicit On

Public Class AnotherClass

    '' To have the starting point change to here: 
    ''      1. Right-Click the project name.
    ''      2. Click "Properties".
    ''      3. Change "Application Type" from "Windows Forms Application" to "Console Application".
    ''      4. Set "Startup Object" to "Sub Main", which should be visible after step 3.
    '' To switch back:
    ''      1. Right-Click the project name. 
    ''      2. Click "Properties".
    ''      3. Change "Application Type" from "Console Application" to "Windows Forms Application".
    ''      4. Set "Startup Form" to "Form1", which should be visible after step 3.

    Public Shared Sub Main()
        MessageBox.Show("Pow!")
    End Sub

End Class
