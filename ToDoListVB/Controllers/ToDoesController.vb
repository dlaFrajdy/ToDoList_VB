Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ToDoListVB

Namespace Controllers
    Public Class ToDoesController
        Inherits System.Web.Mvc.Controller

        Private db As New ToDoDBContext

        ' GET: ToDoes
        Function Index() As ActionResult
            Return View()
        End Function

        Function BuildToDoTable() As ActionResult
            Return PartialView("_ToDoTable", db.ToDoes.ToList())
        End Function

        ' GET: ToDoes/Details/5
        Function Details(Optional ByVal id As Integer = 0) As ActionResult
            Dim toDo As ToDo = db.ToDoes.Find(id)
            If IsNothing(toDo) Then
                Return HttpNotFound()
            End If
            Return View(toDo)
        End Function

        ' GET: ToDoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: ToDoes/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Description,IsDone,Importance")> ByVal toDo As ToDo) As ActionResult

            If ModelState.IsValid Then
                db.ToDoes.Add(toDo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(toDo)
        End Function

        ' GET: ToDoes/Edit/5
        Function Edit(Optional ByVal id As Integer = 0) As ActionResult
            Dim toDo As ToDo = db.ToDoes.Find(id)
            If IsNothing(toDo) Then
                Return HttpNotFound()
            End If
            Return View(toDo)
        End Function

        ' POST: ToDoes/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Description,IsDone,Importance")> ByVal toDo As ToDo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(toDo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(toDo)
        End Function

        <HttpPost()>
        Function AJAXEditIsDone(ByVal value As Boolean, Optional ByVal ID As Integer = 0) As ActionResult
            If ID = 0 Then
                Return HttpNotFound()
            End If
            Dim toDo As ToDo = db.ToDoes.Find(ID)
            toDo.IsDone = value
            db.Entry(toDo).State = EntityState.Modified
            db.SaveChanges()
            Return PartialView("_ToDoTable", db.ToDoes.ToList())
        End Function

        ' GET: ToDoes/Delete/5
        Function Delete(Optional ByVal id As Integer = 0) As ActionResult
            Dim toDo As ToDo = db.ToDoes.Find(id)
            If IsNothing(toDo) Then
                Return HttpNotFound()
            End If
            Return View(toDo)
        End Function

        ' POST: ToDoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(Optional ByVal id As Integer = 0) As ActionResult
            Dim toDo As ToDo = db.ToDoes.Find(id)
            If IsNothing(toDo) Then
                Return HttpNotFound()
            End If
            db.ToDoes.Remove(toDo)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Public Function SearchIndex(ByVal id As String) As ActionResult
            Dim argName As String = id
            Dim todoes = From todo In db.ToDoes
                         Select todo

            If Not String.IsNullOrEmpty(argName) Then
                todoes = todoes.Where(Function(s) s.Description.Contains(argName))
            End If

            Return View(todoes)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
