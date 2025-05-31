Public Class teacherfrm

    Private Sub LoadFormInPanel(childForm As Form)
        teacherPanel.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        teacherPanel.Controls.Add(childForm)
        childForm.Show()
    End Sub


    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Application.Exit()
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        LoadFormInPanel(New dashboard())
    End Sub



    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        LoadFormInPanel(New teacher_settings)
    End Sub

    Private Sub gradeEntryBtn_Click(sender As Object, e As EventArgs) Handles gradeEntryBtn.Click
        LoadFormInPanel(New teacher_gradeentry)
    End Sub

    Private Sub teacherfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormInPanel(New dashboard())
    End Sub

    Private Sub courseManagementBtn_Click(sender As Object, e As EventArgs)
        LoadFormInPanel(New dean_courseManagement)
    End Sub



End Class