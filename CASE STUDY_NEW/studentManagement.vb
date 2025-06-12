Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class studentManagement
    'connection
    Dim connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"
    Dim bs As New BindingSource()

    'dgv display
    Private Sub studentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateAcademicPeriodLabels()
        DGV1.AutoGenerateColumns = False

        DGV1.Columns("id").DataPropertyName = "stud_id"
        DGV1.Columns("lname").DataPropertyName = "last_name"
        DGV1.Columns("fname").DataPropertyName = "first_name"
        DGV1.Columns("mname").DataPropertyName = "middle_name"
        DGV1.Columns("dept").DataPropertyName = "department"
        DGV1.Columns("yr_level").DataPropertyName = "year_level"
        DGV1.Columns("course").DataPropertyName = "course_code"
        DGV1.Columns("pass").DataPropertyName = "password"
        DGV1.Columns("stat").DataPropertyName = "status"

        ' Initialize filter combo box
        cboFilter.Items.AddRange(New String() {"ALL", "REGULAR", "IRREGULAR"})
        cboFilter.SelectedIndex = 0 ' Default to "ALL"

        createPnl.Hide()
        LoadStudents()
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        LoadStudents()
    End Sub

    Private Function GenerateNextStudentId() As String
        Dim nextId As String = ""
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Get the current year's last two digits
                Dim currentYear As String = DateTime.Now.Year.ToString().Substring(2)

                ' Find the highest student number for the current year
                Dim query As String = "SELECT MAX(CAST(SUBSTRING_INDEX(stud_id, '-', 1) AS UNSIGNED)) " &
                                "FROM students WHERE stud_id LIKE '%-" & currentYear & "'"

                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    Dim lastNumber As Integer

                    If result Is DBNull.Value OrElse result Is Nothing Then
                        ' No existing students for this year, start with 1000
                        lastNumber = 999
                    Else
                        lastNumber = Convert.ToInt32(result)
                    End If

                    ' Increment the number and format it
                    Dim nextNumber As Integer = lastNumber + 1
                    nextId = nextNumber.ToString() & "-" & currentYear
                End Using
            Catch ex As Exception
                MessageBox.Show("Error generating student ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return nextId
    End Function

    Private Sub LoadStudents(Optional searchKeyword As String = "")

        Dim dt As New DataTable()

        UpdateAcademicPeriodLabels()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Get current school year and semester
                Dim currentSchoolYear As String = ""
                Dim currentSemester As String = ""

                Using cmdYear As New MySqlCommand("SELECT school_year FROM school_year_table WHERE status = 'Open'", conn)
                    currentSchoolYear = Convert.ToString(cmdYear.ExecuteScalar())
                End Using

                Using cmdSem As New MySqlCommand("SELECT semester FROM semester_table WHERE status = 'Open'", conn)
                    currentSemester = Convert.ToString(cmdSem.ExecuteScalar())
                End Using

                ' Modified query to join with enrollment table
                Dim query As String = "SELECT DISTINCT s.* FROM students s " &
                                    "INNER JOIN enrollment e ON s.stud_id = e.stud_id " &
                                    "WHERE e.academic_year = @schoolYear AND e.semester = @semester "

                ' Add status filter based on selection
                If cboFilter IsNot Nothing AndAlso cboFilter.SelectedItem IsNot Nothing Then
                    Select Case cboFilter.SelectedItem.ToString()
                        Case "REGULAR"
                            query &= " AND s.status = 'REGULAR' "
                        Case "IRREGULAR"
                            query &= " AND s.status = 'IRREGULAR' "
                    End Select
                End If

                If Not String.IsNullOrEmpty(searchKeyword) Then
                    query &= " AND (s.stud_id LIKE @search OR s.last_name LIKE @search OR s.first_name LIKE @search)"
                End If

                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@schoolYear", currentSchoolYear)
                    da.SelectCommand.Parameters.AddWithValue("@semester", currentSemester)

                    If Not String.IsNullOrEmpty(searchKeyword) Then
                        da.SelectCommand.Parameters.AddWithValue("@search", "%" & searchKeyword & "%")
                    End If

                    da.Fill(dt)
                End Using

                bs.DataSource = dt
                DGV1.DataSource = bs
                DGV1.AutoGenerateColumns = False

            Catch ex As MySqlException
                MessageBox.Show("Database Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub searchTxt_TextChanged(sender As Object, e As EventArgs) Handles searchTxt.TextChanged
        LoadStudents(searchTxt.Text)
    End Sub

    Private Sub createLbl_Click(sender As Object, e As EventArgs) Handles createLbl.Click
        createPnl.Show()
        ComboBox1.Enabled = False
        ComboBox1.Items.Clear()

        ' Make stud_id read-only and generate new ID
        stud_id.ReadOnly = True
        stud_id.Text = GenerateNextStudentId()
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        ComboBox1.Items.Clear()

        If cboDepartment.SelectedIndex <> -1 Then
            Dim selectedDepartment = cboDepartment.SelectedItem.ToString

            Using conn As New MySqlConnection(connString)
                Try
                    conn.Open()
                    Dim query = "SELECT course_code FROM courses WHERE department_id = @dept AND status = 'Active'"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@dept", selectedDepartment)
                        Using reader = cmd.ExecuteReader
                            While reader.Read
                                ComboBox1.Items.Add(reader("course_code").ToString)
                            End While
                        End Using
                    End Using

                    ComboBox1.Enabled = True ' Enable the combobox after populating items
                Catch ex As MySqlException
                    MessageBox.Show("Error loading courses: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub ForeverButton2_Click(sender As Object, e As EventArgs) Handles ForeverButton2.Click
        createPnl.Hide()
    End Sub

    Private Sub ForeverButton1_Click(sender As Object, e As EventArgs) Handles ForeverButton1.Click
        If String.IsNullOrWhiteSpace(stud_id.Text) OrElse String.IsNullOrWhiteSpace(first_name.Text) OrElse String.IsNullOrWhiteSpace(last_name.Text) Then
            MessageBox.Show("Please fill up required fields!")
            Return
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Start a transaction to ensure both student and enrollment are created
                Using transaction = conn.BeginTransaction
                    Try
                        ' Insert into students table
                        Dim query = "INSERT INTO students (stud_id, first_name, last_name, middle_name, department, year_level, course_code, password, status) " &
                                          "VALUES (@id, @fname, @lname, @mname, @department, @yr_level, @course, @password, @status)"

                        Using cmd As New MySqlCommand(query, conn, transaction)
                            'Dim hashedPassword As String = HashPassword(password.Text)

                            cmd.Parameters.AddWithValue("@id", stud_id.Text)
                            cmd.Parameters.AddWithValue("@fname", first_name.Text)
                            cmd.Parameters.AddWithValue("@lname", last_name.Text)
                            cmd.Parameters.AddWithValue("@mname", middle_name.Text)
                            cmd.Parameters.AddWithValue("@department", cboDepartment.Text)
                            cmd.Parameters.AddWithValue("@yr_level", cboYearlvl.Text)
                            cmd.Parameters.AddWithValue("@course", ComboBox1.Text)
                            cmd.Parameters.AddWithValue("@password", password.Text)
                            cmd.Parameters.AddWithValue("@status", status.Text)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Get current school year and semester
                        Dim currentSchoolYear = ""
                        Dim currentSemester = ""

                        Using cmdYear As New MySqlCommand("SELECT school_year FROM school_year_table WHERE status = 'Open'", conn, transaction)
                            currentSchoolYear = Convert.ToString(cmdYear.ExecuteScalar)
                        End Using

                        Using cmdSem As New MySqlCommand("SELECT semester FROM semester_table WHERE status = 'Open'", conn, transaction)
                            currentSemester = Convert.ToString(cmdSem.ExecuteScalar)
                        End Using

                        ' Insert into enrollment table
                        Dim enrollQuery = "INSERT INTO enrollment (stud_id, section_id, academic_year, semester, enrolled_date) " &
                                                  "VALUES (@stud_id, @section_id, @academic_year, @semester, @enrolled_date)"

                        Using enrollCmd As New MySqlCommand(enrollQuery, conn, transaction)
                            enrollCmd.Parameters.AddWithValue("@stud_id", stud_id.Text)
                            enrollCmd.Parameters.AddWithValue("@section_id", 1) ' Default section, modify as needed
                            enrollCmd.Parameters.AddWithValue("@academic_year", currentSchoolYear)
                            enrollCmd.Parameters.AddWithValue("@semester", currentSemester)
                            enrollCmd.Parameters.AddWithValue("@enrolled_date", Date.Now.ToString("yyyy-MM-dd"))
                            enrollCmd.ExecuteNonQuery()
                        End Using

                        ' Add audit trail
                        Dim username = Login.usernameLbl.Text
                        Dim action = "CREATED NEW"
                        Dim date_time = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")

                        Using auditCmd As New MySqlCommand("INSERT INTO audit_trail (username, action, date_time) VALUES (@username, @action, @date_time)", conn, transaction)
                            auditCmd.Parameters.AddWithValue("@username", username)
                            auditCmd.Parameters.AddWithValue("@action", action)
                            auditCmd.Parameters.AddWithValue("@date_time", date_time)
                            auditCmd.ExecuteNonQuery()
                        End Using

                        ' Commit the transaction
                        transaction.Commit()

                        MessageBox.Show("Data Saved Successfully.")
                        createPnl.Hide()
                        LoadStudents()

                        ' Clear the fields
                        stud_id.Clear()
                        first_name.Clear()
                        last_name.Clear()
                        middle_name.Clear()
                        password.Clear()

                        status.SelectedIndex = -1
                        cboDepartment.SelectedIndex = -1

                    Catch ex As Exception
                        ' Roll back the transaction if there's an error
                        transaction.Rollback()
                        Throw
                    End Try
                End Using

            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Error: Student ID already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Database Error: " & ex.Message)
                End If
            End Try
        End Using
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles deleteLbl.Click
        If DGV1.SelectedRows.Count > 0 Then
            Dim selectedStudId As String = DGV1.SelectedRows(0).Cells("id").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Using conn As New MySqlConnection(connString)
                    Try
                        conn.Open()
                        Dim sql As String = "DELETE FROM students WHERE stud_id = @stud_id"

                        Using cmd As New MySqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("@stud_id", selectedStudId)
                            cmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadStudents()
                    Catch ex As MySqlException
                        MessageBox.Show("Database Error: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select a row to delete!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub createPnl_Paint(sender As Object, e As PaintEventArgs) Handles createPnl.Paint
        If status.Items.Count = 0 Then
            status.Items.AddRange(New String() {"REGULAR", "IRREGULAR"})
        End If
        status.DropDownStyle = ComboBoxStyle.DropDownList

        'Populate department ComboBox from database
        If cboDepartment.Items.Count = 0 Then
            Try
                Using conn As New MySqlConnection(connString)
                    conn.Open()
                    Dim query = "SELECT department_id FROM department WHERE status = 'Active' ORDER BY department_id"
                    Using cmd As New MySqlCommand(query, conn)
                        Using reader = cmd.ExecuteReader
                            While reader.Read
                                cboDepartment.Items.Add(reader("department_id").ToString)
                            End While
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading departments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub DGV1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellEndEdit
        Try
            Dim row As DataGridViewRow = DGV1.Rows(e.RowIndex)
            Dim uiColumnName As String = DGV1.Columns(e.ColumnIndex).Name

            If uiColumnName = "id" Then Return

            Dim columnMap As New Dictionary(Of String, String) From {
                {"id", "stud_id"},
                {"fname", "first_name"},
                {"lname", "last_name"},
                {"mname", "middle_name"},
                {"dept", "department"},
                {"yr_level", "year_level"},
                {"course", "course_code"},
                {"stat", "status"}
            }

            If Not columnMap.ContainsKey(uiColumnName) Then
                MessageBox.Show("Unknown column mapping for: " & uiColumnName)
                Return
            End If

            Dim dbColumnName As String = columnMap(uiColumnName)
            Dim newValue As String = row.Cells(uiColumnName).Value.ToString()
            Dim studentId As String = row.Cells("id").Value.ToString()

            Dim sql As String = $"UPDATE students SET {dbColumnName} = @value WHERE stud_id = @id"

            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@value", newValue)
                    cmd.Parameters.AddWithValue("@id", studentId)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Dim auditSql As String = "INSERT INTO audit_trail (username, date_time, action) VALUES (@user, @time, @action)"
            Dim username As String = Login.usernameLbl.Text

            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(auditSql, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@time", DateTime.Now)
                    cmd.Parameters.AddWithValue("@action", $"Edited {dbColumnName} of Student ID {studentId}'")
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadStudents()

        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message)
        End Try
    End Sub

    'Private Function HashPassword(password As String) As String
    '    Using sha256 As SHA256 = SHA256.Create()
    '        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
    '        Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
    '        Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
    '    End Using
    'End Function

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
        End Using
    End Sub

    Private Sub searchTxt_Click(sender As Object, e As EventArgs) Handles searchTxt.Click
        searchTxt.Text = ""
    End Sub

End Class
