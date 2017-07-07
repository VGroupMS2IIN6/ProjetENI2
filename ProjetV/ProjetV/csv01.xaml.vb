
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Collections.ObjectModel


Public Class csv01


    ' Cette méthode ci dessous va nous permettre d'avoir un script PS en entrée et de le lancer puis de le convertir/formater au besoin

    Private Function RunScript(ByVal scriptText As String) As String

        ' Creation d'un Powershell runspace 
        Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        ' Ouverture 
        MyRunSpace.Open()

        ' Creation d'un tunnel et renseigner le script en textbrut
        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        MyPipeline.Commands.AddScript(scriptText)

        ' Formattage du Output 
        MyPipeline.Commands.Add("Out-String")

        ' Execution
        Dim results As Collection(Of PSObject) = MyPipeline.Invoke()

        ' Fermeture du runspace 
        MyRunSpace.Close()

        ' convertir le Output initialise une nouvelle instance de la classe Builder 
        Dim MyStringBuilder As New StringBuilder()

        For Each obj As PSObject In results
            MyStringBuilder.AppendLine(obj.ToString())
        Next

        ' return le resultat of the script qui est convertie et formaté
        Return MyStringBuilder.ToString()

    End Function


    'Cependant des améliorations sont possibles, maintenant nous allons ajouter un LoadScript method pour facilité l'utilisation des variables faisant appel au script.
    ' Chargement du script au sein d'une variable, et lancer la variable à l'aide du RunScript
    ' Cela va permettre d'excuter le contenu du script au sein de l'application ^^ 


    Private Function LoadScript(ByVal filename As String) As String

        Try

            ' Creation d'une instance StreamReader pour lire le fichier. 
            ' Il est important de fermer le streamReader après utilisation - cf MSDN. 
            Dim sr As New StreamReader(filename)

            ' Charger toutes les lignes du fichiers csv
            Dim fileContents As New StringBuilder()

            ' string to hold the current line 
            Dim curLine As String = ""

            ' Parcourir tout le fichier et charger chaque ligne dans le Builder
            Do
                ' Verification que toutes les lignes ont bien été lu et chargé    

                curLine = sr.ReadLine()
                fileContents.Append(curLine + vbCrLf)
            Loop Until curLine Is Nothing

            ' Fermeture du streamReader 
            sr.Close()

            ' call RunScript and pass in our file contents 
            ' converted to a string 
            Return fileContents.ToString()

        Catch e As Exception
            ' Gestion des erreurs. 
            Dim errorText As String = "The file could not be read:"
            errorText += e.Message + "\n"
            Return errorText
        End Try

    End Function



    'Code Behind btnOpen - stream en reel et appel de windows


    Private Sub btncsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncsv.Click


        'Lire ou écrire dans un fichier avec la classe OpenFileDialog
        Dim dialogOpen As New Microsoft.Win32.OpenFileDialog

        ' Boite de dialogue pour aller chercher son fichier
        With dialogOpen

            'Nom de la fenêtre - Chemin d'accès et filtre pré établit
            .InitialDirectory = "C:\"
            .Title = "veuillez ouvrir un script PS"
            .Filter = "Power Shell Script(*.ps1)|*.ps1|All files (*.*)|*.*"

            'Ouvre la boite de dialogue
            'Dim result? As Boolean = dialogOpen.ShowDialog()



            'run our script and put the result into our textbox 
            'NOTE: A RETESTER AVEC le richtextbox
            'RichTextBoxStreamType.PlainText = LoadScript("C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\ps\rentree26062017.csv")


            'Lancer le script avec le Load et le Run
            'If result = True Then

            If dialogOpen.ShowDialog() = True Then
                textBoxcsv.Text = RunScript(LoadScript("C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\ps\Import.ps1"))



            End If

        End With


    End Sub



    Private Sub buttoncsv11_Click(sender As Object, e As RoutedEventArgs) Handles buttoncsv11.Click
        Dim csv02 As New csv02
        Hide()
        csv02.Show()
    End Sub




    ' SURQUALITE
    'Private Sub btncsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncsv.Click


    ' Configure save file dialog box
    ' Dim saveFileDialog1 As New Microsoft.Win32.SaveFileDialog
    '  saveFileDialog1.InitialDirectory = "C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\Export"
    '   saveFileDialog1.Title = "Save text Files"
    'saveFileDialog1.FileName = "test"
    'saveFileDialog1.CheckFileExists = False
    ' saveFileDialog1.CheckPathExists = True
    '  saveFileDialog1.DefaultExt = ".csv"
    '   saveFileDialog1.Filter = "Comma separated value (*.csv)|*.csv|All files (*.*)|*.*"
    '    saveFileDialog1.RestoreDirectory = False

    ' Show save file dialog box
    'Dim result? As Boolean = saveFileDialog1.ShowDialog()

    ' Process save file dialog box results
    'If saveFileDialog1.ShowDialog() = DialogResult Then
    '  If saveFileDialog1.ShowDialog() = True Then
    '       File.WriteAllText(saveFileDialog1.FileName, textBoxcsv.Text)
    '    End If

    ' If result = True Then
    ' testbox.Text = saveFileDialog1.FileName
    'End If


    '    End Sub



End Class

