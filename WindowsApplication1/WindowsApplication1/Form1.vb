Public Class Form1

    Public Structure exam
        Public question As String
        Public description As String
        Public responseA As String
        Public responseB As String
        Public responseC As String
        Public responseD As String
        Public responseE As String
        Public correctAnswer As String
        Public choice As String
        Public result As Boolean
    End Structure
    Public simulation(100) As exam
    Public index As Integer
    Public total As Integer
    Public acertos As Integer
    Public erros As Integer
    Public MyValue As String





    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label_question.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyValue = "C:\Users\edson\Downloads\Free_OG0-093_Foundation_VCE_Exam_Questions_TOGAF9_Pass4sure_May-2016_By_Paul.txt"
        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader(MyValue)
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        acertos = 0
        erros = 0
        index = 0
        Do While (Not fileReader.EndOfStream)
            'MsgBox(stringReader)
            If stringReader.Contains("QUESTION") Then
                index = index + 1
                simulation(index).question = stringReader

                stringReader = fileReader.ReadLine()
                stringReader = fileReader.ReadLine()

                Dim temp As String
                temp = stringReader
                Do While (stringReader.Length > 0)
                    stringReader = fileReader.ReadLine()
                    temp = temp & Chr(10) & Chr(13) + stringReader
                Loop
                simulation(index).description = temp

                stringReader = fileReader.ReadLine()
                Dim nextQuestion As Boolean
                nextQuestion = False
                Do While (nextQuestion = False)
                    If stringReader.Contains("A.") = True Then
                        temp = stringReader
                        Do While (stringReader.Length > 0)
                            stringReader = fileReader.ReadLine()
                            temp = temp & Chr(10) & Chr(13) + stringReader
                        Loop
                        simulation(index).responseA = temp
                    ElseIf stringReader.Contains("B.") Then
                        temp = stringReader
                        Do While (stringReader.Length > 0)
                            stringReader = fileReader.ReadLine()
                            temp = temp & Chr(10) & Chr(13) + stringReader
                        Loop
                        simulation(index).responseB = temp
                    ElseIf stringReader.Contains("C.") Then
                        temp = stringReader
                        Do While (stringReader.Length > 0)
                            stringReader = fileReader.ReadLine()
                            temp = temp & Chr(10) & Chr(13) + stringReader
                        Loop
                        simulation(index).responseC = temp
                    ElseIf stringReader.Contains("D.") Then
                        temp = stringReader
                        Do While (stringReader.Length > 0)
                            stringReader = fileReader.ReadLine()
                            temp = temp & Chr(10) & Chr(13) + stringReader
                        Loop
                        simulation(index).responseD = temp
                    ElseIf stringReader.Contains("E.") Then
                        temp = stringReader
                        Do While (stringReader.Length > 0)
                            stringReader = fileReader.ReadLine()
                            temp = temp & Chr(10) & Chr(13) + stringReader
                        Loop
                        simulation(index).responseE = temp
                    ElseIf stringReader.Contains("Correct Answer") Then
                        simulation(index).correctAnswer = stringReader
                        nextQuestion = True
                    End If
                    stringReader = fileReader.ReadLine()
                Loop

            End If

            stringReader = fileReader.ReadLine()
        Loop

        total = index
        index = 1
        If (index < total) Then
            RespostaCorreta.Text = ""
            label_question.Text = simulation(index).question
            label_description.Text = simulation(index).description
            RadioButton_Option_A.Text = simulation(index).responseA
            RadioButton_Option_B.Text = simulation(index).responseB
            RadioButton_Option_C.Text = simulation(index).responseC
            RadioButton_Option_D.Text = simulation(index).responseD
            RadioButton_Option_E.Text = simulation(index).responseE
            ' RespostaCorreta.Text =simulation(index).correctAnswer 

            RadioButton_Option_A.Checked = False
            RadioButton_Option_B.Checked = False
            RadioButton_Option_C.Checked = False
            RadioButton_Option_D.Checked = False
            RadioButton_Option_E.Checked = False

        End If
    End Sub
    Private Sub Button_Resume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Resume.Click
        End
    End Sub

    Private Sub Button_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_next.Click
        RespostaCorreta.Text = simulation(index).correctAnswer
        If RadioButton_Option_A.Checked And simulation(index).correctAnswer.Contains(": A") Then
            simulation(index).result = True
            acertos = acertos + 1
        ElseIf RadioButton_Option_B.Checked And simulation(index).correctAnswer.Contains(": B") Then
            simulation(index).result = True
            acertos = acertos + 1
        ElseIf RadioButton_Option_C.Checked And simulation(index).correctAnswer.Contains(": C") Then
            simulation(index).result = True
            acertos = acertos + 1
        ElseIf RadioButton_Option_D.Checked And simulation(index).correctAnswer.Contains(": D") Then
            simulation(index).result = True
            acertos = acertos + 1
        ElseIf RadioButton_Option_E.Checked And simulation(index).correctAnswer.Contains(": E") Then
            simulation(index).result = True
            acertos = acertos + 1
        Else
            simulation(index).result = False
            erros = erros + 1
        End If

        MsgBox("Resposta: " + IIf(simulation(index).result, "Correta!", "Errada!") + " Total de Acertos:" + acertos.ToString + " de " + total.ToString)

        'Próxima pergunta
        index = index + 1
        If (index < total) Then
            RadioButton_Option_A.Checked = False
            RadioButton_Option_B.Checked = False
            RadioButton_Option_C.Checked = False
            RadioButton_Option_D.Checked = False
            RadioButton_Option_E.Checked = False

            label_question.Text = simulation(index).question
            label_description.Text = simulation(index).description
            RadioButton_Option_A.Text = simulation(index).responseA
            RadioButton_Option_B.Text = simulation(index).responseB
            RadioButton_Option_C.Text = simulation(index).responseC
            RadioButton_Option_D.Text = simulation(index).responseD
            RadioButton_Option_E.Text = simulation(index).responseE
            RespostaCorreta.Text = ""

        End If
    End Sub

    Private Sub RadioButton_Option_A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Option_A.CheckedChanged

    End Sub

    Private Sub Button_Previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Previous.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button_loadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_loadFile.Click
        MyValue = InputBox("File to Load:", "", "C:\Users\edson\Downloads\Free_OG0-093_Foundation_VCE_Exam_Questions_TOGAF9_Pass4sure_May-2016_By_Paul.txt")
    End Sub
End Class
