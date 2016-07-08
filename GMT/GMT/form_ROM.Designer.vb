<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_ROM
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
        Me.Button_ViewFolders = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button_Use = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Button_ViewFolders
        '
        Me.Button_ViewFolders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_ViewFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ViewFolders.ForeColor = System.Drawing.Color.White
        Me.Button_ViewFolders.Location = New System.Drawing.Point(529, 12)
        Me.Button_ViewFolders.Name = "Button_ViewFolders"
        Me.Button_ViewFolders.Size = New System.Drawing.Size(115, 34)
        Me.Button_ViewFolders.TabIndex = 0
        Me.Button_ViewFolders.Text = "文件夹(&F)..."
        Me.Button_ViewFolders.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(8, 8)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(515, 542)
        Me.ListBox1.TabIndex = 1
        '
        'Button_Use
        '
        Me.Button_Use.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Use.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Use.ForeColor = System.Drawing.Color.White
        Me.Button_Use.Location = New System.Drawing.Point(529, 52)
        Me.Button_Use.Name = "Button_Use"
        Me.Button_Use.Size = New System.Drawing.Size(115, 34)
        Me.Button_Use.TabIndex = 2
        Me.Button_Use.Text = "使用该文件(&U)"
        Me.Button_Use.UseVisualStyleBackColor = True
        '
        'form_ROM
        '
        Me.AcceptButton = Me.Button_Use
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Use)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button_ViewFolders)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "form_ROM"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "form_ROM"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_ViewFolders As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button_Use As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
