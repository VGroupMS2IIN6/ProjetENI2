

Class MenuAdmin01


    Public fenetread2 As New MenuAdmin02
    Public NavigationService As New AccueilAdmin


    Private Sub button201_Click(sender As Object, e As RoutedEventArgs) Handles button201.Click
        'Boutton Active Directory
        Hide()
        fenetread2.Show()
    End Sub

    Private Sub button202_Click(sender As Object, e As RoutedEventArgs) Handles button202.Click
        'Boutton Plateformes

    End Sub

    Private Sub button203_Click(sender As Object, e As RoutedEventArgs) Handles button203.Click
        'Boutton Définition des profils

    End Sub

    Private Sub button204_Click(sender As Object, e As RoutedEventArgs) Handles button204.Click
        'Boutton assignation des profils

    End Sub


    Private Sub Button205_Click(sender As Object, e As RoutedEventArgs) Handles Button205.Click

        Me.NavigationService.Navigate(New Uri("01AcceuilAdmin.xaml", UriKind.Relative))

    End Sub






End Class
