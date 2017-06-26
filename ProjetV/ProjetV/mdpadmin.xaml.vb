

Class mdpadmin

    Public accueil As New AccueilAdmin

    Private Sub btnmdp_Click(sender As Object, e As RoutedEventArgs) Handles btnmdp.Click

        'Ceci est une condition qui fais appels aux propriété des Box pour gérer la connexions
        If TextBox.TextProperty.Equals("admin") Then

        ElseIf PasswordBox.Password.Equals("password") = True Then
            Hide()
            accueil.Show()

        Else
            MessageBox.Show("FAIL")
            'Hide()
            'Faire un go Back
        End If



    End Sub
End Class



