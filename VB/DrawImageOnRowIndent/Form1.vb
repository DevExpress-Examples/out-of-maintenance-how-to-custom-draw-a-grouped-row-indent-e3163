Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base

Namespace DrawImageOnRowIndent
	Partial Public Class Form1
		Inherits Form
		Private dt As DataTable
		Private IconPainter As GridIconPainter
		Public Sub New()
			InitializeComponent()
			dt = New DataTable()
			dt.Columns.Add("Data")
			dt.Columns.Add("Group1")
			dt.Columns.Add("Group2")
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dt.Rows.Add("data 1", 1, 1)
			dt.Rows.Add("data 2", 1, 2)
			dt.Rows.Add("data 3", 1, 1)
			dt.Rows.Add("data 4", 2, 2)
			dt.Rows.Add("data 5", 2, 1)
			dt.Rows.Add("data 6", 3, 2)
			dt.Rows.Add("data 7", 3, 1)
			dt.Rows.Add("data 8", 4, 2)
			gridControl1.DataSource = dt
			IconPainter = New GridIconPainter(gridView1)

			IconPainter.RowIcons.Add(0, My.Resources.Icon1)
			IconPainter.RowIcons.Add(2, My.Resources.Icon2)
			IconPainter.RowIcons.Add(4, My.Resources.Icon1)
			IconPainter.RowIcons.Add(5, My.Resources.Icon2)
			IconPainter.RowIcons.Add(7, My.Resources.Icon1)
		End Sub
	End Class
End Namespace
