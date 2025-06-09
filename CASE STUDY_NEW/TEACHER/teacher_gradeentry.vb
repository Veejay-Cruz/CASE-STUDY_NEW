Imports MySql.Data.MySqlClient

Public Class teacher_gradeentry
    Private connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"
    Private Sub teacher_gradeentry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAcademicPeriodLabels()
        LoadTeachingLoads()
    End Sub


    Private Sub UpdateAcademicPeriodLabels()
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

                ' Get current term
                Using cmdTerm As New MySqlCommand("SELECT term FROM term_table WHERE status = 'Open'", conn)
                    Dim currentTerm = Convert.ToString(cmdTerm.ExecuteScalar())
                    lblTerm.Text = If(String.IsNullOrEmpty(currentTerm), "No Active Term", currentTerm)
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error updating academic period labels: " & ex.Message)
            End Try
            'SetGradeEntryColumnEditability()
        End Using
    End Sub

    'TEACHING LOADS HEHE
    Private Sub LoadTeachingLoads()
        'DGVTeachingloads.Rows.Clear()
        'DGVTeachingloads.Columns.Clear()

        '' Add columns if not already present
        'DGVTeachingloads.Columns.Add("course_code", "Course Code")
        'DGVTeachingloads.Columns.Add("sub_code", "Subject Code")
        'DGVTeachingloads.Columns.Add("section", "Section")

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT course_code, sub_code, section FROM teacher_subjects WHERE teacher_id = @teacherId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@teacherId", Login.CurrentTeacherID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DGVTeachingloads.Rows.Add(
                                reader("course_code").ToString(),
                                reader("sub_code").ToString(),
                                reader("section").ToString()
                            )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading teaching loads: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub DGVTeachingloads_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTeachingloads.CellContentClick
        If e.ColumnIndex = DGVTeachingloads.Columns("subload").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGVTeachingloads.Rows(e.RowIndex)
            Dim courseCode As String = selectedRow.Cells("course_code").Value.ToString()
            Dim subCode As String = selectedRow.Cells("sub_code").Value.ToString()
            Dim section As String = selectedRow.Cells("section").Value.ToString()

            Dim result As DialogResult = MessageBox.Show(
                $"Load students for Subject: {subCode}, Section: {section}?",
                "Load Students",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )
            If result = DialogResult.Yes Then
                LoadStudentsForSubjectSection(subCode, section)
            End If
        End If
    End Sub

    Private Sub LoadStudentsForSubjectSection(subCode As String, section As String)
        DGVGradeEntry.Rows.Clear()
        ' No need to clear columns if you set them up in the designer

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Join student_subjects, students, and grades to get all info
                Dim query As String = "
                SELECT ss.stud_id, s.last_name, s.first_name, s.middle_name, 
                       ss.sub_code, 
                       g.prelim, g.midterm, g.prefinal, g.final, g.final_grade, g.remarks
                FROM student_subjects ss
                INNER JOIN students s ON ss.stud_id = s.stud_id
                LEFT JOIN grades g ON ss.stud_id = g.stud_id AND ss.sub_code = g.sub_code
                WHERE ss.sub_code = @subCode AND ss.section = @section
            "
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@subCode", subCode)
                    cmd.Parameters.AddWithValue("@section", section)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DGVGradeEntry.Rows.Add(
                            reader("stud_id").ToString(),
                            reader("last_name").ToString(),
                            reader("first_name").ToString(),
                            reader("middle_name").ToString(),
                            reader("sub_code").ToString(),
                            If(IsDBNull(reader("prelim")), "", reader("prelim").ToString()),
                            If(IsDBNull(reader("midterm")), "", reader("midterm").ToString()),
                            If(IsDBNull(reader("prefinal")), "", reader("prefinal").ToString()),
                            If(IsDBNull(reader("final")), "", reader("final").ToString()),
                            If(IsDBNull(reader("final_grade")), "", reader("final_grade").ToString()),
                            If(IsDBNull(reader("remarks")), "", reader("remarks").ToString())
                        )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            SetGradeEntryColumnEditability()
        End Using
    End Sub

    Private Sub SetGradeEntryColumnEditability()
        ' Set all grade columns to read-only by default
        DGVGradeEntry.Columns("prelim").ReadOnly = True
        DGVGradeEntry.Columns("midterm").ReadOnly = True
        DGVGradeEntry.Columns("prefinal").ReadOnly = True
        DGVGradeEntry.Columns("final").ReadOnly = True

        ' Enable only the current term column
        Select Case lblTerm.Text.ToLower()
            Case "prelim"
                DGVGradeEntry.Columns("prelim").ReadOnly = False
            Case "midterm"
                DGVGradeEntry.Columns("midterm").ReadOnly = False
            Case "prefinal"
                DGVGradeEntry.Columns("prefinal").ReadOnly = False
            Case "final"
                DGVGradeEntry.Columns("final").ReadOnly = False
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DGVGradeEntry.Rows.Count = 0 Then
            MessageBox.Show("No students to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim termCol As String = ""
        Select Case lblTerm.Text.ToLower()
            Case "prelim" : termCol = "prelim"
            Case "midterm" : termCol = "midterm"
            Case "prefinal" : termCol = "prefinal"
            Case "final" : termCol = "final"
            Case Else
                MessageBox.Show("Invalid term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                For Each row As DataGridViewRow In DGVGradeEntry.Rows
                    If row.IsNewRow Then Continue For

                    Dim studId As String = row.Cells("stud_id").Value.ToString()
                    Dim subCode As String = row.Cells("subject").Value.ToString()
                    Dim gradeValue As String = row.Cells(termCol.ToUpper()).Value.ToString()

                    ' Only save if a grade is entered
                    If String.IsNullOrWhiteSpace(gradeValue) Then Continue For

                    ' Check if a grade record exists
                    Dim checkQuery As String = "SELECT COUNT(*) FROM grades WHERE stud_id = @studId AND sub_code = @subCode"
                    Dim exists As Integer
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@studId", studId)
                        checkCmd.Parameters.AddWithValue("@subCode", subCode)
                        exists = Convert.ToInt32(checkCmd.ExecuteScalar())
                    End Using

                    If exists > 0 Then
                        ' Update
                        Dim updateQuery As String = $"UPDATE grades SET {termCol} = @gradeValue WHERE stud_id = @studId AND sub_code = @subCode"
                        Using updateCmd As New MySqlCommand(updateQuery, conn)
                            updateCmd.Parameters.AddWithValue("@gradeValue", gradeValue)
                            updateCmd.Parameters.AddWithValue("@studId", studId)
                            updateCmd.Parameters.AddWithValue("@subCode", subCode)
                            updateCmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' Insert
                        Dim insertQuery As String = $"INSERT INTO grades (stud_id, sub_code, {termCol}) VALUES (@studId, @subCode, @gradeValue)"
                        Using insertCmd As New MySqlCommand(insertQuery, conn)
                            insertCmd.Parameters.AddWithValue("@studId", studId)
                            insertCmd.Parameters.AddWithValue("@subCode", subCode)
                            insertCmd.Parameters.AddWithValue("@gradeValue", gradeValue)
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                MessageBox.Show("Grades saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving grades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class