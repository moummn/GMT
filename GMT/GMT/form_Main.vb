Imports System.Runtime.InteropServices
Public Class form_Main
    '用于拖动窗体
    Dim Mouse_Drag As Boolean = False
    Dim Mouse_X As Integer = 0
    Dim Mouse_Y As Integer = 0
    '用于处理窗体外观（MDI窗体无3D边框）
    <DllImport("user32.dll", ExactSpelling:=True)>
    Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer,
         ByVal uFlags As UInteger) As Integer
    End Function
    Private Const GWL_STYLE As Integer = -16
    Private Const GWL_EXSTYLE As Integer = -20

    Private Const WS_BORDER As Integer = &H800000
    Private Const WS_EX_CLIENTEDGE As Integer = &H200

    Private Const SWP_NOSIZE As UInteger = &H1
    Private Const SWP_NOMOVE As UInteger = &H2
    Private Const SWP_NOZORDER As UInteger = &H4
    Private Const SWP_NOREDRAW As UInteger = &H8
    Private Const SWP_NOACTIVATE As UInteger = &H10
    Private Const SWP_FRAMECHANGED As UInteger = &H20
    Private Const SWP_SHOWWINDOW As UInteger = &H40
    Private Const SWP_HIDEWINDOW As UInteger = &H80
    Private Const SWP_NOCOPYBITS As UInteger = &H100
    Private Const SWP_NOOWNERZORDER As UInteger = &H200
    Private Const SWP_NOSENDCHANGING As UInteger = &H400
    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Public Sub ChangeMdiClientBorderStyle(ByVal Value As System.Windows.Forms.BorderStyle, ByVal Handle As IntPtr)
        Dim style As Integer = GetWindowLong(Handle, GWL_STYLE)
        Dim exStyle As Integer = GetWindowLong(Handle, GWL_EXSTYLE)
        ' Add or remove style flags as necessary.
        Select Case Value
            Case BorderStyle.Fixed3D
                exStyle = exStyle Or WS_EX_CLIENTEDGE
                style = style And Not WS_BORDER
                Exit Select

            Case BorderStyle.FixedSingle
                exStyle = exStyle And Not WS_EX_CLIENTEDGE
                style = style Or WS_BORDER
                Exit Select

            Case BorderStyle.None
                style = style And Not WS_BORDER
                exStyle = exStyle And Not WS_EX_CLIENTEDGE
                Exit Select
        End Select

        ' Set the styles using Win32 calls
        SetWindowLong(Handle, GWL_STYLE, style)
        SetWindowLong(Handle, GWL_EXSTYLE, exStyle)

        ' Update the non-client area.
        SetWindowPos(Handle, IntPtr.Zero, 0, 0, 0, 0,
             SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOZORDER Or SWP_NOOWNERZORDER Or SWP_FRAMECHANGED)
    End Sub
    ''' <summary>
    ''' 获取MDIClient句柄
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getMdiClientHandle() As IntPtr
        Dim Obj As MdiClient = Nothing
        Dim t As Type
        For Each Item As Control In Me.Controls
            t = Item.[GetType]()
            If t.Name = "MdiClient" Then
                Obj = DirectCast(Item, MdiClient)
                Exit For
            End If
        Next
        If Obj IsNot Nothing Then
            Return Obj.Handle
        Else
            Return IntPtr.Zero
        End If
    End Function
    Private Sub Timer_FormLoad_Tick(sender As Object, e As EventArgs) Handles Timer_FormLoad.Tick
        If Me.IsMdiContainer Then
            ChangeMdiClientBorderStyle(BorderStyle.None, getMdiClientHandle)
        End If
        Dim frm As New form_About
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()
        Timer_FormLoad.Enabled = False
    End Sub

    Private Sub form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Button_Minisize_Click(sender As Object, e As EventArgs) Handles Button_Minisize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    '拖动窗体
    Private Sub TitleMove_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) _
        Handles Panel_Top.MouseDown, Label_Title.MouseDown
        Mouse_Drag = True
        Mouse_X = Windows.Forms.Cursor.Position.X - Me.Left
        Mouse_Y = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TitleMove_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) _
        Handles Panel_Top.MouseMove, Label_Title.MouseMove
        If Mouse_Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Mouse_Y
            Me.Left = Windows.Forms.Cursor.Position.X - Mouse_X
        End If
    End Sub

    Private Sub TitleMove_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) _
        Handles Panel_Top.MouseUp, Label_Title.MouseUp
        Mouse_Drag = False
    End Sub
End Class
