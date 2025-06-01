Imports MySql.Data.MySqlClient

Public Class dean_sectionManagement

    Private connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"

    Private Sub createLbl_Click(sender As Object, e As EventArgs) Handles createLbl.Click
        createPnl2.Visible = True
        createPnl2.BringToFront()
        LoadCoursesForDepartment()
    End Sub

    Private Sub LoadSections()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                ' Get the dean's department
                Dim deptQuery As String = "SELECT department_id FROM teacher_table WHERE teacher_id = @teacherId"
                Dim deptCmd As New MySqlCommand(deptQuery, conn)
                deptCmd.Parameters.AddWithValue("@teacherId", Login.CurrentTeacherID)
                Dim departmentId As String = Convert.ToString(deptCmd.ExecuteScalar())

                ' Get sections for courses in dean's department
                Dim query As String = "SELECT s.course_code, s.section, s.yearlevel, s.semester, s.schedule, s.class " &
                                "FROM student_section s " &
                                "INNER JOIN courses c ON s.course_code = c.course_code " &
                                "WHERE c.department_id = @deptId " &
                                "ORDER BY s.course_code, s.section"

                Using da As New MySqlDataAdapter()
                    da.SelectCommand = New MySqlCommand(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@deptId", departmentId)

                    Dim dt As New DataTable()
                    da.Fill(dt)
                    DGVSection.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sections: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCoursesForDepartment()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                ' First get the department of the current dean
                Dim deptQuery As String = "SELECT department_id FROM teacher_table WHERE teacher_id = @teacherId"
                Dim deptCmd As New MySqlCommand(deptQuery, conn)
                deptCmd.Parameters.AddWithValue("@teacherId", Login.CurrentTeacherID)

                Dim departmentId As String = Convert.ToString(deptCmd.ExecuteScalar())

                ' Then get all courses for this department
                Dim courseQuery As String = "SELECT course_code FROM courses WHERE department_id = @deptId AND status = 'Active'"
                Dim courseCmd As New MySqlCommand(courseQuery, conn)
                courseCmd.Parameters.AddWithValue("@deptId", departmentId)

                Using reader As MySqlDataReader = courseCmd.ExecuteReader()
                    cboCourse.Items.Clear()
                    While reader.Read()
                        cboCourse.Items.Add(reader("course_code").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading courses: " & ex.Message)
        End Try
    End Sub

    Private Sub dean_sectionManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        createPnl2.Visible = False

        LoadCoursesForDepartment()
        LoadSections()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(cboCourse.Text) OrElse
           String.IsNullOrEmpty(cboYrlvl.Text) OrElse
           String.IsNullOrEmpty(cboSEMESTER.Text) OrElse
           String.IsNullOrEmpty(cboSched.Text) OrElse
           String.IsNullOrEmpty(TXTMclass.Text) Then
            MessageBox.Show("Please fill in all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Create section code based on inputs
        ' Example: 1st Year, 1st Sem, Morning, Class 1 = 11M1
        Dim yearCode As String = cboYrlvl.Text.Substring(0, 1)
        Dim semCode As String = cboSEMESTER.Text.Substring(0, 1)
        Dim schedCode As String = cboSched.Text.Substring(0, 1)
        Dim sectionCode As String = yearCode & semCode & schedCode & TXTMclass.Text

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Check if section already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM student_section WHERE section = @section AND course_code = @courseCode"
                Dim checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@section", sectionCode)
                checkCmd.Parameters.AddWithValue("@courseCode", cboCourse.Text)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Section " & sectionCode & " already exists for " & cboCourse.Text & "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insert new section
                Dim insertQuery As String = "INSERT INTO student_section (course_code, section, yearlevel, semester, schedule, class) VALUES (@courseCode, @section, @yearLevel, @semester, @schedule, @class)"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@courseCode", cboCourse.Text)
                    cmd.Parameters.AddWithValue("@section", sectionCode)
                    cmd.Parameters.AddWithValue("@yearLevel", cboYrlvl.Text)
                    cmd.Parameters.AddWithValue("@semester", cboSEMESTER.Text)
                    cmd.Parameters.AddWithValue("@schedule", cboSched.Text)
                    cmd.Parameters.AddWithValue("@class", TXTMclass.Text)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Section " & sectionCode & " has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                createPnl2.Visible = False
                LoadSections()

            Catch ex As Exception
                MessageBox.Show("Error creating section: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClearFields()
        cboCourse.SelectedIndex = -1
        cboYrlvl.SelectedIndex = -1
        cboSEMESTER.SelectedIndex = -1
        cboSched.SelectedIndex = -1
        TXTMclass.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        createPnl2.Visible = False
        ClearFields()
    End Sub
End Class