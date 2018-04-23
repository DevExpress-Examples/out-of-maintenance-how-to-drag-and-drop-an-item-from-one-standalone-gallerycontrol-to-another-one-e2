Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsFormsApplication19
	Partial Public Class Form1
		Inherits Form
		Private helper As DragDropHelper

		Public Sub New()
			InitializeComponent()
			helper = New DragDropHelper(galleryControl1, galleryControl2)
			helper.EnableDragDrop()
		End Sub

		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			helper.DisableDragDrop()
		End Sub
	End Class
End Namespace