Imports System.IO

Public Class Form1

    Private msFilePath As String = "C:/ReadWrite/WordsList.txt"
    Private moSR As StreamReader = Nothing
    Private moSW As StreamWriter = Nothing

    Private Sub LoadWords()

        cboWords.Items.Clear()

        'Open the StremReader
        moSR = New StreamReader(msFilePath)

        While Not moSR.EndOfStream

            cboWords.Items.Add(moSR.ReadLine())


        End While

        moSR.Close()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If File.Exists(msFilePath) Then
            LoadWords()
        End If

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'Open the StreamWriter
        moSW = New StreamWriter(msFilePath, True)

        'Read the word out of the textbox and add the word to the text file
        moSW.WriteLine(txtWord.Text)
        moSW.Close()

        'Load the combobox with the words from the text file
        LoadWords()

        'Clear the textbox
        txtWord.Clear()

        'Focus on the textbos
        txtWord.Focus()

    End Sub
End Class
