Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class student_grades

    Private connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"


    Private Sub student_grades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAcademicPeriodLabels()
        LoadStudentInfo()
        LoadEnrolledSubjectsAndGrades()
    End Sub
    Private Sub UpdateAcademicPeriodLabels()
        ' Get current school year and semester
        Dim currentSchoolYear As String = ""
        Dim currentSemester As String = ""
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Get current school year
                Using cmdYear As New MySqlCommand("SELECT school_year FROM school_year_table WHERE status = 'Open'", conn)
                    Dim currentYear = Convert.ToString(cmdYear.ExecuteScalar())
                    lblSchoolYr.Text = If(String.IsNullOrEmpty(currentYear), "No Active School Year", currentYear)
                End Using

                ' Get current semester
                Using cmdSem As New MySqlCommand("SELECT semester FROM semester_table WHERE status = 'Open'", conn)
                    Dim currentSem = Convert.ToString(cmdSem.ExecuteScalar())
                    lblSem.Text = If(String.IsNullOrEmpty(currentSem), "No Active Semester", currentSem)
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error updating academic period labels: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadStudentInfo()
        ' Get the currently logged-in student ID (adjust as needed)
        Dim studId As String = Login.CurrentStudentID ' Or use your actual property for the logged-in user

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT last_name, first_name, middle_name, course_code, year_level FROM students WHERE stud_id = @stud_id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@stud_id", studId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            LblFullName.Text = $"{reader("last_name")}, {reader("first_name")} {reader("middle_name")}"
                            lblCourse.Text = reader("course_code").ToString()
                            lblStudentID.Text = studId
                            LblYearLevel.Text = reader("year_level").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading student info: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub LoadEnrolledSubjectsAndGrades()
        Dim studId As String = Login.CurrentStudentID ' Adjust as needed
        Dim schoolYear As String = lblSchoolYr.Text
        Dim semester As String = lblSem.Text

        ' Load enrolled subjects
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Enrolled subjects
                Dim subjQuery As String = "SELECT sub_code, subject_name, section FROM student_subjects WHERE stud_id = @stud_id AND school_year = @school_year AND semester = @semester"
                Using subjCmd As New MySqlCommand(subjQuery, conn)
                    subjCmd.Parameters.AddWithValue("@stud_id", studId)
                    subjCmd.Parameters.AddWithValue("@school_year", schoolYear)
                    subjCmd.Parameters.AddWithValue("@semester", semester)
                    Using da As New MySqlDataAdapter(subjCmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvEnrolledSubjects.DataSource = dt
                    End Using
                End Using

                ' Grades for enrolled subjects
                Dim gradesQuery As String = "
                SELECT 
                    ss.sub_code, 
                    ss.subject_name, 
                    g.prelim, 
                    g.midterm, 
                    g.prefinal, 
                    g.final, 
                    g.final_grade, 
                    g.remarks
                FROM student_subjects ss
                LEFT JOIN grades g ON ss.stud_id = g.stud_id AND ss.sub_code = g.sub_code
                WHERE ss.stud_id = @stud_id AND ss.school_year = @school_year AND ss.semester = @semester"
                Using gradesCmd As New MySqlCommand(gradesQuery, conn)
                    gradesCmd.Parameters.AddWithValue("@stud_id", studId)
                    gradesCmd.Parameters.AddWithValue("@school_year", schoolYear)
                    gradesCmd.Parameters.AddWithValue("@semester", semester)
                    Using da As New MySqlDataAdapter(gradesCmd)
                        Dim dtGrades As New DataTable()
                        da.Fill(dtGrades)
                        dgvgrades.DataSource = dtGrades
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading enrolled subjects or grades: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click

        Hide()
        Login.Show()
    End Sub


    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim font As New Font("Arial", 11)
    '    Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
    '    Dim brush As New SolidBrush(Color.Black)
    '    Dim x As Integer = 50
    '    Dim y As Integer = 100

    '    Try
    '        Dim logoPath As String = System.IO.Path.Combine(Application.StartupPath, "loa.png")
    '        If System.IO.File.Exists(logoPath) Then
    '            Using logo As Image = Image.FromFile(logoPath)
    '                e.Graphics.DrawImage(logo, x, y, 100, 100)
    '            End Using
    '        Else
    '            MessageBox.Show("Logo file not found at: " & logoPath)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error loading logo: " & ex.Message)
    '    End Try

    '    y += 120

    '    e.Graphics.DrawString("STUDENT GRADE REPORT", New Font("Arial", 14, FontStyle.Bold), brush, x, y)
    '    y += 40
    '    e.Graphics.DrawString("Name: " & LblFullName.Text, font, brush, x, y)
    '    y += 25
    '    e.Graphics.DrawString("Student ID: " & lblStudentID.Text, font, brush, x, y)
    '    y += 25
    '    e.Graphics.DrawString("Course: " & lblCourse.Text, font, brush, x, y)
    '    y += 25
    '    e.Graphics.DrawString("Year Level: " & LblYearLevel.Text, font, brush, x, y)
    '    y += 40

    '    ' === Table Headers ===
    '    Dim colHeaders As String() = {"Prelim", "Midterm", "Prefinal", "Final", "Final Grade", "Remarks"}
    '    Dim colX() As Integer = {x, x + 80, x + 170, x + 270, x + 360, x + 470}

    '    For i As Integer = 0 To colHeaders.Length - 1
    '        e.Graphics.DrawString(colHeaders(i), headerFont, brush, colX(i), y)
    '    Next
    '    y += 30

    '    ' === Table Data ===
    '    For Each row As DataGridViewRow In dgvgrades.Rows
    '        If Not row.IsNewRow Then
    '            e.Graphics.DrawString(row.Cells("prelim").Value?.ToString(), font, brush, colX(0), y)
    '            e.Graphics.DrawString(row.Cells("midterm").Value?.ToString(), font, brush, colX(1), y)
    '            e.Graphics.DrawString(row.Cells("pfinal").Value?.ToString(), font, brush, colX(2), y)
    '            e.Graphics.DrawString(row.Cells("final").Value?.ToString(), font, brush, colX(3), y)
    '            e.Graphics.DrawString(row.Cells("final_grade").Value?.ToString(), font, brush, colX(4), y)
    '            e.Graphics.DrawString(row.Cells("remarkss").Value?.ToString(), font, brush, colX(5), y)
    '            y += 25
    '        End If
    '    Next
    'End Sub


    'Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
    '    PrintPreviewDialog1.Document = PrintDocument1
    '    PrintPreviewDialog1.ShowDialog()
    'End Sub
End Class