Public Class deanfrm

    Private Sub LoadFormInPanel(childForm As Form)
        mainPanel.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainPanel.Controls.Add(childForm)
        childForm.Show()
    End Sub
    Private Sub coursemanagementBtn_Click(sender As Object, e As EventArgs) Handles coursemanagementBtn.Click
        LoadFormInPanel(New dean_courseManagement())
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        LoadFormInPanel(New dashboard())
    End Sub

    Private Sub gradeentryBtn_Click(sender As Object, e As EventArgs) Handles gradeentryBtn.Click
        LoadFormInPanel(New teacher_gradeentry())
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Application.Exit()
    End Sub

    Private Sub sectionBtn_Click(sender As Object, e As EventArgs) Handles sectionBtn.Click
        LoadFormInPanel(New dean_sectionManagement())
    End Sub
End Class