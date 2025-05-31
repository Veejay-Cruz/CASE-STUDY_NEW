Imports System.Data
Imports MySql.Data.MySqlClient

Public Class department
    Private conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=loa_grading_system;")
    Private dataTable As New DataTable()
    Private isEditing As Boolean = False
    Private editingDeptId As String = ""

    Private Sub department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load department data
        LoadDepartmentData()
        createPnl2.Visible = False

        cboFilter.Items.AddRange(New String() {"ALL", "Active", "Inactive"})
        cboFilter.SelectedIndex = 0



    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        LoadDepartmentData()
    End Sub

    Private Sub LoadDepartmentData()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "SELECT d.department_id, d.department_name, " &
                                "GROUP_CONCAT(IFNULL(c.course_code, 'No courses') SEPARATOR ', ') as courses " &
                                "FROM department d " &
                                "LEFT JOIN courses c ON d.department_id = c.department_id "

            ' Add WHERE clause based on filter selection
            If cboFilter IsNot Nothing AndAlso cboFilter.SelectedItem IsNot Nothing Then
                Select Case cboFilter.SelectedItem.ToString()
                    Case "Active"
                        query &= "WHERE d.status = 'Active' "
                    Case "Inactive"
                        query &= "WHERE d.status = 'Inactive' "
                End Select
            End If

            query &= "GROUP BY d.department_id, d.department_name"

            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            dataTable.Clear()
            adapter.Fill(dataTable)

            ' Bind data to DataGridView
            DGVDepartment.Rows.Clear()
            For Each row As DataRow In dataTable.Rows
                DGVDepartment.Rows.Add(
                    row("department_id"),
                    row("department_name"),
                    If(IsDBNull(row("courses")), "No courses", row("courses"))
                )
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading department data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DGVDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDepartment.CellClick
        ' Check if a button cell was clicked and it's not the header row
        If e.RowIndex < 0 OrElse e.RowIndex >= DGVDepartment.Rows.Count - 1 Then Return

        Try
            ' Check if the cell values are null
            If DGVDepartment.Rows(e.RowIndex).Cells(0).Value Is Nothing OrElse
               DGVDepartment.Rows(e.RowIndex).Cells(1).Value Is Nothing Then
                Return
            End If

            Dim departmentId As String = DGVDepartment.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim departmentName As String = DGVDepartment.Rows(e.RowIndex).Cells(1).Value.ToString()

            ' Handle Edit button click
            If e.ColumnIndex = DGVDepartment.Columns("edit").Index Then
                ' Show edit panel
                createPnl2.Visible = True
                createPnl2.BringToFront()
                Label7.Text = "EDIT DEPARTMENT"

                ' Store the current department ID for updating
                isEditing = True
                editingDeptId = departmentId

                ' Fill the form with current values
                txtdept_id.Text = departmentId
                txtdeptname.Text = departmentName

                ' Get current status from database
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    Dim query As String = "SELECT status FROM department WHERE department_id = @id"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", departmentId)
                    Dim status As String = cmd.ExecuteScalar().ToString()

                    ' Set the status in combo box
                    cboStatus.SelectedItem = status

                Catch ex As Exception
                    MessageBox.Show("Error loading department status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If

            ' Handle Delete button click
            If e.ColumnIndex = DGVDepartment.Columns("delete").Index Then
                DeactivateDepartment(departmentId)
            End If
        Catch ex As Exception
            MessageBox.Show("Error accessing cell data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditDepartment(departmentId As String, departmentName As String)
        ' You can create a new form for editing or use input boxes
        Dim newName As String = InputBox("Enter new department name:", "Edit Department", departmentName)

        If String.IsNullOrEmpty(newName) Then Return

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "UPDATE department SET department_name = @name WHERE department_id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", newName)
            cmd.Parameters.AddWithValue("@id", departmentId)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDepartmentData()

        Catch ex As Exception
            MessageBox.Show("Error updating department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DeactivateDepartment(departmentId As String)
        If MessageBox.Show("Are you sure you want to deactivate this department?", "Confirm Deactivation",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Update department status to 'Inactive'
            Dim query As String = "UPDATE department SET status = 'Inactive' WHERE department_id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", departmentId)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Department deactivated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDepartmentData()

        Catch ex As Exception
            MessageBox.Show("Error deactivating department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub createLbl_Click(sender As Object, e As EventArgs) Handles createLbl.Click
        createPnl2.Visible = True
        createPnl2.BringToFront()
        Label7.Text = "ADD NEW"
        isEditing = False
        editingDeptId = ""

        ' Clear previous inputs
        txtdept_id.Clear()
        txtdeptname.Clear()
        txtdept_id.ReadOnly = False ' Enable department ID editing for new entries
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtdept_id.Clear()
        txtdeptname.Clear()
        cboStatus.SelectedIndex = 0
        createPnl2.Visible = False
        Label7.Text = "ADD NEW"
        isEditing = False
        editingDeptId = ""
        txtdept_id.ReadOnly = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtdept_id.Text.Trim()) Then
            MessageBox.Show("Please enter Department ID", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdept_id.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtdeptname.Text.Trim()) Then
            MessageBox.Show("Please enter Department Name", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdeptname.Focus()
            Return
        End If

        If cboStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Status", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboStatus.Focus()
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            If isEditing Then
                ' Update existing department
                Dim query As String = "UPDATE department SET department_name = @name, status = @status WHERE department_id = @id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", txtdeptname.Text.Trim())
                cmd.Parameters.AddWithValue("@status", cboStatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@id", editingDeptId)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Check if department ID already exists for new departments
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM department WHERE department_id = @id", conn)
                checkCmd.Parameters.AddWithValue("@id", txtdept_id.Text.Trim())
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Department ID already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtdept_id.Focus()
                    Return
                End If

                ' Insert new department
                Dim query As String = "INSERT INTO department (department_id, department_name, status) VALUES (@id, @name, @status)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtdept_id.Text.Trim())
                cmd.Parameters.AddWithValue("@name", txtdeptname.Text.Trim())
                cmd.Parameters.AddWithValue("@status", cboStatus.SelectedItem.ToString())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Refresh the DataGridView
            LoadDepartmentData()

            ' Clear and hide the panel
            txtdeptname.Clear()
            txtdept_id.Clear()
            cboStatus.SelectedIndex = 0
            createPnl2.Visible = False
            Label7.Text = "ADD NEW"
            isEditing = False
            editingDeptId = ""

        Catch ex As Exception
            MessageBox.Show("Error saving department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class