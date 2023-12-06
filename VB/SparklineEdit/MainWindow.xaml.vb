Imports System
Imports System.Collections
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace SparklineEdit

    Public Partial Class MainWindow
        Inherits Window

        Public Property SourceCollection As IList

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.DataContext = Me
            GenerateData(7)
        End Sub

        Private Sub GenerateData(ByVal n As Integer)
            SourceCollection = New ObservableCollection(Of CustomElement)()
            Dim rnd As Random = New Random()
            For i As Integer = 1 To n
                SourceCollection.Add(New CustomElement() With {.ArgumentColumn = New DateTime(2000, 1, i), .ValueColumn = rnd.Next(20), .FilteringColumn = 1})
            Next
        End Sub
    End Class

    Public Class CustomElement

        Public Property ArgumentColumn As Object

        Public Property ValueColumn As Integer

        Public Property FilteringColumn As Integer
    End Class
End Namespace
