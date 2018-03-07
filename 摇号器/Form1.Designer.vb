<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TBRange = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBMain = New System.Windows.Forms.TextBox()
        Me.Button = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBRange
        '
        Me.TBRange.Location = New System.Drawing.Point(113, 12)
        Me.TBRange.Name = "TBRange"
        Me.TBRange.Size = New System.Drawing.Size(159, 21)
        Me.TBRange.TabIndex = 0
        Me.TBRange.Text = "37"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "请输入号码范围："
        '
        'TBMain
        '
        Me.TBMain.Enabled = False
        Me.TBMain.Font = New System.Drawing.Font("Consolas", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMain.Location = New System.Drawing.Point(12, 39)
        Me.TBMain.Name = "TBMain"
        Me.TBMain.Size = New System.Drawing.Size(260, 163)
        Me.TBMain.TabIndex = 2
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(12, 208)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(260, 23)
        Me.Button.TabIndex = 3
        Me.Button.Text = "开始摇号"
        Me.Button.UseVisualStyleBackColor = True
        '
        'Timer
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "谷雨同学制作"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 255)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.TBMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBRange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "随机摇号器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBRange As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBMain As System.Windows.Forms.TextBox
    Friend WithEvents Button As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
