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
        End Using
    End Sub


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





End Class