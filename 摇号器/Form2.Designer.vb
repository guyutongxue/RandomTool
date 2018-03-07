<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RTBunb = New System.Windows.Forms.RichTextBox()
        Me.ButtonAvoidSave = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonWrite = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBConfirm = New System.Windows.Forms.ListBox()
        Me.TextBoxNo = New System.Windows.Forms.TextBox()
        Me.TextBoxValue = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.GroupBoxConfirm = New System.Windows.Forms.GroupBox()
        Me.ButtonClr = New System.Windows.Forms.Button()
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxConfirm.SuspendLayout()
        Me.SuspendLayout()
        '
        'RTBunb
        '
        Me.RTBunb.Location = New System.Drawing.Point(8, 20)
        Me.RTBunb.Name = "RTBunb"
        Me.RTBunb.Size = New System.Drawing.Size(148, 135)
        Me.RTBunb.TabIndex = 0
        Me.RTBunb.Text = ""
        '
        'ButtonAvoidSave
        '
        Me.ButtonAvoidSave.Location = New System.Drawing.Point(8, 161)
        Me.ButtonAvoidSave.Name = "ButtonAvoidSave"
        Me.ButtonAvoidSave.Size = New System.Drawing.Size(148, 23)
        Me.ButtonAvoidSave.TabIndex = 1
        Me.ButtonAvoidSave.Text = "Save(Temporary)"
        Me.ButtonAvoidSave.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRead.Location = New System.Drawing.Point(39, 12)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(165, 23)
        Me.ButtonRead.TabIndex = 3
        Me.ButtonRead.Text = "Read from file"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Options.txt"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Options.txt"
        '
        'ButtonWrite
        '
        Me.ButtonWrite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonWrite.Location = New System.Drawing.Point(210, 12)
        Me.ButtonWrite.Name = "ButtonWrite"
        Me.ButtonWrite.Size = New System.Drawing.Size(165, 23)
        Me.ButtonWrite.TabIndex = 4
        Me.ButtonWrite.Text = "Save to file"
        Me.ButtonWrite.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonAvoidSave)
        Me.GroupBox1.Controls.Add(Me.RTBunb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 190)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avoid Numbers Below:"
        '
        'LBConfirm
        '
        Me.LBConfirm.FormattingEnabled = True
        Me.LBConfirm.ItemHeight = 12
        Me.LBConfirm.Location = New System.Drawing.Point(11, 24)
        Me.LBConfirm.Name = "LBConfirm"
        Me.LBConfirm.Size = New System.Drawing.Size(74, 136)
        Me.LBConfirm.TabIndex = 6
        '
        'TextBoxNo
        '
        Me.TextBoxNo.Location = New System.Drawing.Point(91, 24)
        Me.TextBoxNo.Name = "TextBoxNo"
        Me.TextBoxNo.Size = New System.Drawing.Size(43, 21)
        Me.TextBoxNo.TabIndex = 7
        '
        'TextBoxValue
        '
        Me.TextBoxValue.Location = New System.Drawing.Point(140, 24)
        Me.TextBoxValue.Name = "TextBoxValue"
        Me.TextBoxValue.Size = New System.Drawing.Size(43, 21)
        Me.TextBoxValue.TabIndex = 8
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(91, 57)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(92, 23)
        Me.ButtonAdd.TabIndex = 9
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDel
        '
        Me.ButtonDel.Location = New System.Drawing.Point(91, 86)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(92, 23)
        Me.ButtonDel.TabIndex = 10
        Me.ButtonDel.Text = "Delete"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'GroupBoxConfirm
        '
        Me.GroupBoxConfirm.Controls.Add(Me.ButtonClr)
        Me.GroupBoxConfirm.Controls.Add(Me.LabelCount)
        Me.GroupBoxConfirm.Controls.Add(Me.ButtonDel)
        Me.GroupBoxConfirm.Controls.Add(Me.ButtonAdd)
        Me.GroupBoxConfirm.Controls.Add(Me.TextBoxValue)
        Me.GroupBoxConfirm.Controls.Add(Me.TextBoxNo)
        Me.GroupBoxConfirm.Controls.Add(Me.LBConfirm)
        Me.GroupBoxConfirm.Location = New System.Drawing.Point(183, 56)
        Me.GroupBoxConfirm.Name = "GroupBoxConfirm"
        Me.GroupBoxConfirm.Size = New System.Drawing.Size(194, 190)
        Me.GroupBoxConfirm.TabIndex = 11
        Me.GroupBoxConfirm.TabStop = False
        Me.GroupBoxConfirm.Text = "Certain Number"
        '
        'ButtonClr
        '
        Me.ButtonClr.Location = New System.Drawing.Point(91, 137)
        Me.ButtonClr.Name = "ButtonClr"
        Me.ButtonClr.Size = New System.Drawing.Size(92, 23)
        Me.ButtonClr.TabIndex = 13
        Me.ButtonClr.Text = "Reset Count"
        Me.ButtonClr.UseVisualStyleBackColor = True
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Location = New System.Drawing.Point(9, 166)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(41, 12)
        Me.LabelCount.TabIndex = 12
        Me.LabelCount.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 262)
        Me.Controls.Add(Me.GroupBoxConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonWrite)
        Me.Controls.Add(Me.ButtonRead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Developer Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBoxConfirm.ResumeLayout(False)
        Me.GroupBoxConfirm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RTBunb As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonAvoidSave As System.Windows.Forms.Button
    Friend WithEvents ButtonRead As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ButtonWrite As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBConfirm As System.Windows.Forms.ListBox
    Friend WithEvents TextBoxNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxValue As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonDel As System.Windows.Forms.Button
    Friend WithEvents GroupBoxConfirm As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClr As System.Windows.Forms.Button
    Friend WithEvents LabelCount As System.Windows.Forms.Label
End Class
