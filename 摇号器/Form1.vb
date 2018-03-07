Public Class Form1
    Dim range As Integer 'The range of number
    Dim time As Integer ' The time which counts change
    Public avoid(20002) As Integer 'The list of avoided number
    Public avoidn As Integer 'The total of avoid()
    Public cfrmno(20002) As Integer 'The list of which will confirm
    Public cfrmvl(20002) As Integer 'The confirm number
    Public cfrma As Integer 'The total of cfrmno() & cfrmvl()
    Public cfrmh As Integer ' Which time this operation is
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        If IsNumeric(TBRange.Text) Then
            range = Val(TBRange.Text)
            If range >= 1 Then
                Timer.Enabled = True
                Button.Enabled = False
                Button.Text = "摇号中..."
            Else
                MsgBox("范围不合法。")
            End If
        Else
            MsgBox("范围不合法。")
        End If
        Randomize()
        time = Rnd() * 20 + 5
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        RandomChange()
        time = time - 1
        If time = 0 Then
            cfrmh = cfrmh + 1
            Dim isConfirm As Integer = Array.IndexOf(cfrmno, cfrmh)
            If isConfirm <> -1 Then
                TBMain.Text = Str(cfrmvl(isConfirm))
            Else
                ChangeAvoid()
            End If
            Timer.Enabled = False
            Button.Enabled = True
            Button.Text = "开始摇号"
        End If
    End Sub

    Private Sub TBRange_KeyDown(sender As Object, e As KeyEventArgs) Handles TBRange.KeyDown
        If e.KeyData = 123 Then
            Form2.Show()
            Form2.RTBunbRef()
            Form2.SyncListBox()
            Form2.SyncLabel()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avoid(0) = 0
        avoidn = 0
        cfrma = 0
        cfrmno(0) = 0
        cfrmvl(0) = 0
        cfrmh = 0
        Dim obfile As New System.IO.FileInfo("Options.txt")
        If obfile.Exists Then
            Form2.OpenOpFile("Options.txt")
        End If
    End Sub
    Private Sub RandomChange()
        Randomize()
        TBMain.Text = Str(Fix(Rnd() * range + 1))
    End Sub
    Private Sub ChangeAvoid()
        While avoid.Contains(Val(TBMain.Text))
            RandomChange()
        End While
    End Sub
End Class
