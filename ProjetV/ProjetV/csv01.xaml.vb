
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class csv01



    Public Sub rtbEditor_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)




    End Sub


    'Filtre pour rechercher les csv plus facilement - stream en reel et appel de windows


    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click


        'Lire ou écrire dans un fichier avec la classe OpenFileDialog
        Dim dialogOpen As New Microsoft.Win32.OpenFileDialog

        ' Boite de dialogue pour aller chercher son fichier
        With dialogOpen

            'Nom de la fenêtre - Chemin d'accès et filtre pré établit
            .InitialDirectory = "C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\csv"
            .Title = "veuillez choisir un fichier"
            .Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*"

            'Ouvre la boite de dialogue
            .ShowDialog()


            'Message et action de retour en cas d'erreur
            If Err.Number = 32755 Then Exit Sub
            If Len(.FileName) = 0 Then Exit Sub


            'File number peut être définit par la fonction Freefile  FreeFile permet de retourner un numéro libre (pour répérer un fichier on doit lui donner un integer) et l'action (No) permet de repérer sur quel fichier on travaille
            'Pour ouvrir un fichier on utile donc FileOpen      FileOpen (FileNumber,FileName()peut être un path),Mode,Access(non obligatoire mais à tester dans notre cas),share(non obligatoire)
            'Du coup on définit la fonction FreeFile avec l'action No puis on appel le fichier à ouvrir

            Dim No As Integer
            Dim Line As String
            No = FreeFile()
            FileOpen(No, "C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\csv", OpenMode.Input, OpenAccess.Default)

            'Permet de parcourir tout le fichier
            While Not EOF(No)
                Line = LineInput(No)
                Debug.WriteLine(Line)
            End While
            FileClose(No)
        End With

    End Sub






    Private Shared Sub btnSave_Click(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs) Handles btnSave.Click

        'Controls.RichTextBox("C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\upload\", RichTextBoxStreamType.UnicodePlainText)

        ' Create a SaveFileDialog to request a path and file name to save to.




        Dim saveFile As New Microsoft.Win32.SaveFileDialog()

        Dim Form As New RichTextBox


        ' Initialize the SaveFileDialog to specify the RTF extention for the file.
        saveFile.DefaultExt = "*.csv"
        saveFile.Filter = "Comma Separated Value|*.csv"

        ' Determine whether the user selected a file name from the saveFileDialog.
        If (saveFile.ShowDialog() = Forms.DialogResult.OK) _
            And (saveFile.FileName.Length > 0) Then

            ' Save the contents of the RichTextBox into the file.
            Form.SaveFile(saveFile.FileName,
                          RichTextBoxStreamType.RichText)

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




End Class

