Option Strict On
Option Explicit On

Class MainWindow
    Private Sub changeText_Click(sender As Object, e As RoutedEventArgs)
        If enableCheckBox.IsChecked Then
            If labelToChange.Text = "Right" Then
                labelToChange.Text = "Left"
                labelToChange.HorizontalAlignment = HorizontalAlignment.Left
            Else
                labelToChange.Text = "Right"
                labelToChange.HorizontalAlignment = HorizontalAlignment.Right
            End If
        Else
            labelToChange.Text = "Text changing is disabled"
            labelToChange.HorizontalAlignment = HorizontalAlignment.Center
        End If
    End Sub

End Class
