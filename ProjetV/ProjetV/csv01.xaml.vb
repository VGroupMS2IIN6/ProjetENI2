
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Collections.ObjectModel



Public Class csv01


    ' helper method that takes your script path, loads up the script 
    ' into a variable, and passes the variable to the RunScript method 
    ' that will then execute the contents 
    Private Function LoadScript(ByVal filename As String) As String

        Try

            ' Create an instance of StreamReader to read from our file. 
            ' The using statement also closes the StreamReader. 
            Dim sr As New StreamReader(filename)

            ' use a string builder to get all our lines from the file 
            Dim fileContents As New StringBuilder()

            ' string to hold the current line 
            Dim curLine As String = ""

            ' loop through our file and read each line into our 
            ' stringbuilder as we go along 
            Do
                ' read each line and MAKE SURE YOU ADD BACK THE 
                ' LINEFEED THAT IT THE ReadLine() METHOD STRIPS OFF 
                curLine = sr.ReadLine()
                fileContents.Append(curLine + vbCrLf)
            Loop Until curLine Is Nothing

            ' close our reader now that we are done 
            sr.Close()

            ' call RunScript and pass in our file contents 
            ' converted to a string 
            Return fileContents.ToString()

        Catch e As Exception
            ' Let the user know what went wrong. 
            Dim errorText As String = "The file could not be read:"
            errorText += e.Message + "\n"
            Return errorText
        End Try

    End Function




    'Filtre pour rechercher les csv plus facilement - stream en reel et appel de windows


    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click


        'Lire ou écrire dans un fichier avec la classe OpenFileDialog
        Dim dialogOpen As New Microsoft.Win32.OpenFileDialog

        ' Boite de dialogue pour aller chercher son fichier
        With dialogOpen

            'Nom de la fenêtre - Chemin d'accès et filtre pré établit
            .InitialDirectory = "C:\"
            .Title = "veuillez choisir un fichier"
            .Filter = "Script Windows PowerShell (*.ps1)|*.ps1|All files (*.*)|*.*"

            'Ouvre la boite de dialogue
            Dim result? As Boolean = dialogOpen.ShowDialog()


            'Message et action de retour en cas d'erreur
            ' If Err.Number = 32755 Then Exit Sub
            'If Len(.FileName) = 0 Then Exit Sub


            'File number peut être définit par la fonction Freefile  FreeFile permet de retourner un numéro libre (pour répérer un fichier on doit lui donner un integer) et l'action (No) permet de repérer sur quel fichier on travaille
            'Pour ouvrir un fichier on utile donc FileOpen      FileOpen (FileNumber,FileName()peut être un path),Mode,Access(non obligatoire mais à tester dans notre cas),share(non obligatoire)
            'Du coup on définit la fonction FreeFile avec l'action No puis on appel le fichier à ouvrir

            'AUTRE METHODE A RETESTER
            'Dim No As Integer
            'Dim Line As String
            'No = FreeFile()
            'FileOpen(No, "C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\ps", OpenMode.Input, OpenAccess.Read)

            'run our script and put the result into our textbox 
            'NOTE: A RETESTER AVEC le richtextbox


            'RichTextBoxStreamType.PlainText = LoadScript("C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\ps\rentree26062017.csv")
            If result = True Then
                testbox.Text = LoadScript("C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\ps\rentree26062017.csv")
            End If



        End With

    End Sub





    ' SURQUALITE
    'Private Shared Sub btnSave_Click(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs) Handles btnSave.Click

    'Controls.RichTextBox("C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\upload\", RichTextBoxStreamType.UnicodePlainText)

    ' Create a SaveFileDialog to request a path and file name to save to.




    'Dim saveFile As New Microsoft.Win32.SaveFileDialog()

    'Dim Form As New RichTextBox


    ' Initialize the SaveFileDialog to specify the CSV extention for the file.
    '   saveFile.DefaultExt = "*.csv"
    '  saveFile.Filter = "Comma Separated Value|*.csv"

    ' Determine whether the user selected a file name from the saveFileDialog.
    'If (saveFile.ShowDialog() = Forms.DialogResult.OK) _
    '       And (saveFile.FileName.Length > 0) Then
    '
    '      ' Save the contents of the RichTextBox into the file.
    '     Form.SaveFile(saveFile.FileName,
    '                  RichTextBoxStreamType.RichText)

    'End If

    'End Sub







End Class

