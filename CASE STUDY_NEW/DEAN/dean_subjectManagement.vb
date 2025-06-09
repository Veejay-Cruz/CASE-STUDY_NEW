Imports MySql.Data.MySqlClient

Public Class dean_subjectManagement

    Private connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"


    Private Sub dean_subjectManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAcademicPeriodLabels()
        LoadTeachersForDepartment()
        createPnl2.Visible = False
    End Sub

    Private Sub UpdateAcademicPeriodLabels()
        ' Get current school year and semester
        Dim currentSchoolYear As String = ""
        Dim currentSemester As String = ""
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Get current school year
                Using cmdYear As New MySqlCommand("SELECT school_year FROM school_year_table WHERE status = 'Open'", conn)
                    Dim currentYear = Convert.ToString(cmdYear.ExecuteScalar())
                    lblSchoolyr.Text = If(String.IsNullOrEmpty(currentYear), "No Active School Year", currentYear)
                End Using

                ' Get current semester
                Using cmdSem As New MySqlCommand("SELECT semester FROM semester_table WHERE status = 'Open'", conn)
                    Dim currentSem = Convert.ToString(cmdSem.ExecuteScalar())
                    lblSem.Text = If(String.IsNullOrEmpty(currentSem), "No Active Semester", currentSem)
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error updating academic period labels: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub LoadTeachersForDepartment()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                ' Get the current dean's department
                Dim deptQuery As String = "SELECT department_id FROM teacher_table WHERE teacher_id = @teacherId"
                Dim deptCmd As New MySqlCommand(deptQuery, conn)
                deptCmd.Parameters.AddWithValue("@teacherId", Login.CurrentTeacherID)
                Dim departmentId As String = Convert.ToString(deptCmd.ExecuteScalar())

                ' Get all teachers in this department
                Dim teacherQuery As String = "SELECT teacher_id, last_name, first_name FROM teacher_table WHERE department_id = @deptId"
                Using da As New MySqlDataAdapter(teacherQuery, conn)
                    da.SelectCommand.Parameters.AddWithValue("@deptId", departmentId)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    DGVDepartment.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading teachers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DGVDepartment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDepartment.CellContentClick
        If e.ColumnIndex = DGVDepartment.Columns("apply").Index AndAlso e.RowIndex >= 0 Then
            ' Get selected teacher's info
            Dim selectedRow As DataGridViewRow = DGVDepartment.Rows(e.RowIndex)
            Dim teacherId As String = selectedRow.Cells("teach_id").Value.ToString()
            Dim lastName As String = selectedRow.Cells("lname").Value.ToString()
            Dim firstName As String = selectedRow.Cells("fname").Value.ToString()

            ' Show panel and initialize textboxes
            createPnl2.Visible = True
            createPnl2.BringToFront()
            txtprofid.Text = teacherId
            txtLname.Text = lastName
            txtFname.Text = firstName
        End If

        LoadSubjectsForTeacherDepartment()

    End Sub

    Private Sub LoadSubjectsForTeacherDepartment()
        cboSubject.Items.Clear()
        If String.IsNullOrEmpty(txtprofid.Text) Then Exit Sub

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Get department of the selected teacher
                Dim deptQuery As String = "SELECT department_id FROM teacher_table WHERE teacher_id = @teacherId"
                Dim deptCmd As New MySqlCommand(deptQuery, conn)
                deptCmd.Parameters.AddWithValue("@teacherId", txtprofid.Text)
                Dim departmentId As String = Convert.ToString(deptCmd.ExecuteScalar())

                ' Get course codes for this department
                Dim courseQuery As String = "SELECT course_code FROM courses WHERE department_id = @deptId"
                Dim courseCmd As New MySqlCommand(courseQuery, conn)
                courseCmd.Parameters.AddWithValue("@deptId", departmentId)
                Dim courseCodes As New List(Of String)
                Using reader As MySqlDataReader = courseCmd.ExecuteReader()
                    While reader.Read()
                        courseCodes.Add(reader("course_code").ToString())
                    End While
                End Using

                If courseCodes.Count = 0 Then Exit Sub

                ' Get subject codes for these courses
                Dim subjectQuery As String = "SELECT sub_code FROM subjects WHERE course IN (" & String.Join(",", courseCodes.Select(Function(c) "'" & c & "'")) & ")"
                Dim subjectCmd As New MySqlCommand(subjectQuery, conn)
                Using reader As MySqlDataReader = subjectCmd.ExecuteReader()
                    While reader.Read()
                        cboSubject.Items.Add(reader("sub_code").ToString())
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading subjects: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cboSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubject.SelectedIndexChanged
        LoadSectionsForSubject()
    End Sub


    Private Sub LoadSectionsForSubject()
        cboSection.Items.Clear()
        If cboSubject.SelectedItem Is Nothing Then Exit Sub

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Get the course and year_level of the selected subject
                Dim subjectQuery As String = "SELECT course, year_level FROM subjects WHERE sub_code = @subCode"
                Dim subjectCmd As New MySqlCommand(subjectQuery, conn)
                subjectCmd.Parameters.AddWithValue("@subCode", cboSubject.SelectedItem.ToString())
                Dim courseCode As String = ""
                Dim yearLevel As String = ""
                Using reader As MySqlDataReader = subjectCmd.ExecuteReader()
                    If reader.Read() Then
                        courseCode = reader("course").ToString()
                        yearLevel = reader("year_level").ToString()
                    End If
                End Using

                If String.IsNullOrEmpty(courseCode) OrElse String.IsNullOrEmpty(yearLevel) Then Exit Sub

                ' Get the current semester
                Dim currentSemester As String = ""
                Dim semQuery As String = "SELECT semester FROM semester_table WHERE status = 'Open' LIMIT 1"
                Using semCmd As New MySqlCommand(semQuery, conn)
                    currentSemester = Convert.ToString(semCmd.ExecuteScalar())
                End Using

                If String.IsNullOrEmpty(currentSemester) Then Exit Sub

                ' Get sections for this course, year_level, and current semester
                Dim sectionQuery As String = "SELECT section FROM student_section WHERE course_code = @courseCode AND yearlevel = @yearLevel AND semester = @semester"
                Using sectionCmd As New MySqlCommand(sectionQuery, conn)
                    sectionCmd.Parameters.AddWithValue("@courseCode", courseCode)
                    sectionCmd.Parameters.AddWithValue("@yearLevel", yearLevel)
                    sectionCmd.Parameters.AddWithValue("@semester", currentSemester)
                    Using reader As MySqlDataReader = sectionCmd.ExecuteReader()
                        While reader.Read()
                            cboSection.Items.Add(reader("section").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading sections: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        createPnl2.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class