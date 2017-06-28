
Imports System.IO


Public Class csv01



    Private Sub rtbEditor_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)

        'Dim temp As Object = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty)
        'btnBold.IsChecked = ((temp <> DependencyProperty.UnsetValue) _
        'AndAlso temp.Equals(FontWeights.Bold))
        ' temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty)
        '  btnItalic.IsChecked = ((temp <> DependencyProperty.UnsetValue) _
        '             AndAlso temp.Equals(FontStyles.Italic))
        ' temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty)
        'btnUnderline.IsChecked = ((temp <> DependencyProperty.UnsetValue) _
        '         AndAlso temp.Equals(TextDecorations.Underline))
        'temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty)
        'cmbFontFamily.SelectedItem = temp
        'temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty)
        'cmbFontSize.Text = temp.ToString


    End Sub


    'Filtre pour rechercher les csv plus facilement - stream en reel et appel de windows

    Public Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click


        ' Configure open file dialog box
        Dim dlg As New Microsoft.Win32.OpenFileDialog()


        dlg.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*"
        dlg.InitialDirectory = "C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\csv"


        Dim result As Boolean = dlg.ShowDialog()

        If (dlg.ShowDialog = True) Then
            File.Open("C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\csv\test", FileMode.Open, FileAccess.ReadWrite)
        End If
    End Sub





    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs) Handles btnSave.Click



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




End Class

