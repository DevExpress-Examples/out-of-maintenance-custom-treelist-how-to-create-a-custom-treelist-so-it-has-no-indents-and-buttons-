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
            Me.OptionsView.ShowFirstLines = False
            Me.OptionsView.ShowVertLines = False
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

        Protected Overrides Sub CalcRowIndentInfo(ByVal ri As RowInfo)
        End Sub
        Protected Overrides Function GetViewLevel(ByVal level As Integer) As Integer
            Return 0
        End Function
    End Class
End Namespace