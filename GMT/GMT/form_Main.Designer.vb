<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Main
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
        Me.Timer_FormLoad = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Left.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_FormLoad
        '
        Me.Timer_FormLoad.Enabled = True
        '
        'Panel_Top
        '
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(800, 37)
        Me.Panel_Top.TabIndex = 1
        '
        'Panel_Left
        '
        Me.Panel_Left.Controls.Add(Me.Label1)
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Location = New System.Drawing.Point(0, 37)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(200, 563)
        Me.Panel_Left.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_Left)
        Me.Controls.Add(Me.Panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GMT"
        Me.Panel_Left.ResumeLayout(False)
        Me.Panel_Left.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer_FormLoad As Timer
    Friend WithEvents Panel_Top As Panel
    Friend WithEvents Panel_Left As Panel
    Friend WithEvents Label1 As Label
End Class
