Imports Microsoft.VisualBasic
Imports System
Namespace DrawImageOnRowIndent
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colGroup1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colGroup2 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(284, 262)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colData, Me.colGroup1, Me.colGroup2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGroup1, DevExpress.Data.ColumnSortOrder.Ascending)})
			' 
			' colData
			' 
			Me.colData.Caption = "Data"
			Me.colData.FieldName = "Data"
			Me.colData.Name = "colData"
			Me.colData.Visible = True
			Me.colData.VisibleIndex = 0
			' 
			' colGroup1
			' 
			Me.colGroup1.Caption = "Group1"
			Me.colGroup1.FieldName = "Group1"
			Me.colGroup1.Name = "colGroup1"
			' 
			' colGroup2
			' 
			Me.colGroup2.Caption = "Group2"
			Me.colGroup2.FieldName = "Group2"
			Me.colGroup2.Name = "colGroup2"
			Me.colGroup2.Visible = True
			Me.colGroup2.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colData As DevExpress.XtraGrid.Columns.GridColumn
		Private colGroup1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colGroup2 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

