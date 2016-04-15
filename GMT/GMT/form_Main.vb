Public Class form_Main
    Private Sub Timer_FormLoad_Tick(sender As Object, e As EventArgs) Handles Timer_FormLoad.Tick
        Dim frm As New form_About
        frm.MdiParent = Me
        frm.Show()
        Timer_FormLoad.Enabled = False
    End Sub
End Class
