Imports MySql.Data.MySqlClient

Public Class audit_trail
    Private Sub audit_trail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV2.AutoGenerateColumns = False

        DGV2.Columns("uname").DataPropertyName = "username"
        DGV2.Columns("dt").DataPropertyName = "date_time"
        DGV2.Columns("action").DataPropertyName = "action"
        DGV2_Load()

    End Sub

    Public Sub DGV2_Load()
        Dim conn As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=loa_grading_system")
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim query As String = "
                SELECT * FROM audit_trail"
            da = New MySqlDataAdapter(query, conn)
            da.Fill(dt)
            DGV2.DataSource = dt
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub closeLbl_Click(sender As Object, e As EventArgs) Handles closeLbl.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub searchTxt_TextChanged(sender As Object, e As EventArgs) Handles searchTxt.TextChanged
        Dim conn As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=loa_grading_system")
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()

        Dim query As String = "SELECT * FROM audit_trail " &
                          "WHERE username LIKE @search OR " &
                          "action LIKE @search"
        Try
            conn.Open()
            da = New MySqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@search", "%" & searchTxt.Text & "%")
            da.Fill(dt)
            DGV2.DataSource = dt
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
