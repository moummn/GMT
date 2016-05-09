<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Main
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer_FormLoad = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Button_Settings = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Minisize = New System.Windows.Forms.Button()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.Button_About = New System.Windows.Forms.Button()
        Me.Button_ROM = New System.Windows.Forms.Button()
        Me.Button_HEX = New System.Windows.Forms.Button()
        Me.Panel_Top.SuspendLayout()
        Me.Panel_Left.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_FormLoad
        '
        Me.Timer_FormLoad.Enabled = True
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Button_Settings)
        Me.Panel_Top.Controls.Add(Me.Button_Close)
        Me.Panel_Top.Controls.Add(Me.Button_Minisize)
        Me.Panel_Top.Controls.Add(Me.Label_Title)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(800, 40)
        Me.Panel_Top.TabIndex = 1
        '
        'Button_Settings
        '
        Me.Button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Settings.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_Settings.Location = New System.Drawing.Point(684, 4)
        Me.Button_Settings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Settings.Name = "Button_Settings"
        Me.Button_Settings.Size = New System.Drawing.Size(32, 30)
        Me.Button_Settings.TabIndex = 3
        Me.Button_Settings.Text = "0"
        Me.Button_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Settings.UseVisualStyleBackColor = True
        Me.Button_Settings.Visible = False
        '
        'Button_Close
        '
        Me.Button_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(763, 4)
        Me.Button_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(32, 30)
        Me.Button_Close.TabIndex = 2
        Me.Button_Close.Text = "r"
        Me.Button_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Minisize
        '
        Me.Button_Minisize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button_Minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minisize.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_Minisize.Location = New System.Drawing.Point(726, 4)
        Me.Button_Minisize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Minisize.Name = "Button_Minisize"
        Me.Button_Minisize.Size = New System.Drawing.Size(32, 30)
        Me.Button_Minisize.TabIndex = 1
        Me.Button_Minisize.Text = "0"
        Me.Button_Minisize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Minisize.UseVisualStyleBackColor = True
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(3, 9)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(129, 20)
        Me.Label_Title.TabIndex = 0
        Me.Label_Title.Text = "黄金太阳综合工具"
        '
        'Panel_Left
        '
        Me.Panel_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel_Left.Controls.Add(Me.Button_HEX)
        Me.Panel_Left.Controls.Add(Me.Button_ROM)
        Me.Panel_Left.Controls.Add(Me.Button_About)
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Left.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(150, 560)
        Me.Panel_Left.TabIndex = 0
        '
        'Button_About
        '
        Me.Button_About.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_About.Location = New System.Drawing.Point(0, 517)
        Me.Button_About.Name = "Button_About"
        Me.Button_About.Size = New System.Drawing.Size(150, 40)
        Me.Button_About.TabIndex = 1
        Me.Button_About.Text = "关于(&A)"
        Me.Button_About.UseVisualStyleBackColor = True
        '
        'Button_ROM
        '
        Me.Button_ROM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button_ROM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ROM.Location = New System.Drawing.Point(0, 0)
        Me.Button_ROM.Name = "Button_ROM"
        Me.Button_ROM.Size = New System.Drawing.Size(150, 40)
        Me.Button_ROM.TabIndex = 2
        Me.Button_ROM.Text = "ROM文件管理(&F)"
        Me.Button_ROM.UseVisualStyleBackColor = True
        '
        'Button_HEX
        '
        Me.Button_HEX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button_HEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_HEX.Location = New System.Drawing.Point(0, 46)
        Me.Button_HEX.Name = "Button_HEX"
        Me.Button_HEX.Size = New System.Drawing.Size(150, 40)
        Me.Button_HEX.TabIndex = 3
        Me.Button_HEX.Text = "源文件(&R)"
        Me.Button_HEX.UseVisualStyleBackColor = True
        '
        'form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_Left)
        Me.Controls.Add(Me.Panel_Top)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GMT"
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.Panel_Left.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer_FormLoad As Timer
    Friend WithEvents Panel_Top As Panel
    Friend WithEvents Panel_Left As Panel
    Friend WithEvents Label_Title As Label
    Friend WithEvents Button_Minisize As Button
    Friend WithEvents Button_Close As Button
    Friend WithEvents Button_Settings As Button
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_ROM As Button
    Friend WithEvents Button_HEX As Button
End Class
