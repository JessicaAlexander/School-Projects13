Public MustInherit Class Person
    Public Property Name As String
    Public Property Age As String

    Public Sub New(ByVal n As String, ByVal a As Integer)
        Name = n
        Age = a
    End Sub

    Public Sub New()
        Name = " "
        Age = " "
    End Sub

    Public MustOverride Function toFile() As String

    Public Overrides Function ToString() As String
        Return Name
        Return Age
    End Function

End Class
