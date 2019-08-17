Public Class Form1
    Public studentArray(9) As Student
    Public studentCount As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As IO.StreamReader
        Dim fileInput As String
        Dim fields() As String
        studentCount = 0

        If IO.File.Exists("StudentGPA.txt") Then
            inFile = IO.File.OpenText("StudentGPA.txt")
            While inFile.Peek <> -1
                fileInput = inFile.ReadLine()
                fields = Split(fileInput, ",")

                Dim aStudent As New Student()
                    aStudent.Name = fields(0)
                    aStudent.Age = fields(1)
                    aStudent.StudentID = fields(2)
                    aStudent.GPA = Convert.ToDouble(fields(3))
                    studentArray(studentCount) = aStudent
                studentCount += 1
            End While
            inFile.Close()
        End If
    End Sub

    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click
        Dim strnum As String
        Dim scoreArray(10) As Double
        Dim Score As Double
        Dim StudentGPA As IO.StreamWriter
        Static studentCount As Integer = 0

        StudentGPA = IO.File.AppendText("StudentGPA.txt")
        studentArray(studentCount) = New Student()
        studentArray(studentCount).Name = TBName.Text
        studentArray(studentCount).StudentID = TXBStudentID.Text
        studentArray(studentCount).Age = TBAge.Text

        For i As Integer = 0 To 9
            strnum = InputBox("Please enter the grades.", "GPA Calculator")
            If strnum.Equals(String.Empty) Then
                i = 9
            Else
                Double.TryParse(strnum, Score)
                scoreArray(i) = Score
            End If
        Next i

        studentArray(studentCount).CalcGPA(scoreArray, 9)
        StudentGPA.WriteLine(studentArray(studentCount).toFile())
        MessageBox.Show(studentArray(studentCount).ToString(), "Successfully added to file.")
        studentCount += 1
        StudentGPA.Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim StudentID As String
        Dim found As Boolean = False

        StudentID = InputBox("Please enter the students ID")

        For i As Integer = 0 To studentCount - 1
            If studentArray(i).StudentID.Equals(StudentID) Then
                MessageBox.Show(studentArray(i).ToString())
                found = True
                i = 10
            End If
        Next i
        If Not found Then
            MessageBox.Show("Student not found!", "Not found")
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
