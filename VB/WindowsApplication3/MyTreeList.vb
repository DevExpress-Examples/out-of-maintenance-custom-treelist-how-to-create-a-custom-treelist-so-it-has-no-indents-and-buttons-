Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraTreeList.ViewInfo
Imports DevExpress.XtraTreeList
Imports System.Drawing

Namespace DXSample
	Public Class MyTreeList
		Inherits TreeList
		Public Sub New()
			MyBase.New()
			Me.OptionsView.ShowIndicator = False
		End Sub
		Public Sub New(ByVal ignore As Object)
			MyBase.New(ignore)
		End Sub

		Protected Overrides Function CreateViewInfo() As TreeListViewInfo
			Return New MyTreeListViewInfo(Me)
		End Function
	End Class

	Public Class MyTreeListViewInfo
		Inherits TreeListViewInfo
		
		Public Sub New(ByVal tree As MyTreeList)
			MyBase.New(tree)

		End Sub
		Protected Overrides Function GetDataBoundsLocation(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal top As Integer) As Point
			Dim p As Point = MyBase.GetDataBoundsLocation(node, top)
			p.X += RC.LevelWidth * (node.Level - RootLevel)
			Return p
		End Function
		Protected Overrides Sub CalcRowIndentInfo(ByVal ri As RowInfo)
		End Sub
		Protected Overrides Function GetViewLevel(ByVal level As Integer) As Integer
			Return 0
		End Function
		Protected Overrides Sub CalcRowCellsInfo(ByVal ri As RowInfo, ByVal viewInfoList As System.Collections.ArrayList)
			MyBase.CalcRowCellsInfo(ri, viewInfoList)
			ri.FloatLines.Clear()
			
			For Each line As LineInfo In ri.Lines
				If line.Rect.Height = 1 Then
					line.Rect.X = ri.Bounds.X
					line.Rect.Width = ri.Bounds.Width
				End If
			Next line
		End Sub
	End Class
End Namespace