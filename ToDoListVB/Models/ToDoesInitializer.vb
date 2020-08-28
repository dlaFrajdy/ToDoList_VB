Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports ToDoListVB

Namespace ToDoListVB.Models
    Public Class ToDoesInitializer
        Inherits DropCreateDatabaseIfModelChanges(Of ToDoDBContext)
        Protected Overrides Sub Seed(ByVal context As ToDoDBContext)
            Dim todoes = New List(Of ToDo) From {
                New ToDo With {.Description = "Finish a project for The Mexican Sopot", .IsDone = False, .CreationDate = Date.Now, .Importance = 5},
                New ToDo With {.Description = "Bungee", .IsDone = False, .CreationDate = Date.Now, .Importance = 3},
                New ToDo With {.Description = "Pass the exams", .IsDone = True, .CreationDate = Date.Now, .Importance = 6},
                New ToDo With {.Description = "Find a job", .IsDone = False, .CreationDate = Date.Now, .Importance = 9},
                New ToDo With {.Description = "Never get married", .IsDone = False, .CreationDate = Date.Now, .Importance = 7}
                }

            todoes.ForEach(Function(d) context.ToDoes.Add(d))
        End Sub
    End Class
End Namespace
