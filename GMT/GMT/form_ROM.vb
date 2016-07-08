Public Class form_ROM
    Private Sub sbListRefresh(ByVal strDirectory As String)
        ListBox1.Items.Clear()
        For Each F As String In My.Computer.FileSystem.GetFiles(strDirectory)
            Dim S() As String = Split(F, "\")
            ListBox1.Items.Add(S(UBound(S)))
        Next
    End Sub

    Private Sub form_ROM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FolderBrowserDialog1.SelectedPath = "" Then FolderBrowserDialog1.SelectedPath = My.Application.Info.DirectoryPath
        Call sbListRefresh(My.Application.Info.DirectoryPath)
    End Sub

    Private Sub Button_ViewFolders_Click(sender As Object, e As EventArgs) Handles Button_ViewFolders.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Call sbListRefresh(FolderBrowserDialog1.SelectedPath)
        End If

    End Sub

    Private Sub Button_Use_Click(sender As Object, e As EventArgs) Handles Button_Use.Click
        If ListBox1.SelectedIndex <> -1 Then
            ROM_File = FolderBrowserDialog1.SelectedPath & "\" & ListBox1.SelectedItem.ToString
            form_Main.Label_Title.Text = My.Resources.App_Name & " - " & ListBox1.SelectedItem.ToString
            Button_Use.Enabled = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim S() As String = Split(ROM_File, "\")
        If ROM_File = FolderBrowserDialog1.SelectedPath & "\" & sender.SelectedItem Then
            Button_Use.Enabled = False
        Else
            Button_Use.Enabled = True
        End If


    End Sub
End Class