Option Strict On
Option Explicit On

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim menu As New MenuMaker() With {.randomizer = New Random}

        label1.Text = menu.GetMenuItem()
        label2.Text = menu.GetMenuItem()
        label3.Text = menu.GetMenuItem()
        label4.Text = menu.GetMenuItem()
        label5.Text = menu.GetMenuItem()
        label6.Text = menu.GetMenuItem()
    End Sub
End Class
