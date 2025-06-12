Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class courses
    Dim connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"

    Private Sub course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV3.AutoGenerateColumns = False

        DGV3.Columns("id").DataPropertyName = "course_id"
        DGV3.Columns("code").DataPropertyName = "course_code"
        DGV3.Columns("cname").DataPropertyName = "course_name"
        DGV3.Columns("major").DataPropertyName = "major"
        DGV3.Columns("dept").DataPropertyName = "department"

        DGV3_Load()
        createPnl2.Hide()
    End Sub


    Public Sub DGV3_Load()
        Dim conn As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=loa_grading_system")
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim query As String = "
                SELECT c.course_id, c.course_code, c.course_name, c.major, d.department_id as department 
                FROM courses c 
                LEFT JOIN department d ON c.department_id = d.department_id"
            da = New MySqlDataAdapter(query, conn)
            da.Fill(dt)
            DGV3.DataSource = dt
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub createLbl_Click(sender As Object, e As EventArgs)
        createPnl2.Show()
    End Sub


    Private Sub ForeverButton1_Click(sender As Object, e As EventArgs) Handles ForeverButton1.Click
        If String.IsNullOrWhiteSpace(course_id.Text) OrElse String.IsNullOrWhiteSpace(course_code.Text) OrElse String.IsNullOrWhiteSpace(course_name.Text) Then
            MessageBox.Show("Please fill up required fields!")
            Return
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO courses (course_id, course_code, course_name, major, department_id) " &
                                      "VALUES (@course_id, @course_code, @course_name, @majorr, @department)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@course_id", course_id.Text)
                    cmd.Parameters.AddWithValue("@course_code", course_code.Text)
                    cmd.Parameters.AddWithValue("@course_name", course_name.Text)
                    cmd.Parameters.AddWithValue("@majorr", majorr.Text)
                    cmd.Parameters.AddWithValue("@department", department.Text)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data Saved Successfully.")
                createPnl2.Hide()
                Me.Show()
                DGV3_Load()

                course_id.Clear()
                course_code.Clear()
                course_name.Clear()
                majorr.Clear()
                department.SelectedIndex = -1

            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Error: Course ID already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Database Error: " & ex.Message)
                End If
            End Try
        End Using
    End Sub

    Private Sub createPnl2_Paint(sender As Object, e As PaintEventArgs) Handles createPnl2.Paint
        'Populate department ComboBox from database
        If department.Items.Count = 0 Then
            Try
                Using conn As New MySqlConnection(connString)
                    conn.Open()
                    Dim query As String = "SELECT department_id FROM department ORDER BY department_id"
                    Using cmd As New MySqlCommand(query, conn)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                department.Items.Add(reader("department_id").ToString())
                            End While
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading departments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub createLbl_Click_1(sender As Object, e As EventArgs) Handles createLbl.Click
        createPnl2.Show()
        course_id.Text = GenerateNextCourseId()
    End Sub

    Private Sub ForeverButton2_Click(sender As Object, e As EventArgs) Handles ForeverButton2.Click
        createPnl2.Hide()
        course_id.Clear()
        course_code.Clear()
        course_name.Clear()
        majorr.Clear()
        department.SelectedIndex = -1
    End Sub


    Private Function GenerateNextCourseId() As String
        Dim nextId As String = ""
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Get the highest numeric part of sub_id
                Dim query As String = "SELECT MAX(CAST(SUBSTRING(course_id, 7) AS UNSIGNED)) FROM courses WHERE course_id LIKE 'course%'"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Dim lastNum As Integer = Convert.ToInt32(result)
                        nextId = "course" & (lastNum + 1).ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error generating Subject ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return nextId
    End Function

End Class