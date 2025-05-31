Imports MySql.Data.MySqlClient
Imports ReaLTaiizor.Controls

Public Class schoolyear

    Dim connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"
    Dim bs As New BindingSource()


    Private Sub schoolyear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlAddSchoolYear.Visible = False
        LoadSchoolYears()
        cboStatus.SelectedIndex = 0

        LoadSemesterStatus()
        LoadTermStatus()

    End Sub
    Private Sub LoadSchoolYears()
        Using conn As New MySqlConnection(connString)
            If conn IsNot Nothing Then
                Try
                    Dim cmd As New MySqlCommand("SELECT school_year, status FROM school_year_table ORDER BY school_year DESC", conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    DGVSchoolyear.Rows.Clear()

                    ' Check if we need to add the button column
                    If DGVSchoolyear.Columns.Count = 2 Then ' If only school_year and status columns exist
                        Dim buttonColumn As New DataGridViewButtonColumn()
                        buttonColumn.Name = "btnAction"
                        buttonColumn.HeaderText = "Action"
                        buttonColumn.Text = "Change Status"
                        buttonColumn.UseColumnTextForButtonValue = True
                        DGVSchoolyear.Columns.Add(buttonColumn)
                    End If

                    For Each row As DataRow In dt.Rows
                        DGVSchoolyear.Rows.Add(row("school_year"), row("status"), "Change Status")
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error loading school years: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
    Private Sub btnAddSchoolYear_Click(sender As Object, e As EventArgs) Handles btnAddSchoolYear.Click
        pnlAddSchoolYear.Visible = True
        txtSchoolYear.Clear()
        cboStatus.SelectedIndex = 0 ' Set default to "open"
        txtSchoolYear.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pnlAddSchoolYear.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateInputs() Then
            SaveSchoolYear()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtSchoolYear.Text.Trim) Then
            MessageBox.Show("Please enter a school year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSchoolYear.Focus()
            Return False
        End If

        ' Split the school year by hyphen and validate each part
        Dim parts() As String = txtSchoolYear.Text.Trim().Split("-"c)
        For Each part In parts
            If Not String.IsNullOrEmpty(part) AndAlso Not IsNumeric(part.Trim) Then
                MessageBox.Show("School year must contain only numbers and a hyphen (e.g., 2024-2025).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSchoolYear.Focus()
                Return False
            End If
        Next

        ' Validate the format (optional)
        If parts.Length = 2 Then
            Dim firstYear, secondYear As Integer
            If Integer.TryParse(parts(0), firstYear) AndAlso Integer.TryParse(parts(1), secondYear) Then
                If secondYear <> firstYear + 1 Then
                    MessageBox.Show("Second year should be the next year (e.g., 2024-2025).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End If
        End If

        Return True
    End Function

    'Private Sub SaveSchoolYear()
    '    Dim schoolYear As String = txtSchoolYear.Text.Trim()
    '    Dim status As String = If(cboStatus.SelectedItem.ToString() = "Active", "Active", "Inactive")
    '    Using conn As New MySqlConnection(connString)
    '        Try
    '            conn.Open()
    '            Dim cmd As New MySqlCommand("INSERT INTO school_year_table (school_year, status) VALUES (@schoolYear, @status)", conn)
    '            cmd.Parameters.AddWithValue("@schoolYear", schoolYear)
    '            cmd.Parameters.AddWithValue("@status", status)
    '            cmd.ExecuteNonQuery()
    '            MessageBox.Show("School year added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            LoadSchoolYears()
    '        Catch ex As Exception
    '            MessageBox.Show("Error saving school year: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using
    'End Sub

    Private Sub SaveSchoolYear()
        Using conn As New MySqlConnection(connString)
            If conn IsNot Nothing Then
                conn.Open()
                ' Start a transaction since we might need to update multiple records
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' First check if school year already exists
                    Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM school_year_table WHERE school_year = @school_year", conn, transaction)
                    cmdCheck.Parameters.AddWithValue("@school_year", txtSchoolYear.Text.Trim)
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("School year already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        transaction.Rollback()
                        Return
                    End If

                    ' If new status is Active, set all other school years to Inactive
                    If cboStatus.Text = "Open" Then
                        Dim cmdUpdateAll As New MySqlCommand("UPDATE school_year_table SET status = 'Closed'", conn, transaction)
                        cmdUpdateAll.ExecuteNonQuery()
                    End If

                    ' Insert new school year
                    Dim cmdInsert As New MySqlCommand("INSERT INTO school_year_table (school_year, status) VALUES (@school_year, @status)", conn, transaction)
                    cmdInsert.Parameters.AddWithValue("@school_year", txtSchoolYear.Text.Trim)
                    cmdInsert.Parameters.AddWithValue("@status", cboStatus.Text)
                    cmdInsert.ExecuteNonQuery()

                    transaction.Commit()
                    MessageBox.Show("School year added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    pnlAddSchoolYear.Visible = False
                    LoadSchoolYears()

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error saving school year: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub txtSchoolYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSchoolYear.KeyPress
        ' Allow only numbers, hyphen, and control characters (like backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If

        ' Prevent multiple hyphens
        If e.KeyChar = "-" AndAlso txtSchoolYear.Text.Contains("-") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSchoolYear_Leave(sender As Object, e As EventArgs) Handles txtSchoolYear.Leave
        ' Format the school year as YYYY-YYYY if it's not already properly formatted
        Dim text As String = txtSchoolYear.Text.Trim
        If text.Length > 0 Then
            If Not text.Contains("-") Then
                ' If it's just a year, add the next year
                If text.Length = 4 AndAlso IsNumeric(text) Then
                    Dim year As Integer = Integer.Parse(text)
                    txtSchoolYear.Text = $"{year}-{year + 1}"
                End If
            End If
        End If
    End Sub

    Private Sub DGVSchoolyear_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSchoolyear.CellClick
        ' Check if clicked cell is in the button column
        If e.ColumnIndex = DGVSchoolyear.Columns("btnAction").Index AndAlso e.RowIndex >= 0 Then
            Dim schoolYear As String = DGVSchoolyear.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim currentStatus As String = DGVSchoolyear.Rows(e.RowIndex).Cells(1).Value.ToString()

            ' Ask for confirmation
            Dim message As String = If(currentStatus = "Open",
                                     $"Are you sure you want to close the school year {schoolYear}?",
                                     $"Are you sure you want to open the school year {schoolYear}? This will close all other school years.")

            If MessageBox.Show(message, "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                UpdateSchoolYearStatus(schoolYear)
            End If
        End If
    End Sub

    Private Sub UpdateSchoolYearStatus(schoolYear As String)
        Using conn As New MySqlConnection(connString)
            If conn IsNot Nothing Then
                conn.Open()
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' First set all school years to Closed
                    Dim cmdUpdateAll As New MySqlCommand("UPDATE school_year_table SET status = 'Closed'", conn, transaction)
                    cmdUpdateAll.ExecuteNonQuery()

                    ' Then set the selected school year to Open
                    Dim cmdUpdateSelected As New MySqlCommand("UPDATE school_year_table SET status = 'Open' WHERE school_year = @school_year", conn, transaction)
                    cmdUpdateSelected.Parameters.AddWithValue("@school_year", schoolYear)
                    cmdUpdateSelected.ExecuteNonQuery()

                    transaction.Commit()
                    MessageBox.Show($"School year {schoolYear} has been opened successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadSchoolYears() ' Refresh the grid

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error updating school year status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub


    Private Sub LoadSemesterStatus()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT semester, status FROM semester_table", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim semester As String = reader("semester").ToString()
                    Dim status As String = reader("status").ToString()

                    ' Set radio button checked state based on status
                    If semester = "1st Sem" Then
                        radFirstsem.Checked = (status.ToLower() = "open")
                    ElseIf semester = "2nd Sem" Then
                        radSecsem.Checked = (status.ToLower() = "open")
                    End If
                End While

            Catch ex As Exception
                MessageBox.Show("Error loading semester status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoadTermStatus()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT term, status FROM term_table", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim term As String = reader("term").ToString()
                    Dim status As String = reader("status").ToString()

                    ' Set radio button checked state based on status
                    Select Case term.ToLower()
                        Case "prelim"
                            radPrelim.Checked = (status.ToLower() = "open")
                        Case "midterm"
                            radMidterm.Checked = (status.ToLower() = "open")
                        Case "prefinal"
                            radPrefinal.Checked = (status.ToLower() = "open")
                        Case "final"
                            radFinals.Checked = (status.ToLower() = "open")
                    End Select
                End While

            Catch ex As Exception
                MessageBox.Show("Error loading term status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub UpdateSemesterStatus(semester As String, status As String)


        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' First set all semesters to Closed
                    Dim cmdCloseAll As New MySqlCommand("UPDATE semester_table SET status = 'Closed'", conn, transaction)
                    cmdCloseAll.ExecuteNonQuery()

                    ' Then set the selected semester to Open
                    Dim cmdUpdate As New MySqlCommand("UPDATE semester_table SET status = @status WHERE semester = @semester", conn, transaction)
                    cmdUpdate.Parameters.AddWithValue("@status", status)
                    cmdUpdate.Parameters.AddWithValue("@semester", semester)
                    cmdUpdate.ExecuteNonQuery()

                    transaction.Commit()

                    LoadSemesterStatus() ' Refresh the status display

                Catch ex As Exception
                    transaction.Rollback()

                    LoadSemesterStatus() ' Reload status in case of error
                End Try

            Catch ex As Exception
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadSemesterStatus() ' Reload status in case of error
            End Try
        End Using
    End Sub

    Private Sub UpdateTermStatus(term As String, status As String)


        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' First set all terms to Closed
                    Dim cmdCloseAll As New MySqlCommand("UPDATE term_table SET status = 'Closed'", conn, transaction)
                    cmdCloseAll.ExecuteNonQuery()

                    ' Then set the selected term to Open
                    Dim cmdUpdate As New MySqlCommand("UPDATE term_table SET status = @status WHERE term = @term", conn, transaction)
                    cmdUpdate.Parameters.AddWithValue("@status", status)
                    cmdUpdate.Parameters.AddWithValue("@term", term)
                    cmdUpdate.ExecuteNonQuery()

                    transaction.Commit()

                    LoadTermStatus() ' Refresh the status display

                Catch ex As Exception
                    transaction.Rollback()

                    LoadTermStatus() ' Reload status in case of error
                End Try

            Catch ex As Exception
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadTermStatus() ' Reload status in case of error
            End Try
        End Using
    End Sub

    Private Sub radFirstsem_Click(sender As Object, e As EventArgs) Handles radFirstsem.Click
        ' Show confirmation dialog before changing the radio button state
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to open 1st semester? This will close all other semesters.",
            "Confirm Semester Change",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateSemesterStatus("1st Sem", "Open")
        Else
            ' If user cancels, reload status to revert radio button
            LoadSemesterStatus()
        End If
    End Sub

    Private Sub radSecsem_Click(sender As Object, e As EventArgs) Handles radSecsem.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to open 2nd semester? This will close all other semesters.",
            "Confirm Semester Change",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateSemesterStatus("2nd Sem", "Open")
        Else
            ' If user cancels, reload status to revert radio button
            LoadSemesterStatus()
        End If
    End Sub

    Private Sub radPrelim_Click(sender As Object, e As EventArgs) Handles radPrelim.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to open Prelim term? This will close all other terms.",
            "Confirm Term Change",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateTermStatus("prelim", "Open")
        Else
            ' If user cancels, reload status to revert radio button
            LoadTermStatus()
        End If
    End Sub

    Private Sub radMidterm_Click(sender As Object, e As EventArgs) Handles radMidterm.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to open Midterm term? This will close all other terms.",
            "Confirm Term Change",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateTermStatus("midterm", "Open")
        Else
            ' If user cancels, reload status to revert radio button
            LoadTermStatus()
        End If
    End Sub

    Private Sub radPrefinal_Click(sender As Object, e As EventArgs) Handles radPrefinal.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to open Prefinal term? This will close all other terms.",
            "Confirm Term Change",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateTermStatus("prefinal", "Open")
        Else
            ' If user cancels, reload status to revert radio button
            LoadTermStatus()
        End If
    End Sub

    Private Sub radFinals_Click(sender As Object, e As EventArgs) Handles radFinals.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to open Finals term? This will close all other terms.",
            "Confirm Term Change",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateTermStatus("final", "Open")
        Else
            ' If user cancels, reload status to revert radio button
            LoadTermStatus()
        End If
    End Sub
End Class