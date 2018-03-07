Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAvoidSave.Click
        Try
            RTBunbClear()
            Form1.avoidn = RTBunb.Lines.Count - 1
            For i = 0 To Form1.avoidn
                Form1.avoid(i) = Val(RTBunb.Lines(i))
            Next
            MsgBox("Saved successfully.")
        Catch
            MsgBox("Failed.")
        End Try
    End Sub

    Private Sub RTBunbClear()
        For i = 0 To Form1.avoidn
            Form1.avoid(i) = 0
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Try
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                OpenOpFile(OpenFileDialog1.FileName)
                MsgBox("Read Successfully.")
            End If
        Catch
            MsgBox("Error")
        End Try
    End Sub
    Public Sub OpenOpFile(path As String)
        Dim reader As New System.IO.StreamReader(path)
        Dim eachline As String
        eachline = reader.ReadLine()
        If eachline = "<RandomToolOptionFile>" Then
            Do
                eachline = reader.ReadLine()
                If eachline = "<AvoidList>" Then
                    Form1.avoidn = 0
                    eachline = reader.ReadLine()
                    While eachline <> "</>"
                        Form1.avoid(Form1.avoidn) = Val(eachline)
                        Form1.avoidn = Form1.avoidn + 1
                        eachline = reader.ReadLine()
                    End While
                    Form1.avoidn = Form1.avoidn - 1
                    eachline = reader.ReadLine()
                    RTBunbRef()
                End If
                If eachline = "<Confirm>" Then
                    Do
                        eachline = reader.ReadLine()
                        If eachline = "<Number>" Then
                            Form1.cfrma = 0
                            eachline = reader.ReadLine()
                            While eachline <> "</>"
                                Form1.cfrmno(Form1.cfrma) = Val(eachline)
                                Form1.cfrma = Form1.cfrma + 1
                                eachline = reader.ReadLine()
                            End While
                            Form1.cfrma = Form1.cfrma - 1
                            eachline = reader.ReadLine()
                        End If
                        If eachline = "<Value>" Then
                            Form1.cfrma = 0
                            eachline = reader.ReadLine()
                            While eachline <> "</>"
                                Form1.cfrmvl(Form1.cfrma) = Val(eachline)
                                Form1.cfrma = Form1.cfrma + 1
                                eachline = reader.ReadLine()
                            End While
                            Form1.cfrma = Form1.cfrma - 1
                            eachline = reader.ReadLine()
                        End If
                    Loop While eachline <> "</>"
                    SyncListBox()
                End If
            Loop While eachline <> ""
        Else
            MsgBox("Invalid File.")
        End If
        reader.Close()
        reader.Dispose()
    End Sub
    Public Sub RTBunbRef()
        RTBunb.Text = Str(Form1.avoid(0))
        For i = 1 To Form1.avoidn
            RTBunb.Text = RTBunb.Text + vbCrLf + Str(Form1.avoid(i))
        Next
    End Sub

    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim writer As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                writer.WriteLine("<RandomToolOptionFile>")
                writer.WriteLine("<AvoidList>")
                For i = 0 To Form1.avoidn
                    writer.WriteLine(Str(Form1.avoid(i)))
                Next
                writer.WriteLine("</>")
                writer.WriteLine("<Confirm>")
                writer.WriteLine("<Number>")
                For i = 0 To Form1.cfrma
                    writer.WriteLine(Str(Form1.cfrmno(i)))
                Next
                writer.WriteLine("</>")
                writer.WriteLine("<Value>")
                For i = 0 To Form1.cfrma
                    writer.WriteLine(Str(Form1.cfrmvl(i)))
                Next
                writer.WriteLine("</>")
                writer.WriteLine("</>")
                writer.WriteLine("</>")
                writer.Close()
                writer.Dispose()
                MsgBox("Saved Successfully.")
            End If
        Catch
            MsgBox("Error.")
        End Try
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If Form1.cfrmno.Contains(Val(TextBoxNo.Text)) = False Then
            Form1.cfrmno(Form1.cfrma + 1) = Val(TextBoxNo.Text)
            Form1.cfrmvl(Form1.cfrma + 1) = Val(TextBoxValue.Text)
            'LBConfirm.Items.Add(TextBoxNo.Text + ":" + TextBoxValue.Text)
            Form1.cfrma = Form1.cfrma + 1
            SyncListBox()
        Else
            MsgBox("Already Saved!")
        End If
    End Sub
    Public Sub SyncListBox()
        LBConfirm.Items.Clear()
        For i = 0 To Form1.cfrma
            LBConfirm.Items.Add(Str(Form1.cfrmno(i)) + ":" + Str(Form1.cfrmvl(i)))
        Next
    End Sub
    Public Sub SyncLabel()
        LabelCount.Text = "Next is the" + Str(Form1.cfrmh + 1) + "th time."
    End Sub
    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        Try
            Dim aim As Integer = LBConfirm.SelectedIndex
            For i = aim To Form1.cfrma
                Form1.cfrmno(i) = Form1.cfrmno(i + 1)
                Form1.cfrmvl(i) = Form1.cfrmvl(i + 1)
            Next
            Form1.cfrma = Form1.cfrma - 1
            SyncListBox()
        Catch
            MsgBox("Error.")
        End Try
    End Sub

    Private Sub ButtonClr_Click(sender As Object, e As EventArgs) Handles ButtonClr.Click
        Form1.cfrmh = 0
        SyncLabel()
    End Sub
End Class