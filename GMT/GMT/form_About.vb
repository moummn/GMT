Public Class form_About
    Private Sub form_About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "版本：" & My.Application.Info.Version.ToString & " 这里用于展示一些DEBUG信息"
    End Sub
End Class