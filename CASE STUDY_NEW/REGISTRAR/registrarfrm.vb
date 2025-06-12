Public Class registrarfrm

    Private Sub LoadFormInPanel(childForm As Form)
        mainPanel.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainPanel.Controls.Add(childForm)
        childForm.Show()
    End Sub
    Private Sub syBtn_Click(sender As Object, e As EventArgs) Handles syBtn.Click
        LoadFormInPanel(New schoolyear())
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        LoadFormInPanel(New dashboard())
    End Sub

    Private Sub studBtn_Click(sender As Object, e As EventArgs) Handles studBtn.Click
        LoadFormInPanel(New studentManagement())
    End Sub

    Private Sub courseBtn_Click(sender As Object, e As EventArgs) Handles courseBtn.Click
        LoadFormInPanel(New courses())
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Application.Exit()
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        LoadFormInPanel(New department())
    End Sub

    Private Sub registrarfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormInPanel(New dashboard)
    End Sub

    Private Sub subjectBtn_Click(sender As Object, e As EventArgs) Handles subjectBtn.Click
        LoadFormInPanel(New subjects())
    End Sub
End Class