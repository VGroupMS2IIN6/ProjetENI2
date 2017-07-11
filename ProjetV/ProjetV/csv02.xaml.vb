
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Collections.ObjectModel

Public Class csv02

    'Sub View(send As Object, e As EventArgs)
    'Using ps As PowerShell = PowerShell.Create()
    'Dim logFilePathName As String = "C:\Users\Olivier  - SP3\Documents\Visual Studio 2015\ProjetENI2\export\"
    '       ps.AddScript(String.Format("get-content {0} -wait", logFilePathName))
    'Dim outputCollection As PSDataCollection(Of PSObject) = New PSDataCollection(Of PSObject)
    'AddHandler() outputCollection.DataAdded, AddressOf LogFileOutput
    'Dim result As IAsyncResult = ps.BeginInvoke(Of PSObject, PSObject)(Nothing, outputCollection)
    'End Using
    'End Sub

    'Sub LogFileOutput(send As Object, data As DataAddedEventArgs)
    '   ListBox1 = data.ToString
    'End Sub

    Private Sub buttoncsv22_Click(sender As Object, e As RoutedEventArgs) Handles buttoncsv22.Click
            Dim csv03 As New csv03
            Hide()
            csv03.Show()
        End Sub

        Private Sub buttoncsv23_Click(sender As Object, e As RoutedEventArgs) Handles buttoncsv23.Click


        'Dim textbox1 As New TextBox
        'textbox1.Clear()

        'ListBox1.SelectedItems 
        'ListBox2.SelectedItems


    End Sub
End Class


