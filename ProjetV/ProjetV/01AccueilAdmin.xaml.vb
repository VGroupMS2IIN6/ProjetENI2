Class AccueilAdmin


    Public fenetreabout As New AboutBox1
    Public fenetread1 As New MenuAdmin01


    Public Sub Button06_Click(sender As Object, e As RoutedEventArgs) Handles Button06.Click

        'MessageBox.Show("")
        Hide()
        fenetread1.Show()

    End Sub

    Private Sub button07_Click(sender As Object, e As RoutedEventArgs) Handles button07.Click

        '------------------------------------------------------------------------------------
        '---------------------------------------------A PROPOS----------------------------------

        MessageBox.Show("")
        fenetreabout.Show()

    End Sub



End Class


