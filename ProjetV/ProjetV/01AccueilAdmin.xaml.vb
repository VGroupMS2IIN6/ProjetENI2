Class AccueilAdmin


    Public fenetreabout As New AboutBox1
    Public fenetremdp As New mdpadmin
    Public fenetrecsv As New csv01


    Private Sub Button06_Click(sender As Object, e As RoutedEventArgs) Handles Button06.Click


        Hide()
        fenetremdp.Show()

    End Sub

    Private Sub button07_Click(sender As Object, e As RoutedEventArgs) Handles button07.Click

        '------------------------------------------------------------------------------------
        '---------------------------------------------A PROPOS----------------------------------

        MessageBox.Show("")
        fenetreabout.Show()

    End Sub

    Private Sub Button01_Click(sender As Object, e As RoutedEventArgs) Handles Button01.Click
        Hide()
        fenetrecsv.Show()
    End Sub
End Class


