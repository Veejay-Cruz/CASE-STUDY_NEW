Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Login
    ' Declare a public variable to store the current teacher ID
    Public Shared CurrentTeacherID As String
    Public Shared CurrentUserRole As String
    Public Shared CurrentStudentID As String
    Public Shared CurrentDeanDepartmentID As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        usernameTxt.Focus()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"
        Dim idInput As String = usernameTxt.Text.Trim()
        Dim passwordInput As String = passwordTxt.Text.Trim()

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Check admin table
                Dim adminCmd As New MySqlCommand("SELECT * FROM admin WHERE id=@id AND password=@password", conn)
                adminCmd.Parameters.AddWithValue("@id", idInput)
                adminCmd.Parameters.AddWithValue("@password", passwordInput)

                Dim adminDr As MySqlDataReader = adminCmd.ExecuteReader()

                If adminDr.Read() Then
                    MsgBox("Login Success! Welcome Admin.", MsgBoxStyle.Information)
                    Dim id As String = adminDr("id").ToString().Trim()
                    usernameLbl.Text = id
                    CurrentUserRole = "Admin"
                    adminDr.Close()
                    Me.Hide()
                    main.Show()
                    Return
                End If
                adminDr.Close()

                ' Check teacher_table and if they are a dean
                Dim teacherCmd As New MySqlCommand("SELECT * FROM teacher_table WHERE teacher_id=@teacher_id AND password=@password", conn)
                teacherCmd.Parameters.AddWithValue("@teacher_id", idInput)
                teacherCmd.Parameters.AddWithValue("@password", passwordInput)

                Dim teacherDr As MySqlDataReader = teacherCmd.ExecuteReader()

                If teacherDr.Read() Then
                    Dim teacherId As String = teacherDr("teacher_id").ToString().Trim()
                    Dim isDean As String = teacherDr("is_Dean").ToString()
                    Dim departmentId As String = teacherDr("department_id").ToString().Trim()

                    CurrentTeacherID = teacherId
                    usernameLbl.Text = teacherId

                    If isDean = "dean" Then
                        MsgBox("Login Success! Welcome Dean.", MsgBoxStyle.Information)
                        CurrentUserRole = "Dean"
                        CurrentDeanDepartmentID = departmentId
                        teacherDr.Close()
                        Me.Hide()
                        deanfrm.Show()

                    Else
                        MsgBox("Login Success! Welcome Teacher.", MsgBoxStyle.Information)
                        CurrentUserRole = "Teacher"
                        teacherDr.Close()
                        Me.Hide()
                        teacherfrm.Show()
                    End If
                    Return
                End If
                teacherDr.Close()

                ' Check student table
                Dim studentCmd As New MySqlCommand("SELECT * FROM students WHERE stud_id=@stud_id AND password=@password", conn)
                studentCmd.Parameters.AddWithValue("stud_id", idInput)
                studentCmd.Parameters.AddWithValue("@password", passwordInput)

                Dim studentDr As MySqlDataReader = studentCmd.ExecuteReader()

                If studentDr.Read() Then
                    MsgBox("Login Success! Welcome Student.", MsgBoxStyle.Information)
                    Dim studId As String = studentDr("stud_id").ToString().Trim()
                    CurrentStudentID = studId
                    usernameLbl.Text = studId
                    CurrentUserRole = "Student"
                    studentDr.Close()
                    Me.Hide()
                    student_grades.Show()
                    Return
                End If
                studentDr.Close()

                ' Check registrar table
                Dim registrarCmd As New MySqlCommand("SELECT * FROM registrar WHERE registrar_id=@id AND password=@password", conn)
                registrarCmd.Parameters.AddWithValue("@id", idInput)
                registrarCmd.Parameters.AddWithValue("@password", passwordInput)

                Dim registrarDr As MySqlDataReader = registrarCmd.ExecuteReader()

                If registrarDr.Read() Then
                    MsgBox("Login Success! Welcome Registrar.", MsgBoxStyle.Information)
                    Dim registrarId As String = registrarDr("registrar_id").ToString().Trim()
                    usernameLbl.Text = registrarId
                    CurrentUserRole = "Registrar"
                    registrarDr.Close()
                    Me.Hide()
                    registrarfrm.Show()
                    Return
                End If

                ' If no match found
                MsgBox("Invalid ID or password", MsgBoxStyle.Critical, "Login Failed")
            End Using

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


End Class
