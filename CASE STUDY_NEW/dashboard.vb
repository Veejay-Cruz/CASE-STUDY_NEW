Imports MySql.Data.MySqlClient

Public Class dashboard
    Dim conn As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=loa_grading_system")
    Dim cmd As MySqlCommand
    Dim count As Integer


    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Hide
        main.Show
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetStudentCount()
        GetSubjectCount()
        GetCourseCount()
    End Sub

    Private Sub GetStudentCount()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT COUNT(*) FROM students", conn)
            count = Convert.ToInt32(cmd.ExecuteScalar())
            students.Text = count.ToString()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub GetSubjectCount()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT COUNT(*) FROM subjects", conn)
            count = Convert.ToInt32(cmd.ExecuteScalar())
            subjects.Text = count.ToString()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub GetCourseCount()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT COUNT(*) FROM courses", conn)
            count = Convert.ToInt32(cmd.ExecuteScalar())
            courses.Text = count.ToString()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)
        Hide()
        main.Show()
    End Sub
End Class
