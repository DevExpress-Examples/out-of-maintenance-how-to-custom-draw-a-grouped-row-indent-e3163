Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DrawImageOnRowIndent
	Friend Class GridIconPainter
		Private Grid As GridControl
		Private View As GridView
		Public RowIcons As Dictionary(Of Integer, Icon)

		Public Sub New(ByVal view As GridView)
			Me.View = view
			Me.Grid = view.GridControl
			AddHandler Grid.Paint, AddressOf Grid_Paint
			RowIcons = New Dictionary(Of Integer, Icon)()
		End Sub

		Private Sub Grid_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
			Dim vi As New GridViewInfo(View)
			vi.Calc(e.Graphics, Grid.Bounds)
			For Each row As GridRowInfo In vi.RowsInfo
				If (Not row.IsGroupRow) Then
					If (Not RowIcons.ContainsKey(row.RowHandle)) Then
						Continue For
					End If
					Dim rec As Rectangle = row.Bounds
					Dim groupX As Integer = row.Level * (row.DataBounds.X - row.Bounds.X) / (row.Level + 1)
					rec.X += groupX
					rec.Width -= row.DataBounds.Width
					rec.Width -= groupX
					e.Graphics.DrawIcon(RowIcons(row.RowHandle), rec)
				End If
			Next row
		End Sub

	End Class
End Namespace
