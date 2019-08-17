Public Class Student
    Inherits Person

    Public Property StudentID As String
    Public Property GPA As Double

    Public Sub New(ByVal n As String, ByVal a As Integer, ByVal s As String, ByVal g As Double)
        MyBase.New(n, a)
        StudentID = s
        GPA = g
    End Sub

    Public Sub New()
        MyBase.New()
        StudentID = " "
        GPA = 0.0
    End Sub

    Public Function CalcGPA(grades() As Double, num As Integer) As Double
        Dim totalPoints As Double = 0
        For i As Integer = 0 To 9
            If grades(i) >= 90 Then
                totalPoints += 4
            ElseIf grades(i) >= 80 Then
                totalPoints += 3
            ElseIf grades(i) >= 70 Then
                totalPoints += 2
            ElseIf grades(i) >= 60 Then
                totalPoints += 1
            Else
                totalPoints += 0
            End If
        Next i
        GPA = totalPoints / 10.0
        Return GPA
    End Function

    Public Overrides Function toFile() As String
        Dim gpaString As String
        gpaString = Name & ", " & Age & " ," & StudentID & ", " & GPA.ToString
        Return gpaString
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & ", " & StudentID & ", " & GPA.ToString & Chr(10)
    End Function

End Class
