


Class csv01



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

    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click

        Dim dlg As New Microsoft.Win32.OpenFileDialog()
        dlg.Filter = "CommaSeparatedValue|*.csv"
        dlg.Title = "Select a Cursor File"

        ' Show the Dialog.  
        ' If the user clicked OK in the dialog and   
        ' a .CUR file was selected, open it.  
        If dlg.ShowDialog() = Forms.DialogResult.OK Then
            ' Assign the cursor in the Stream to the Form's Cursor property.  
            Me.Cursor = New Cursor(dlg.OpenFile)
        End If

        ' OU 
        ' If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        'Dim sr As New System.IO.StreamReader(dlg.FileName)
        'MessageBox.Show(sr.ReadToEnd)
        'SR.Close()
        'End If


    End Sub



    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs) Handles btnSave.Click
        'Dim dlg As Microsoft.Win32.SaveFileDialog = New Microsoft.Win32.SaveFileDialog
        'dlg.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*"
        'If (dlg.ShowDialog = True) Then
        ' Dim fileStream As FileStream = New FileStream(dlg.FileName, FileMode.Create)
        '  Dim range As TextRange = New TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd)
        '   range.Save(fileStream, Windows.DataFormats.CommaSeparatedValue)
        'End If

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

