Imports MySql.Data.MySqlClient

Public Class dean_subjectManagement

    Private connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"


    Private Sub dean_subjectManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAcademicPeriodLabels()
        LoadTeachersForDepartment()
        createPnl2.Visible = False
        LoadTeacherSubjects()
    End Sub


    Private Sub LoadTeacherSubjects()
        'DGVSection.Rows.Clear()
        'DGVSection.Columns.Clear()

        '' Add columns if not already present
        'DGVSection.Columns.Add("profid", "Teacher ID")
        'DGVSection.Columns.Add("lname", "Last Name")
        'DGVSection.Columns.Add("fname", "First Name")
        'DGVSection.Columns.Add("subject", "Subject Code")
        'DGVSection.Columns.Add("section", "Section")
        'DGVSection.Columns.Add("course", "Course")
        'DGVSection.Columns.Add("yearlevel", "Year Level")
        'DGVSection.Columns.Add("semester", "Semester")

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Join teacher_subjects with teacher_table to get names
                Dim query As String = "SELECT ts.teacher_id, t.last_name, t.first_name, ts.sub_code, ts.section, ts.course_code, ts.yearlevel, ts.semester " &
                                  "FROM teacher_subjects ts " &
                                  "LEFT JOIN teacher_table t ON ts.teacher_id = t.teacher_id"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DGVSection.Rows.Add(
                            reader("teacher_id").ToString(),
                            reader("last_name").ToString(),
                            reader("first_name").ToString(),
                            reader("sub_code").ToString(),
                            reader("section").ToString(),
                            reader("course_code").ToString(),
                            reader("yearlevel").ToString(),
                            reader("semester").ToString()
                        )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading teacher subjects: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
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

                ' Get the current semester
                Dim currentSemester As String = ""
                Dim semQuery As String = "SELECT semester FROM semester_table WHERE status = 'Open' LIMIT 1"
                Using semCmd As New MySqlCommand(semQuery, conn)
                    currentSemester = Convert.ToString(semCmd.ExecuteScalar())
                End Using

                If String.IsNullOrEmpty(currentSemester) Then Exit Sub

                ' Get subject codes for these courses and current semester only
                Dim subjectQuery As String = "SELECT sub_code FROM subjects WHERE course IN (" & String.Join(",", courseCodes.Select(Function(c) "'" & c & "'")) & ") AND semester = @semester"
                Dim subjectCmd As New MySqlCommand(subjectQuery, conn)
                subjectCmd.Parameters.AddWithValue("@semester", currentSemester)
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

        ClearAssignmentFields()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Confirm action
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to assign this subject to the teacher?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then Exit Sub

        ' Validate input
        If String.IsNullOrEmpty(txtprofid.Text) OrElse
           String.IsNullOrEmpty(txtLname.Text) OrElse
           String.IsNullOrEmpty(txtFname.Text) OrElse
           cboSubject.SelectedItem Is Nothing OrElse
           cboSection.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim courseCode As String = ""
        Dim yearLevel As String = ""
        Dim semester As String = ""

        ' Get course, year_level, and semester of the selected subject
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim subjectQuery As String = "SELECT course, year_level, semester FROM subjects WHERE sub_code = @subCode"
                Using cmd As New MySqlCommand(subjectQuery, conn)
                    cmd.Parameters.AddWithValue("@subCode", cboSubject.SelectedItem.ToString())
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            courseCode = reader("course").ToString()
                            yearLevel = reader("year_level").ToString()
                            semester = reader("semester").ToString()
                        End If
                    End Using
                End Using

                If String.IsNullOrEmpty(courseCode) OrElse String.IsNullOrEmpty(yearLevel) OrElse String.IsNullOrEmpty(semester) Then
                    MessageBox.Show("Subject details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If


                ' Check for duplicate assignment
                Dim checkQuery As String = "SELECT COUNT(*) FROM teacher_subjects WHERE teacher_id = @teacherId AND sub_code = @subCode AND section = @section"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@teacherId", txtprofid.Text)
                    checkCmd.Parameters.AddWithValue("@subCode", cboSubject.SelectedItem.ToString())
                    checkCmd.Parameters.AddWithValue("@section", cboSection.SelectedItem.ToString())
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This teacher is already assigned to this subject and section.", "Duplicate Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using


                ' Check if any teacher is already assigned to this subject and section
                Dim checkOtherTeacherQuery As String = "SELECT COUNT(*) FROM teacher_subjects WHERE sub_code = @subCode AND section = @section"
                Using checkOtherTeacherCmd As New MySqlCommand(checkOtherTeacherQuery, conn)
                    checkOtherTeacherCmd.Parameters.AddWithValue("@subCode", cboSubject.SelectedItem.ToString())
                    checkOtherTeacherCmd.Parameters.AddWithValue("@section", cboSection.SelectedItem.ToString())
                    Dim countOther As Integer = Convert.ToInt32(checkOtherTeacherCmd.ExecuteScalar())
                    If countOther > 0 Then
                        MessageBox.Show("A teacher is already assigned to this subject and section. Only one teacher can be assigned per subject-section.", "Assignment Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using



                ' Save to teacher_subjects table
                Dim schoolYear As String = lblSchoolyr.Text
                Dim insertQuery As String = "INSERT INTO teacher_subjects (teacher_id, sub_code, course_code, section, yearlevel, semester, school_year) VALUES (@teacherId, @subCode, @courseCode, @section, @yearLevel, @semester, @schoolYear)"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@teacherId", txtprofid.Text)
                    cmd.Parameters.AddWithValue("@subCode", cboSubject.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@courseCode", courseCode)
                    cmd.Parameters.AddWithValue("@section", cboSection.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@yearLevel", yearLevel)
                    cmd.Parameters.AddWithValue("@semester", semester)
                    cmd.Parameters.AddWithValue("@schoolYear", schoolYear)
                    cmd.ExecuteNonQuery()
                End Using

                '' Add to DGVSection
                'If DGVSection.Columns.Count = 0 Then
                '    DGVSection.Columns.Add("profid", "Teacher ID")
                '    DGVSection.Columns.Add("lname", "Last Name")
                '    DGVSection.Columns.Add("fname", "First Name")
                '    DGVSection.Columns.Add("subject", "Subject Code")
                '    DGVSection.Columns.Add("section", "Section")
                '    DGVSection.Columns.Add("course", "Course")
                '    DGVSection.Columns.Add("yearlevel", "Year Level")
                '    DGVSection.Columns.Add("semester", "Semester")
                'End If
                DGVSection.Rows.Add(txtprofid.Text, txtLname.Text, txtFname.Text, cboSubject.SelectedItem.ToString(), cboSection.SelectedItem.ToString(), courseCode, yearLevel, semester)

                MessageBox.Show("Subject assigned to teacher successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearAssignmentFields()
                'LoadTeacherSubjects()
            Catch ex As Exception
                MessageBox.Show("Error saving assignment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClearAssignmentFields()
        txtprofid.Clear()
        txtLname.Clear()
        txtFname.Clear()
        cboSubject.SelectedIndex = -1
        cboSection.SelectedIndex = -1
        createPnl2.Visible = False
    End Sub

End Class