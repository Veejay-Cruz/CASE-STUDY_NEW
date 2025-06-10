Public Class main

    Private Sub LoadFormInPanel(childForm As Form)
        mainPanel.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainPanel.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub closeLbl_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub studBtn_Click(sender As Object, e As EventArgs) Handles studBtn.Click
        LoadFormInPanel(New studentManagement())
    End Sub

    Private Sub subjectBtn_Click_1(sender As Object, e As EventArgs) Handles subjectBtn.Click
        LoadFormInPanel(New subjects())
    End Sub

    Private Sub courseBtn_Click_1(sender As Object, e As EventArgs) Handles courseBtn.Click
        LoadFormInPanel(New courses())
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        LoadFormInPanel(New dashboard())
    End Sub


    Private Sub auditBtn_Click(sender As Object, e As EventArgs) Handles auditBtn.Click
        LoadFormInPanel(New audit_trail())
    End Sub

    Private Sub usersBtn_Click(sender As Object, e As EventArgs) Handles usersBtn.Click
        LoadFormInPanel(New users)
    End Sub

    Private Sub syBtn_Click(sender As Object, e As EventArgs) Handles syBtn.Click
        LoadFormInPanel(New schoolyear())
    End Sub

    Private Sub logoutBtn_Click_1(sender As Object, e As EventArgs) Handles logoutBtn.Click
        '   Dim connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"

        '   Try
        '  Using conn As New MySqlConnection(connString)
        '             conn.Open()

        'Dim username As String = Login.usernameLbl.Text
        'Dim action As String = "LOGOUT"
        'Dim date_time As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        'Dim auditCmd As New MySqlCommand("INSERT INTO audit_trail (username, action, date_time) VALUES (@username, @action, @date_time)", conn)
        '           auditCmd.Parameters.AddWithValue("@username", username)
        '          auditCmd.Parameters.AddWithValue("@action", action)
        '         auditCmd.Parameters.AddWithValue("@date_time", date_time)
        '        auditCmd.ExecuteNonQuery()
        'End Using

        Application.Exit()

        'Catch ex As Exception
        '       MsgBox("An error occurred while logging out: " & ex.Message, MsgBoxStyle.Critical)
        'End Try
    End Sub


    Private Sub reportsBtn_Click(sender As Object, e As EventArgs)
        'reports.show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        LoadFormInPanel(New department())
    End Sub
End Class

