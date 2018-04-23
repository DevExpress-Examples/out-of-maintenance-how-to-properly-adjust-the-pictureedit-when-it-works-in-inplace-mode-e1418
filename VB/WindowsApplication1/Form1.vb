Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			Dim dt As DataTable = New DataTable()
			dt.Columns.Add("Photo", GetType(Image))
			dt.Columns.Add("Test")
			dt.Rows.Add(New Object() { Image.FromFile("..\..\Creek.jpg"), "test1" })
			dt.Rows.Add(New Object() { Image.FromFile("..\..\Creek.jpg"), "test2" })
			dt.Rows.Add(New Object() { Image.FromFile("..\..\Creek.jpg"), "test3" })

			gridControl1.DataSource = dt

			Dim item As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()

			gridControl1.RepositoryItems.Add(item)
			gridView1.Columns("Photo").ColumnEdit = item



		End Sub
	End Class
End Namespace