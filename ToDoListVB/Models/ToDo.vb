Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations


Public Class ToDo
    Public Property ID() As Integer

    <Required(ErrorMessage:="Description is required!")>
    Public Property Description() As String
    Public Property IsDone() As Boolean
    Public Property CreationDate() As Date

    <Required(ErrorMessage:="Importance level Required"), Range(1, 10, ErrorMessage:="Importance level must be between 1 and 10")>
    Public Property Importance() As Integer

    Public Sub New()
        CreationDate = Date.Now
    End Sub

End Class

Public Class ToDoDBContext
    Inherits DbContext
    Public Property ToDoes() As DbSet(Of ToDo)
End Class
