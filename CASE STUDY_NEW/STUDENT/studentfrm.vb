Public Class studentfrm
    Public Property StudentId As String

    Private Sub LoadFormInPanel(childForm As Form)


        studentPanel.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        studentPanel.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub studentsubjectsBtn_Click(sender As Object, e As EventArgs) Handles studentsubjectsBtn.Click


        Dim subjectsForm As New student_subjetcs()
        subjectsForm.StudentId = StudentId
        LoadFormInPanel(subjectsForm)
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        LoadFormInPanel(New student_settings)
    End Sub

End Class