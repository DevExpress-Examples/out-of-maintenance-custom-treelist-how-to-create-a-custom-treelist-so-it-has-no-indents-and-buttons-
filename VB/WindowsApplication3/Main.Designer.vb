Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
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
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.customTreeList1 = New DXSample.MyTreeList()
			CType(Me.customTreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' customTreeList1
			' 
			Me.customTreeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customTreeList1.Location = New System.Drawing.Point(0, 0)
			Me.customTreeList1.Name = "customTreeList1"
			Me.customTreeList1.OptionsView.ShowIndicator = False
			Me.customTreeList1.Size = New System.Drawing.Size(410, 357)
			Me.customTreeList1.TabIndex = 0
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(410, 357)
			Me.Controls.Add(Me.customTreeList1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "TreeList without indents"
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			CType(Me.customTreeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private customTreeList1 As MyTreeList
	End Class
End Namespace

