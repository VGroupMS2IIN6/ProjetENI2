Class mdpadmin

    Public fenetread1 As New MenuAdmin01

    Private Sub btnmdp_Click(sender As Object, e As RoutedEventArgs) Handles btnmdp.Click
        If PasswordBox.TextInputEvent.Equals("admin") Then
            Hide()
            fenetread1.Show()
        Else
            MessageBox.Show("FAIL")
        End If

    End Sub
End Class


' ex : process.start("c:\)
