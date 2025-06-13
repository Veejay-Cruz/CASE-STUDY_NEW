Imports System.Drawing.Printing

Public Class student_grades

    Private connString As String = "server=localhost;port=3306;user id=root;password=;database=loa_grading_system"


    Private Sub student_grades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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