Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace SparklineEdit

	Partial Public Class MainWindow
		Inherits Window

		Private privateSourceCollection As IList
		Public Property SourceCollection() As IList
			Get
				Return privateSourceCollection
			End Get
			Set(ByVal value As IList)
				privateSourceCollection = value
			End Set
		End Property

		Public Sub New()
			InitializeComponent()

			grid.DataContext = Me

			GenerateData(7)
		End Sub

		Private Sub GenerateData(ByVal n As Integer)
			SourceCollection = New ObservableCollection(Of CustomElement)()

			Dim rnd As New Random()
			For i As Integer = 1 To n
				SourceCollection.Add(New CustomElement() With {.ArgumentColumn = New DateTime(2000, 1, i), .ValueColumn = rnd.Next(20), .FilteringColumn = 1})
			Next i


		End Sub
	End Class

	Public Class CustomElement
		Private privateArgumentColumn As Object
		Public Property ArgumentColumn() As Object
			Get
				Return privateArgumentColumn
			End Get
			Set(ByVal value As Object)
				privateArgumentColumn = value
			End Set
		End Property
		Private privateValueColumn As Integer
		Public Property ValueColumn() As Integer
			Get
				Return privateValueColumn
			End Get
			Set(ByVal value As Integer)
				privateValueColumn = value
			End Set
		End Property
		Private privateFilteringColumn As Integer
		Public Property FilteringColumn() As Integer
			Get
				Return privateFilteringColumn
			End Get
			Set(ByVal value As Integer)
				privateFilteringColumn = value
			End Set
		End Property
	End Class


End Namespace
