Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraTreeList.ViewInfo
Imports DevExpress.XtraTreeList


Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim tempVar As New DevExpress.XtraTreeList.Design.XViews(customTreeList1)
        End Sub
    End Class


End Namespace
