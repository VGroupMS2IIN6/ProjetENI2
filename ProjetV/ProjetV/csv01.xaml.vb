Imports System.IO
Imports Microsoft.Win32


Class csv01

    '       Public Sub New()
    '       MyBase.New
    '       InitializeComponent
    '       cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(() >= {}, f.Source)
    '       cmbFontSize.ItemsSource = New List(Of Double)
    '   End Sub

    'Private Sub rtbEditor_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
    'Dim temp As Object = Editor.Selection.GetPropertyValue(Inline.FontWeightProperty)
    '   btnBold.IsChecked = ((temp <> DependencyProperty.UnsetValue) _
    '              AndAlso temp.Equals(FontWeights.Bold))
    ' temp = Editor.Selection.GetPropertyValue(Inline.FontStyleProperty)
    'btnItalic.IsChecked = ((temp <> DependencyProperty.UnsetValue) _
    '           AndAlso temp.Equals(FontStyles.Italic))
    'temp = Editor.Selection.GetPropertyValue(Inline.TextDecorationsProperty)
    'btnUnderline.IsChecked = ((temp <> DependencyProperty.UnsetValue) _
    '           AndAlso temp.Equals(TextDecorations.Underline))
    'temp = Editor.Selection.GetPropertyValue(Inline.FontFamilyProperty)
    'cmbFontFamily.SelectedItem = temp
    'temp = Editor.Selection.GetPropertyValue(Inline.FontSizeProperty)
    'cmbFontSize.Text = temp.ToString
    'End Sub
    'Filtre pour rechercher les csv plus facilement - stream en reel et appel de windows

    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs) Handles btnOpen.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog
        dlg.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*"
        If (dlg.ShowDialog = True) Then
            Dim fileStream As FileStream = New FileStream(dlg.FileName, FileMode.Open)
            Dim range As TextRange = New TextRange(Editor.Document.ContentStart, Editor.Document.ContentEnd)
            range.Load(fileStream, DataFormats.CommaSeparatedValue)
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs) Handles btnSave.Click
        Dim dlg As SaveFileDialog = New SaveFileDialog
        dlg.Filter = "Rich Text Format (*.csv)|*.csv|All files (*.*)|*.*"
        If (dlg.ShowDialog = True) Then
            Dim fileStream As FileStream = New FileStream(dlg.FileName, FileMode.Create)
            Dim range As TextRange = New TextRange(Editor.Document.ContentStart, Editor.Document.ContentEnd)
            range.Save(fileStream, DataFormats.CommaSeparatedValue)
        End If

    End Sub

    'Private Sub cmbFontFamily_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
    'If (Not (cmbFontFamily.SelectedItem) Is Nothing) Then
    'Editor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem)
    'End If

    '  End Sub

    'Private Sub cmbFontSize_TextChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
    'Editor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text)
    'End Sub


End Class

