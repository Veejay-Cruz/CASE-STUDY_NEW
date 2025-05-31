Imports MySql.Data.MySqlClient

Public Class users
    Dim bs As New BindingSource()
    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV5.AutoGenerateColumns = False

        DGV5.Columns("un").DataPropertyName = "username"
        DGV5.Columns("id").DataPropertyName = "student_id"
        DGV5.Columns("pass").DataPropertyName = "password"

        LoadUsers()
    End Sub

    Public Sub LoadUsers()
        Dim conn As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=loa_grading_system")
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim query As String = "
                SELECT * FROM user_register"
            da = New MySqlDataAdapter(query, conn)
            da.Fill(dt)
            DGV5.DataSource = dt
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub closeLbl_Click(sender As Object, e As EventArgs) Handles closeLbl.Click
        Me.Hide()
        main.Show()
    End Sub
End Class