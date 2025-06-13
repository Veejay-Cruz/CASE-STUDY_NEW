Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Windows.Forms
Public Class dean_courseManagement
    Private connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"



    Private Sub dean_courseManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable and set up txtSearchStudent
        'txtSearchStudent.Enabled = True
        'txtSearchStudent.ReadOnly = False
        cboSearchStudent.AutoCompleteMode = AutoCompleteMode.None
        cboSearchStudent.AutoCompleteSource = AutoCompleteSource.None

        ' Initialize DGVSubject
        DGVSubject.AutoGenerateColumns = False

        ' Set up the DataPropertyNames for the columns
        DGVSubject.Columns("sub_id").DataPropertyName = "sub_id"
        DGVSubject.Columns("sub_code").DataPropertyName = "sub_code"
        DGVSubject.Columns("sub_name").DataPropertyName = "subject_name"
        DGVSubject.Columns("unitt").DataPropertyName = "unit"
        DGVSubject.Columns("prereqq").DataPropertyName = "prerequisite_sub_id"

        ' Initialize DGVStudentSubjects
        DGVStudentSubjects.AutoGenerateColumns = False
        DGVStudentSubjects.Columns.Clear()

        ' Add only the needed columns to DGVStudentSubjects (excluding prerequisite)
        Dim columns = New List(Of (Name As String, Header As String, DataProperty As String)) From {
            ("sub_id", "Subject ID", "sub_id"),
            ("sub_code", "Subject Code", "sub_code"),
            ("sub_name", "Subject Name", "subject_name"),
            ("unitt", "Units", "unit"),
            ("section", "Section", "section")
        }

        For Each col In columns
            Dim newCol = New DataGridViewTextBoxColumn()
            newCol.Name = col.Name
            newCol.HeaderText = col.Header
            newCol.DataPropertyName = col.DataProperty
            DGVStudentSubjects.Columns.Add(newCol)
        Next

        UpdateAcademicPeriodLabels()

        ' Set up other textboxes as read-only since they will be populated based on search
        txtStudname.ReadOnly = True
        txtStudentStatus.ReadOnly = True
        txtCourse.ReadOnly = True
        txtYearlvl.ReadOnly = True
        createPnl2.Visible = False
    End Sub


    Private Sub cboSearchStudent_KeyUp(sender As Object, e As KeyEventArgs) Handles cboSearchStudent.KeyUp
        Dim searchText As String = cboSearchStudent.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then Exit Sub

        ' Get current school year and semester from labels
        Dim currentSchoolYear As String = lblSchoolyr.Text
        Dim currentSemester As String = lblSem.Text


        ' Save caret position
        Dim caretPos As Integer = cboSearchStudent.SelectionStart


        cboSearchStudent.Items.Clear()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT DISTINCT s.stud_id " &
                                  "FROM students s " &
                                  "INNER JOIN enrollment e ON s.stud_id = e.stud_id " &
                                  "WHERE e.academic_year = @schoolYear " &
                                  "AND e.semester = @semester " &
                                  "AND (s.stud_id LIKE @search OR s.last_name LIKE @search OR s.first_name LIKE @search) " &
                                  "ORDER BY s.stud_id LIMIT 20"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@schoolYear", currentSchoolYear)
                    cmd.Parameters.AddWithValue("@semester", currentSemester)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboSearchStudent.Items.Add(reader("stud_id").ToString())
                        End While


                    End Using
                End Using
            Catch ex As Exception
                ' Optionally handle error
            End Try
        End Using
        cboSearchStudent.DroppedDown = True
        cboSearchStudent.SelectionStart = cboSearchStudent.Text.Length
        cboSearchStudent.Text = searchText
        cboSearchStudent.SelectionStart = caretPos

        cboSearchStudent.SelectionLength = 0 ' Reset selection length to 0 to avoid selecting the entire text

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

    'Private Sub SearchStudent(searchText As String)
    '    If String.IsNullOrWhiteSpace(searchText) Then
    '        ClearFields()
    '        Return
    '    End If

    '    Dim currentSchoolYear As String = lblSchoolyr.Text
    '    Dim currentSemester As String = lblSem.Text

    '    Using conn As New MySqlConnection(connString)
    '        Try
    '            conn.Open()
    '            Dim query As String = "SELECT s.* FROM students s " &
    '                              "INNER JOIN enrollment e ON s.stud_id = e.stud_id " &
    '                              "WHERE e.academic_year = @schoolYear " &
    '                              "AND e.semester = @semester " &
    '                              "AND s.stud_id = @search"
    '            Using cmd As New MySqlCommand(query, conn)
    '                cmd.Parameters.AddWithValue("@schoolYear", currentSchoolYear)
    '                cmd.Parameters.AddWithValue("@semester", currentSemester)
    '                cmd.Parameters.AddWithValue("@search", searchText)
    '                Using reader As MySqlDataReader = cmd.ExecuteReader()
    '                    If reader.Read() Then
    '                        txtStudname.Text = $"{reader("last_name")}, {reader("first_name")} {reader("middle_name")}"
    '                        txtStudentStatus.Text = reader("status").ToString()
    '                        txtCourse.Text = reader("course_code").ToString()
    '                        txtYearlvl.Text = reader("year_level").ToString()
    '                        DGVSubject.DataSource = Nothing
    '                    End If
    '                End Using
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("Error searching student: " & ex.Message)
    '        End Try
    '    End Using
    'End Sub

    Private Sub LoadSubjectsForCourse(courseCode As String)
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT sub_id, sub_code, subject_name, unit, prerequisite_sub_id FROM subjects WHERE course = @course OR course = 'General Education'"

                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@course", courseCode)

                    Dim dt As New DataTable()
                    da.Fill(dt)
                    DGVSubject.DataSource = dt
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading subjects: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ClearFields()
        cboSearchStudent.Text = String.Empty
        txtStudname.Clear()
        txtStudentStatus.Clear()
        txtCourse.Clear()
        txtYearlvl.Clear()
        DGVSubject.DataSource = Nothing
        DGVStudentSubjects.DataSource = Nothing
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrWhiteSpace(txtStudname.Text) Then
            MessageBox.Show("Please search and select a student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        ' Get current semester
        Dim currentSemester = ""
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Using cmdSem As New MySqlCommand("SELECT semester FROM semester_table WHERE status = 'Open'", conn)
                    currentSemester = Convert.ToString(cmdSem.ExecuteScalar)
                    If String.IsNullOrEmpty(currentSemester) Then
                        MessageBox.Show("No active semester found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error getting current semester: " & ex.Message)
                Return
            End Try
        End Using

        ' Load subjects based on course, year level and semester
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim deanDepartmentId As String = Login.CurrentDeanDepartmentID
                Dim query As String = ""
                If deanDepartmentId = "GEN ED" Then
                    query = "SELECT sub_id, sub_code, subject_name, unit, prerequisite_sub_id " &
            "FROM subjects " &
            "WHERE course = 'GEN ED' " &
            "AND year_level = @yearLevel " &
            "AND semester = @semester " &
            "AND sub_id NOT IN (SELECT sub_id FROM student_subjects WHERE stud_id = @studId AND school_year = @schoolYear AND semester = @semester)"
                Else
                    query = "SELECT sub_id, sub_code, subject_name, unit, prerequisite_sub_id " &
            "FROM subjects " &
            "WHERE course = @course " &
            "AND year_level = @yearLevel " &
            "AND semester = @semester " &
            "AND sub_id NOT IN (SELECT sub_id FROM student_subjects WHERE stud_id = @studId AND school_year = @schoolYear AND semester = @semester)"
                End If

                Using da As New MySqlDataAdapter
                    da.SelectCommand = New MySqlCommand(query, conn)
                    If deanDepartmentId <> "GEN ED" Then
                        da.SelectCommand.Parameters.AddWithValue("@course", txtCourse.Text)
                    End If
                    'da.SelectCommand.Parameters.AddWithValue("@course", txtCourse.Text)
                    da.SelectCommand.Parameters.AddWithValue("@yearLevel", txtYearlvl.Text)
                    da.SelectCommand.Parameters.AddWithValue("@semester", currentSemester)


                    da.SelectCommand.Parameters.AddWithValue("@studId", cboSearchStudent.Text)
                    da.SelectCommand.Parameters.AddWithValue("@schoolYear", lblSchoolyr.Text)


                    Dim dt As New DataTable
                    da.Fill(dt)

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No subjects found for the selected criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    DGVSubject.DataSource = dt
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading subjects: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadSectionsForStudent()
        If String.IsNullOrWhiteSpace(txtCourse.Text) OrElse String.IsNullOrWhiteSpace(txtYearlvl.Text) Then
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Get current semester
                Dim currentSemester As String = lblSem.Text

                ' Clear existing items
                cboSection.Items.Clear()

                ' Get sections based on year level and semester
                Dim query As String = "SELECT section FROM student_section " &
                                    "WHERE yearlevel = @yearLevel " &
                                    "AND semester = @semester " &
                                    "AND course_code = @courseCode " &
                                    "ORDER BY section"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@yearLevel", txtYearlvl.Text)
                    cmd.Parameters.AddWithValue("@semester", currentSemester)
                    cmd.Parameters.AddWithValue("@courseCode", txtCourse.Text)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboSection.Items.Add(reader("section").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sections: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnApplySub_Click(sender As Object, e As EventArgs) Handles btnApplySub.Click

        createPnl2.Visible = True
        LoadSectionsForStudent()

        If String.IsNullOrWhiteSpace(cboSearchStudent.Text) Then
            MessageBox.Show("Please select a student first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check prerequisites
        If Not CheckPrerequisites() Then
            Return
        End If

        ' Create DataTable for student subjects if it doesn't exist
        If DGVStudentSubjects.DataSource Is Nothing Then
            Dim dt As New DataTable()
            dt.Columns.Add("sub_id")
            dt.Columns.Add("sub_code")
            dt.Columns.Add("subject_name")
            dt.Columns.Add("unit")
            dt.Columns.Add("section")
            DGVStudentSubjects.DataSource = dt
        End If
    End Sub

    Private Function CheckPrerequisites() As Boolean
        For Each row As DataGridViewRow In DGVSubject.SelectedRows
            Dim prerequisite As String = If(row.Cells("prereqq").Value IsNot Nothing, row.Cells("prereqq").Value.ToString(), "")

            ' Check year level prerequisite
            If prerequisite.Contains("Yr") OrElse prerequisite.Contains("Year") Then
                Dim studentYearLevel As Integer = GetYearLevel(txtYearlvl.Text)
                Dim requiredYear As Integer = GetYearLevel(prerequisite)

                If studentYearLevel < requiredYear Then
                    MessageBox.Show($"Student does not meet the year level requirement for {row.Cells("sub_code").Value}. Required: {prerequisite}", "Prerequisite Not Met", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End If

            ' Add other prerequisite checks here if needed
        Next
        Return True
    End Function

    Private Function GetYearLevel(yearText As String) As Integer
        If yearText.Contains("1st") OrElse yearText.Contains("First") Then Return 1
        If yearText.Contains("2nd") OrElse yearText.Contains("Second") Then Return 2
        If yearText.Contains("3rd") OrElse yearText.Contains("Third") Then Return 3
        If yearText.Contains("4th") OrElse yearText.Contains("Fourth") Then Return 4
        Return 0
    End Function

    Private Function VerifySection(section As String, yearLevel As String) As Boolean
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM student_section WHERE section = @section AND yearlevel = @yearLevel"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@section", section)
                    cmd.Parameters.AddWithValue("@yearLevel", yearLevel)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            Catch ex As Exception
                MessageBox.Show("Error verifying section: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Sub btnConfirmSub_Click(sender As Object, e As EventArgs) Handles btnConfirmSub.Click
        If String.IsNullOrWhiteSpace(cboSearchStudent.Text) Then
            MessageBox.Show("Please select a student first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DGVStudentSubjects.Rows.Count = 0 Then
            MessageBox.Show("Please add subjects before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' Get current school year and semester
                    Dim currentSchoolYear As String = lblSchoolyr.Text
                    Dim currentSemester As String = lblSem.Text

                    ' Delete existing subjects for this student in the current semester and school year
                    Dim deleteCmd As New MySqlCommand(
                        "DELETE FROM student_subjects WHERE stud_id = @studId AND school_year = @schoolYear AND semester = @semester",
                        conn, transaction)
                    deleteCmd.Parameters.AddWithValue("@studId", cboSearchStudent.Text)
                    deleteCmd.Parameters.AddWithValue("@schoolYear", currentSchoolYear)
                    deleteCmd.Parameters.AddWithValue("@semester", currentSemester)
                    deleteCmd.ExecuteNonQuery()

                    ' Insert new subjects
                    Dim insertCmd As New MySqlCommand(
                    "INSERT INTO student_subjects (stud_id, sub_id, sub_code, subject_name, school_year, semester, section) VALUES (@studId, @subId, @subCode, @subjectName, @schoolYear, @semester, @section)",
                     conn, transaction)

                    For Each row As DataGridViewRow In DGVStudentSubjects.Rows
                        If Not row.IsNewRow Then




                            ' Check if subject already exists for this student
                            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM student_subjects WHERE stud_id = @studId AND sub_id = @subId AND school_year = @schoolYear AND semester = @semester", conn, transaction)
                            checkCmd.Parameters.AddWithValue("@studId", cboSearchStudent.Text)
                            checkCmd.Parameters.AddWithValue("@subId", row.Cells("sub_id").Value)
                            checkCmd.Parameters.AddWithValue("@schoolYear", currentSchoolYear)
                            checkCmd.Parameters.AddWithValue("@semester", currentSemester)
                            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                            If exists > 0 Then
                                ' Optionally show a message or skip
                                MessageBox.Show($"Subject {row.Cells("sub_code").Value} is already assigned to this student for the current semester and school year.", "Duplicate Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Continue For
                            End If



                            insertCmd.Parameters.Clear()
                            insertCmd.Parameters.AddWithValue("@studId", cboSearchStudent.Text)
                            insertCmd.Parameters.AddWithValue("@subId", row.Cells("sub_id").Value)
                            insertCmd.Parameters.AddWithValue("@subCode", row.Cells("sub_code").Value)
                            insertCmd.Parameters.AddWithValue("@subjectName", row.Cells("sub_name").Value)
                            insertCmd.Parameters.AddWithValue("@schoolYear", currentSchoolYear)
                            insertCmd.Parameters.AddWithValue("@semester", currentSemester)
                            insertCmd.Parameters.AddWithValue("@section", row.Cells("section").Value)
                            insertCmd.ExecuteNonQuery()
                        End If
                    Next

                    transaction.Commit()
                    MessageBox.Show("Subjects have been successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear the student subjects grid
                    DGVStudentSubjects.DataSource = Nothing
                    ' Optionally clear the search/student info
                    ClearFields()

                Catch ex As Exception
                    transaction.Rollback()
                    Throw
                End Try

            Catch ex As Exception
                MessageBox.Show("Error saving subjects: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(cboSection.Text) Then
            MessageBox.Show("Please select a section.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If




        If DGVStudentSubjects.DataSource Is Nothing Then
            Dim dt As New DataTable()
            dt.Columns.Add("sub_id")
            dt.Columns.Add("sub_code")
            dt.Columns.Add("subject_name")
            dt.Columns.Add("unit")
            dt.Columns.Add("section")
            DGVStudentSubjects.DataSource = dt
        End If




        Dim studentSubjectsTable As DataTable = DirectCast(DGVStudentSubjects.DataSource, DataTable)


        Dim subjectAdded As Boolean = False


        If txtStudentStatus.Text.Trim().ToUpper() = "REGULAR" Then
            ' For Regular students - apply selected section to all subjects
            For Each row As DataGridViewRow In DGVSubject.Rows
                If Not row.IsNewRow Then





                    Dim subId As String = row.Cells("sub_id").Value.ToString()
                    ' Check for duplicate
                    Dim foundRows = studentSubjectsTable.Select($"sub_id = '{subId.Replace("'", "''")}'")
                    If foundRows.Length > 0 Then
                        MessageBox.Show($"Subject {row.Cells("sub_code").Value} is already added.", "Duplicate Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If





                    Dim newRow As DataRow = studentSubjectsTable.NewRow()
                    newRow("sub_id") = row.Cells("sub_id").Value
                    newRow("sub_code") = row.Cells("sub_code").Value
                    newRow("subject_name") = row.Cells("sub_name").Value
                    newRow("unit") = row.Cells("unitt").Value
                    newRow("section") = cboSection.Text
                    studentSubjectsTable.Rows.Add(newRow)


                    subjectAdded = True
                End If
            Next
            createPnl2.Visible = False
        Else
            ' For Irregular students - handle selected subjects only
            For Each row As DataGridViewRow In DGVSubject.SelectedRows


                Dim subId As String = row.Cells("sub_id").Value.ToString()
                ' Check for duplicate
                Dim foundRows = studentSubjectsTable.Select($"sub_id = '{subId.Replace("'", "''")}'")
                If foundRows.Length > 0 Then
                    MessageBox.Show($"Subject {row.Cells("sub_code").Value} is already added.", "Duplicate Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Continue For
                End If



                Dim newRow As DataRow = studentSubjectsTable.NewRow()
                newRow("sub_id") = row.Cells("sub_id").Value
                newRow("sub_code") = row.Cells("sub_code").Value
                newRow("subject_name") = row.Cells("sub_name").Value
                newRow("unit") = row.Cells("unitt").Value
                newRow("section") = cboSection.Text
                studentSubjectsTable.Rows.Add(newRow)

                subjectAdded = True
            Next
            createPnl2.Visible = False
        End If

        ' Refresh the display
        DGVStudentSubjects.Refresh()

        If subjectAdded Then
            MessageBox.Show("Subjects have been added with the selected section.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        createPnl2.Visible = False
    End Sub

    Private Sub DGVSubject_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSubject.CellClick
        ' Only for IRREGULAR students
        If txtStudentStatus.Text.Trim().ToUpper() = "IRREGULAR" Then
            If e.RowIndex >= 0 Then
                createPnl2.Visible = True
                LoadSectionsForStudent()
            End If
        End If
    End Sub

    Private Sub cboSearchStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchStudent.SelectedIndexChanged
        Dim selectedId As String = cboSearchStudent.Text.Trim()
        If String.IsNullOrEmpty(selectedId) Then Exit Sub

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM students WHERE stud_id = @stud_id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@stud_id", selectedId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtStudname.Text = $"{reader("last_name")}, {reader("first_name")} {reader("middle_name")}"
                            txtStudentStatus.Text = reader("status").ToString()
                            txtCourse.Text = reader("course_code").ToString()
                            txtYearlvl.Text = reader("year_level").ToString()
                        Else
                            txtStudname.Clear()
                            txtStudentStatus.Clear()
                            txtCourse.Clear()
                            txtYearlvl.Clear()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading student info: " & ex.Message)
            End Try
        End Using
    End Sub


End Class