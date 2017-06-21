Class mdpadmin

    Public fenetread1 As New MenuAdmin01

    Private Sub btnmdp_Click(sender As Object, e As RoutedEventArgs) Handles btnmdp.Click

        'Ceci est une condition qui fais appels aux propriété des Box pour gérer la connexions
        If TextBox.TextProperty.Equals("admin") Then

        ElseIf PasswordBox.Password.Equals("test") = True Then
            Hide()
            fenetread1.Show()

        Else
            MessageBox.Show("FAIL")
            'Hide()
            'Faire un go Back
        End If



    End Sub
End Class


' ex : process.start("c:\)
