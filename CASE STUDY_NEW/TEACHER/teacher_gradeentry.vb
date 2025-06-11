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
            'AddHandler DGVGradeEntry.CellValidating, AddressOf DGVGradeEntry_CellValidating
        End If
    End Sub


    Private Sub DGVGradeEntry_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGVGradeEntry.CellValidating
        ' Only validate for the grade columns
        Dim colName As String = DGVGradeEntry.Columns(e.ColumnIndex).Name.ToLower()
        If colName = "prelim" OrElse colName = "midterm" OrElse colName = "prefinal" OrElse colName = "final" Then
            Dim input As String = e.FormattedValue.ToString().Trim()
            If input <> "" Then
                Dim grade As Integer
                If Not Integer.TryParse(input, grade) OrElse grade < 60 OrElse grade > 100 Then
                    MessageBox.Show("Please enter a valid grade between 60 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Cancel = True
                End If
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
                            'If(lblTerm.Text.ToLower() = "final" AndAlso Not IsDBNull(reader("final_grade")) AndAlso Convert.ToDouble(reader("final_grade")) > 0, reader("final_grade").ToString(), ""),
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            '' After loading students, check for missing prerequisite grades and set remarks to "UOD" if needed
            'For Each row As DataGridViewRow In DGVGradeEntry.Rows
            '    If row.IsNewRow Then Continue For

            '    Dim prelim As String = If(row.Cells("prelim").Value, "").ToString().Trim()
            '    Dim midterm As String = If(row.Cells("midterm").Value, "").ToString().Trim()
            '    Dim prefinal As String = If(row.Cells("prefinal").Value, "").ToString().Trim()

            '    Select Case lblTerm.Text.ToLower()
            '        Case "midterm"
            '            If String.IsNullOrEmpty(prelim) Then
            '                row.Cells("remarks").Value = "UOD"
            '            End If
            '        Case "prefinal"
            '            If String.IsNullOrEmpty(prelim) OrElse String.IsNullOrEmpty(midterm) Then
            '                row.Cells("remarks").Value = "UOD"
            '            End If
            '        Case "final"
            '            If String.IsNullOrEmpty(prelim) OrElse String.IsNullOrEmpty(midterm) OrElse String.IsNullOrEmpty(prefinal) Then
            '                row.Cells("remarks").Value = "UOD"
            '            End If
            '    End Select
            'Next


            SetGradeEntryColumnEditability()
            UpdateStudentCounters()
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
                    Dim remarksValue As String = If(row.Cells("remarks").Value, "").ToString()

                    ' Only skip if both grade and remarks are empty
                    If String.IsNullOrWhiteSpace(gradeValue) AndAlso String.IsNullOrWhiteSpace(remarksValue) Then Continue For

                    ' Check if a grade record exists
                    Dim checkQuery As String = "SELECT COUNT(*) FROM grades WHERE stud_id = @studId AND sub_code = @subCode"
                    Dim exists As Integer
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@studId", studId)
                        checkCmd.Parameters.AddWithValue("@subCode", subCode)
                        exists = Convert.ToInt32(checkCmd.ExecuteScalar())
                    End Using

                    If exists > 0 Then
                        Dim updateQuery As String = $"UPDATE grades SET {termCol} = @gradeValue, remarks = @remarks WHERE stud_id = @studId AND sub_code = @subCode"
                        Using updateCmd As New MySqlCommand(updateQuery, conn)
                            updateCmd.Parameters.AddWithValue("@gradeValue", If(String.IsNullOrWhiteSpace(gradeValue), DBNull.Value, CType(gradeValue, Object)))
                            updateCmd.Parameters.AddWithValue("@remarks", remarksValue)
                            updateCmd.Parameters.AddWithValue("@studId", studId)
                            updateCmd.Parameters.AddWithValue("@subCode", subCode)
                            updateCmd.ExecuteNonQuery()
                        End Using
                    Else
                        Dim insertQuery As String = $"INSERT INTO grades (stud_id, sub_code, {termCol}, remarks) VALUES (@studId, @subCode, @gradeValue, @remarks)"
                        Using insertCmd As New MySqlCommand(insertQuery, conn)
                            insertCmd.Parameters.AddWithValue("@studId", studId)
                            insertCmd.Parameters.AddWithValue("@subCode", subCode)
                            insertCmd.Parameters.AddWithValue("@gradeValue", If(String.IsNullOrWhiteSpace(gradeValue), DBNull.Value, CType(gradeValue, Object)))
                            insertCmd.Parameters.AddWithValue("@remarks", remarksValue)
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                MessageBox.Show("Grades and remarks saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving grades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using



        'save grades
        For Each row As DataGridViewRow In DGVGradeEntry.Rows
            If row.IsNewRow Then Continue For

            Dim prelim, midterm, prefinal, final As Integer
            If Integer.TryParse(row.Cells("prelim").Value?.ToString(), prelim) AndAlso
               Integer.TryParse(row.Cells("midterm").Value?.ToString(), midterm) AndAlso
               Integer.TryParse(row.Cells("prefinal").Value?.ToString(), prefinal) AndAlso
               Integer.TryParse(row.Cells("final").Value?.ToString(), final) Then

                Dim avg As Double = (prelim + midterm + prefinal + final) / 4.0
                Dim eqGrade As String = GetEquivalentGrade(avg)
                row.Cells("final_grade").Value = eqGrade

                If avg >= 75 Then
                    row.Cells("remarks").Value = "PASSED"
                Else
                    row.Cells("remarks").Value = "FAILED"
                End If

                ' Optionally, update the grades table with final_grade and remarks
                Using conn As New MySqlConnection(connString)
                    conn.Open()
                    Dim updateQuery As String = "UPDATE grades SET final_grade = @finalGrade, remarks = @remarks WHERE stud_id = @studId AND sub_code = @subCode"
                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@finalGrade", eqGrade)
                        cmd.Parameters.AddWithValue("@remarks", row.Cells("remarks").Value.ToString())
                        cmd.Parameters.AddWithValue("@studId", row.Cells("stud_id").Value.ToString())
                        cmd.Parameters.AddWithValue("@subCode", row.Cells("subject").Value.ToString())
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            End If
        Next




        ' Update student counters after saving
        UpdateStudentCounters()


    End Sub

    Private Function GetEquivalentGrade(avg As Double) As String
        If avg >= 99 AndAlso avg <= 100 Then
            Return "1.00"
        ElseIf avg >= 96 AndAlso avg <= 98 Then
            Return "1.25"
        ElseIf avg >= 93 AndAlso avg <= 95 Then
            Return "1.50"
        ElseIf avg >= 90 AndAlso avg <= 92 Then
            Return "1.75"
        ElseIf avg >= 87 AndAlso avg <= 89 Then
            Return "2.00"
        ElseIf avg >= 84 AndAlso avg <= 86 Then
            Return "2.25"
        ElseIf avg >= 81 AndAlso avg <= 83 Then
            Return "2.50"
        ElseIf avg >= 78 AndAlso avg <= 80 Then
            Return "2.75"
        ElseIf avg >= 75 AndAlso avg <= 77 Then
            Return "3.00"
        Else
            Return "5.00"
        End If
    End Function

    Private Sub UpdateStudentCounters()
        Dim total As Integer = 0
        Dim passed As Integer = 0
        Dim failed As Integer = 0
        Dim uod As Integer = 0
        Dim od As Integer = 0
        Dim inc As Integer = 0

        For Each row As DataGridViewRow In DGVGradeEntry.Rows
            If row.IsNewRow Then Continue For
            total += 1
            Dim remarks As String = If(row.Cells("remarks").Value, "").ToString().Trim().ToUpper()
            If remarks = "PASSED" Then
                passed += 1
            ElseIf remarks = "FAILED" Then
                failed += 1
            ElseIf remarks = "UOD" Then
                uod += 1
            ElseIf remarks = "OD" Then
                od += 1
            ElseIf remarks = "INC" Then
                inc += 1
            End If
        Next

        lblstudentcounter.Text = total.ToString()
        lblpassedcounter.Text = passed.ToString()
        lblfailedcounter.Text = failed.ToString()
        lblUOD.Text = uod.ToString()
        lblOD.Text = od.ToString()
        lblINC.Text = inc.ToString()
    End Sub

    Private Sub DGVGradeEntry_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGradeEntry.CellDoubleClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim colName As String = dgv.Columns(e.ColumnIndex).Name.ToLower()

        If colName = "remarks" Then
            Dim input As String = InputBox("Input remarks for the student (UOD, INC, OD):", "Input Remarks").Trim().ToUpper()
            If input = "" Then Exit Sub

            If input = "UOD" OrElse input = "INC" OrElse input = "OD" Then
                dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = input
            Else
                MessageBox.Show("Only 'UOD', 'INC', or 'OD' are accepted.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub




End Class