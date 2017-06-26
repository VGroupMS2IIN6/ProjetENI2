Imports System.IO
Imports Microsoft.Win32
Imports System.Windows.Controls
Imports System.Windows.Documents


Class csv01




    Private Sub rtbEditor_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)

    End Sub


    'Filtre pour rechercher les csv plus facilement - stream en reel et appel de windows

    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs) Handles btnOpen.Click

        Dim dlg As OpenFileDialog = New OpenFileDialog
        dlg.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*"
        If (dlg.ShowDialog = True) Then
            Dim fileStream As FileStream = New FileStream(dlg.FileName, FileMode.Open)
            Dim range As TextRange = New TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd)
            range.Load(fileStream, DataFormats.CommaSeparatedValue)

        End If

        ' ou Process.Start("c:\")

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs) Handles btnSave.Click
        Dim dlg As SaveFileDialog = New SaveFileDialog
        dlg.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*"
        If (dlg.ShowDialog = True) Then
            Dim fileStream As FileStream = New FileStream(dlg.FileName, FileMode.Create)
            Dim range As TextRange = New TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd)
            range.Save(fileStream, DataFormats.CommaSeparatedValue)
        End If

    End Sub

    'Bouton Mis en Gras
    Private Sub btnBold_Click(sender As Object, e As RoutedEventArgs)
        Throw New NotImplementedException()
    End Sub

    'Bouton Mis en Italique
    Private Sub btnItalic_Click(sender As Object, e As RoutedEventArgs)
        Throw New NotImplementedException()
    End Sub


    'Bouton souligné
    Private Sub btnUnderline_Click(sender As Object, e As RoutedEventArgs)
        Throw New NotImplementedException()
    End Sub



    Private Sub cmbFontFamily_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub cmbFontSize_TextChanged(sender As Object, e As TextChangedEventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub btnGetText_Click(sender As Object, e As RoutedEventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub btnSetText_Click(sender As Object, e As RoutedEventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub btnGetSelectedText_Click(sender As Object, e As RoutedEventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub btnSetSelectedText_Click(sender As Object, e As RoutedEventArgs)
        Throw New NotImplementedException()
    End Sub
End Class

