Imports MySql.Data.MySqlClient


Public Class subjects
    Dim connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"


    Private isEditMode As Boolean = False
    Private editingSubjectId As String = ""

    Private Sub subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV4.AutoGenerateColumns = False

        DGV4.Columns("subject_id").DataPropertyName = "sub_id"
        DGV4.Columns("subject_code").DataPropertyName = "sub_code"
        DGV4.Columns("subjectt_name").DataPropertyName = "subject_name"
        DGV4.Columns("unitt").DataPropertyName = "unit"
        DGV4.Columns("yr_level").DataPropertyName = "year_level"
        DGV4.Columns("semester").DataPropertyName = "semester"
        DGV4.Columns("coursee").DataPropertyName = "course"
        DGV4.Columns("prerequisite").DataPropertyName = "prerequisite_sub_id"

        DGV4_Load()
        createPnl.Hide()
    End Sub

    Public Sub DGV4_Load()
        Dim conn As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=loa_grading_system")
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim query As String = "
                SELECT * FROM subjects"
            da = New MySqlDataAdapter(query, conn)
            da.Fill(dt)
            DGV4.DataSource = dt
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    'SAVE BUTTON
    Private Sub ForeverButton1_Click(sender As Object, e As EventArgs) Handles ForeverButton1.Click
        If String.IsNullOrWhiteSpace(sub_id.Text) OrElse String.IsNullOrWhiteSpace(sub_code.Text) OrElse String.IsNullOrWhiteSpace(subject_name.Text) Then
            MessageBox.Show("Please fill up required fields!")
            Return
        End If


        Dim enteredPassword As String = InputBox("Please enter your password to confirm:", "Authentication Required")
        If String.IsNullOrWhiteSpace(enteredPassword) Then
            MessageBox.Show("Password is required to proceed.")
            Return
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Dim tableName As String = ""
                Dim idField As String = ""

                Select Case Login.CurrentUserRole
                    Case "Admin"
                        tableName = "admin"
                        idField = "id"
                    Case "Registrar"
                        tableName = "registrar"
                        idField = "registrar_id"
                    Case Else
                        MessageBox.Show("Unauthorized user role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                End Select


                Dim username As String = Login.usernameLbl.Text
                Dim passwordQuery As String = $"SELECT COUNT(*) FROM {tableName} WHERE {idField} ='" & username & "'AND password = '" & enteredPassword & "'"
                Using checkCmd As New MySqlCommand(passwordQuery, conn)
                    checkCmd.Parameters.AddWithValue("@username", username)
                    checkCmd.Parameters.AddWithValue("@password", enteredPassword)
                    Dim result As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If result = 0 Then
                        MessageBox.Show("Incorrect password. Changes were not saved.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                If isEditMode Then
                    ' UPDATE
                    Label10.Text = "Update Subject"
                    Dim query As String = "UPDATE subjects SET sub_code=@subject_code, subject_name=@subjectt_name, unit=@unitt, year_level=@yr_level, semester=@semester, course=@coursee, prerequisite_sub_id=@prerequisite WHERE sub_id=@subject_id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@subject_id", editingSubjectId)
                        cmd.Parameters.AddWithValue("@subject_code", sub_code.Text)
                        cmd.Parameters.AddWithValue("@subjectt_name", subject_name.Text)
                        cmd.Parameters.AddWithValue("@unitt", unit.Text)
                        cmd.Parameters.AddWithValue("@yr_level", cboYrlvl.Text)
                        cmd.Parameters.AddWithValue("@semester", cboSem.Text)
                        cmd.Parameters.AddWithValue("@coursee", cboCourse.Text)
                        cmd.Parameters.AddWithValue("@prerequisite", txtprereq.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Subject updated successfully.")
                Else
                    ' INSERT

                    Dim query As String = "INSERT INTO subjects (sub_id, sub_code, subject_name, unit, year_level, semester, course, prerequisite_sub_id) " &
                                      "VALUES (@subject_id, @subject_code, @subjectt_name, @unitt, @yr_level, @semester, @coursee, @prerequisite)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@subject_id", sub_id.Text)
                        cmd.Parameters.AddWithValue("@subject_code", sub_code.Text)
                        cmd.Parameters.AddWithValue("@subjectt_name", subject_name.Text)
                        cmd.Parameters.AddWithValue("@unitt", unit.Text)
                        cmd.Parameters.AddWithValue("@yr_level", cboYrlvl.Text)
                        cmd.Parameters.AddWithValue("@semester", cboSem.Text)
                        cmd.Parameters.AddWithValue("@coursee", cboCourse.Text)
                        cmd.Parameters.AddWithValue("@prerequisite", txtprereq.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Data Saved Successfully.")
                End If

                ' Audit trail
                Dim action As String = If(isEditMode, "UPDATED SUBJECT", "CREATED NEW SUBJECT")
                Dim date_time As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Dim auditCmd As New MySqlCommand("INSERT INTO audit_trail (username, action, date_time) VALUES (@username, @action, @date_time)", conn)
                auditCmd.Parameters.AddWithValue("@username", username)
                auditCmd.Parameters.AddWithValue("@action", action)
                auditCmd.Parameters.AddWithValue("@date_time", date_time)
                auditCmd.ExecuteNonQuery()

                createPnl.Hide()
                DGV4_Load()

                sub_id.Enabled = True
                sub_id.Clear()
                subject_name.Clear()
                sub_code.Clear()
                unit.Clear()
                cboYrlvl.SelectedIndex = -1 ' Reset year level selection
                cboSem.SelectedIndex = -1 ' Reset semester selection

                cboCourse.SelectedIndex = -1 ' Reset course selection
                txtprereq.Clear()
                isEditMode = False
                editingSubjectId = ""

            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Error: Subject ID already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Database Error: " & ex.Message)
                End If
            End Try
        End Using
    End Sub


    Private Sub ForeverButton2_Click(sender As Object, e As EventArgs) Handles ForeverButton2.Click
        createPnl.Hide()
    End Sub

    Private Function GenerateNextSubjectId() As String
        Dim nextId As String = ""
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Get the highest numeric part of sub_id
                Dim query As String = "SELECT MAX(CAST(SUBSTRING(sub_id, 4) AS UNSIGNED)) FROM subjects WHERE sub_id LIKE 'sub%'"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Dim lastNum As Integer = Convert.ToInt32(result)
                        nextId = "sub" & (lastNum + 1).ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error generating Subject ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return nextId
    End Function



    Private Sub createLbl_Click(sender As Object, e As EventArgs) Handles createLbl.Click
        isEditMode = False
        editingSubjectId = ""
        sub_id.Enabled = True ' Allow editing Subject ID for new
        sub_id.Text = GenerateNextSubjectId()
        subject_name.Clear()
        sub_code.Clear()
        unit.Clear()
        cboYrlvl.SelectedIndex = -1 ' Reset year level selection
        cboSem.SelectedIndex = -1 ' Reset semester selection
        cboCourse.SelectedIndex = -1 ' Reset course selection
        txtprereq.Clear()
        Label10.Text = "Create Subject"
        LoadActiveCourses()
        createPnl.Show()
    End Sub

    Private Sub deleteLbl_Click(sender As Object, e As EventArgs) Handles deleteLbl.Click
        If DGV4.SelectedRows.Count > 0 Then
            Dim selectedId As String = DGV4.SelectedRows(0).Cells("subject_id").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Using conn As New MySqlConnection(connString)
                    Try
                        conn.Open()
                        Dim sql As String = "DELETE FROM subjects WHERE sub_id = @subject_id"

                        Using cmd As New MySqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("@subject_id", selectedId)
                            cmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DGV4_Load()
                    Catch ex As MySqlException
                        MessageBox.Show("Database Error: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select a row to delete!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DGV4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV4.CellContentClick
        If e.ColumnIndex = DGV4.Columns("editBtn").Index AndAlso e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV4.Rows(e.RowIndex)
            isEditMode = True
            editingSubjectId = row.Cells("subject_id").Value.ToString()
            sub_id.Text = editingSubjectId
            sub_id.Enabled = False ' Prevent editing Subject ID
            sub_code.Text = row.Cells("subject_code").Value.ToString()
            subject_name.Text = row.Cells("subjectt_name").Value.ToString()
            unit.Text = row.Cells("unitt").Value.ToString()
            cboYrlvl.Text = row.Cells("yr_level").Value.ToString()
            cboSem.Text = row.Cells("semester").Value.ToString()
            cboCourse.Text = row.Cells("coursee").Value.ToString()
            txtprereq.Text = row.Cells("prerequisite").Value.ToString()
            Label10.Text = "Edit Subject"
            LoadActiveCourses() ' Load active courses for the dropdown
            If row.Cells("coursee").Value IsNot Nothing Then
                cboCourse.Text = row.Cells("coursee").Value.ToString()
            End If
            createPnl.Show()
        End If
    End Sub

    Private Sub LoadActiveCourses()
        cboCourse.Items.Clear()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT course_code FROM courses WHERE status = 'Active'"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboCourse.Items.Add(reader("course_code").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading courses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


End Class