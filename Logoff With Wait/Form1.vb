Public Class Form1
    Dim boolSlashes As Boolean = True
    'MessageBox.Show(My.Computer.Info.OSFullName)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If boolSlashes Then
            'MessageBox.Show("shutdown /l /f")
            Shell("shutdown /l /f")
        Else
            'MessageBox.Show("shutdown -l -f")
            Shell("shutdown -l -f")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
