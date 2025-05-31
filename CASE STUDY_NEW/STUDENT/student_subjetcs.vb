Imports MySql.Data.MySqlClient

Public Class student_subjetcs
    Private connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"
    Public Property StudentId As String

    ' Constructor to receive student ID
    Public Sub New(ByVal studId As String)
        InitializeComponent()
        StudentId = studId
    End Sub

    ' Default constructor required by Windows Forms
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub student_subjetcs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize DGVSub
        InitializeDataGridView()

        ' Load student's subjects
        LoadStudentSubjects()
    End Sub

    Private Sub InitializeDataGridView()
        ' Set up the DataGridView columns
        DGVSub.AutoGenerateColumns = False
        DGVSub.Columns.Clear()

        ' Add columns
        DGVSub.Columns.Add("subject_code", "Subject Code")
        DGVSub.Columns.Add("subject_name", "Subject Name")
        DGVSub.Columns.Add("unit", "Units")

        ' Set DataPropertyNames
        DGVSub.Columns("subject_code").DataPropertyName = "sub_code"
        DGVSub.Columns("subject_name").DataPropertyName = "subject_name"
        DGVSub.Columns("unit").DataPropertyName = "unit"
    End Sub

    Private Sub LoadStudentSubjects()
        If String.IsNullOrEmpty(StudentId) Then
            MessageBox.Show("Student ID is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

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

                ' First verify if student exists
                Dim verifyStudentQuery = "SELECT COUNT(*) FROM students WHERE stud_id = @studId"
                Using cmdVerify As New MySqlCommand(verifyStudentQuery, conn)
                    cmdVerify.Parameters.AddWithValue("@studId", StudentId)
                    Dim studentExists As Integer = Convert.ToInt32(cmdVerify.ExecuteScalar())
                    If studentExists = 0 Then
                        MessageBox.Show($"Student with ID {StudentId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Query to get student's current subjects
                Dim query As String = "SELECT DISTINCT s.sub_code, s.subject_name, s.unit " &
                                    "FROM student_subjects ss " &
                                    "INNER JOIN subjects s ON ss.sub_id = s.sub_id " &
                                    "WHERE ss.stud_id = @studId " &
                                    "AND ss.school_year = @schoolYear " &
                                    "AND ss.semester = @semester"

                Using da As New MySqlDataAdapter()
                    da.SelectCommand = New MySqlCommand(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@studId", StudentId)
                    da.SelectCommand.Parameters.AddWithValue("@schoolYear", currentSchoolYear)
                    da.SelectCommand.Parameters.AddWithValue("@semester", currentSemester)

                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show($"No subjects found for student {StudentId} in {currentSemester} {currentSchoolYear}.",
                                      "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    DGVSub.DataSource = dt
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading subjects: " & ex.Message & vbCrLf & "Student ID: " & StudentId,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class