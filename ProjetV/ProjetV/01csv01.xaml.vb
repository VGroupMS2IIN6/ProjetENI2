Imports System.Linq
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports Microsoft.Win32
Imports System.Windows.Controls





'Private Sub btnCreateFile_Click(sender As Object, e As RoutedEventArgs)


'End Sub

'Public Sub btnOpenFile_Click(sender As Object, e As RoutedEventArgs)
'Process.Start("c:\")

'End Sub

'Private Sub btnRetour_Click(sender As Object, e As RoutedEventArgs)

'End Sub



Namespace WpfTutorialSamples.Rich_text_controls
    Public Class RichTextEditorSample
        Inherits Window

        Public Property cmbFontFamily As Object
        Public Property cmbFontSize As Object
        Public Property rtbEditor As Object
        Public Property btnBold As Object
        Public Property btnItalic As Object
        Public Property btnUnderline As Object

        Public Sub New()
            InitializeComponent()
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(Function(f) f.Source)
            cmbFontSize.ItemsSource = New List(Of Double)() From {
                8,
                9,
                10,
                11,
                12,
                14,
                16,
                18,
                20,
                22,
                24,
                26,
                28,
                36,
                48,
                72
            }
        End Sub

        Private Sub InitializeComponent()
            Throw New NotImplementedException()
        End Sub

        Private Sub rtbEditor_SelectionChanged(sender As Object, e As RoutedEventArgs)
            Dim temp As Object = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty)
            btnBold.IsChecked = (temp <> DependencyProperty.UnsetValue) AndAlso (temp.Equals(FontWeights.Bold))
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty)
            btnItalic.IsChecked = (temp <> DependencyProperty.UnsetValue) AndAlso (temp.Equals(FontStyles.Italic))
            temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty)
            btnUnderline.IsChecked = (temp <> DependencyProperty.UnsetValue) AndAlso (temp.Equals(TextDecorations.Underline))

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty)
            cmbFontFamily.SelectedItem = temp
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty)
            cmbFontSize.Text = temp.ToString()
        End Sub

        Private Sub Open_Executed(sender As Object, e As ExecutedRoutedEventArgs)
            Dim dlg As New OpenFileDialog()
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*"
            If dlg.ShowDialog() = True Then
                Dim fileStream As New FileStream(dlg.FileName, FileMode.Open)
                Dim range As New TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd)
                range.Load(fileStream, DataFormats.Rtf)
            End If
        End Sub

        Private Sub Save_Executed(sender As Object, e As ExecutedRoutedEventArgs)
            Dim dlg As New SaveFileDialog()
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*"
            If dlg.ShowDialog() = True Then
                Dim fileStream As New FileStream(dlg.FileName, FileMode.Create)
                Dim range As New TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd)
                range.Save(fileStream, DataFormats.Rtf)
            End If
        End Sub

        Private Sub cmbFontFamily_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
            If cmbFontFamily.SelectedItem IsNot Nothing Then
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem)
            End If
        End Sub

        Private Sub cmbFontSize_TextChanged(sender As Object, e As TextChangedEventArgs)
            rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text)
        End Sub
    End Class
End Namespace


'Class csv
'End Class
