Class AccueilAdmin



    Public menuadmin As New MenuAdmin01
    Public fenetrecsv As New csv01
    Public AboutBox As New AboutBox1


    Private Sub Button06_Click(sender As Object, e As RoutedEventArgs) Handles Button06.Click


        Hide()
        menuadmin.Show()

    End Sub

    Private Sub button07_Click(sender As Object, e As RoutedEventArgs) Handles button07.Click

        '------------------------------------------------------------------------------------
        '---------------------------------------------A PROPOS----------------------------------

        AboutBox.Show()


    End Sub

    Private Sub Button01_Click(sender As Object, e As RoutedEventArgs) Handles Button01.Click

        Hide()
        fenetrecsv.Show()

    End Sub
End Class


