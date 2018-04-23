Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsFormsApplication19
	Public Class DragDropHelper
		Private dragItemHitInfo As RibbonHitInfo = Nothing
		Private sourceGallery, targetGallery As GalleryControl

		Public Sub New(ByVal sourceGallery As GalleryControl, ByVal targetGallery As GalleryControl)
			Me.sourceGallery = sourceGallery
			Me.targetGallery = targetGallery
		End Sub

		Public Sub EnableDragDrop()
			AddHandler sourceGallery.MouseDown, AddressOf OnSourceGalleryMouseDown
			AddHandler sourceGallery.MouseMove, AddressOf OnSourceGalleryMouseMove

			targetGallery.AllowDrop = True
			AddHandler targetGallery.DragDrop, AddressOf OnTargetGalleryDragDrop
			AddHandler targetGallery.DragOver, AddressOf OnTargetGalleryDragOver
		End Sub

		Private Sub OnSourceGalleryMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim galControl As GalleryControl = CType(sender, GalleryControl)
			Dim hitInfo As RibbonHitInfo = galControl.CalcHitInfo(e.Location)
			If hitInfo.InGalleryItem Then
				dragItemHitInfo = hitInfo
				Return
			End If

			dragItemHitInfo = Nothing
		End Sub

		Private Sub OnSourceGalleryMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button <> MouseButtons.Left OrElse Control.ModifierKeys <> Keys.None OrElse dragItemHitInfo Is Nothing Then
				Return
			End If

			Dim dragSize As Size = SystemInformation.DragSize
			Dim dragRect As New Rectangle(dragItemHitInfo.HitPoint.X - dragSize.Width / 2, dragItemHitInfo.HitPoint.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height)
			If Not(dragRect.Contains(e.Location)) Then
				sourceGallery.DoDragDrop(dragItemHitInfo.GalleryItem, DragDropEffects.Copy)
			End If
		End Sub

		Private Sub OnTargetGalleryDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			If e.Data.GetDataPresent(GetType(GalleryItem)) Then
				e.Effect = DragDropEffects.Copy
			End If
		End Sub

		Private Sub OnTargetGalleryDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			If Not(e.Data.GetDataPresent(GetType(GalleryItem))) Then
				Return
			End If

			Dim draggedItem As GalleryItem = TryCast(e.Data.GetData(GetType(GalleryItem)), GalleryItem)

			Dim galControl As GalleryControl = CType(sender, GalleryControl)
			Dim hitInfo As RibbonHitInfo = galControl.CalcHitInfo(galControl.PointToClient(New Point(e.X, e.Y)))
			If hitInfo.InGalleryGroup Then
				hitInfo.GalleryItemGroup.Items.Add(CType(draggedItem.Clone(), GalleryItem))
			Else
				Dim groupIndex As Integer = galControl.Gallery.Groups.Add(New GalleryItemGroup())
				galControl.Gallery.Groups(groupIndex).Caption = draggedItem.GalleryGroup.Caption
				galControl.Gallery.Groups(groupIndex).Items.Add(CType(draggedItem.Clone(), GalleryItem))
			End If
		End Sub

		Public Sub DisableDragDrop()
			RemoveHandler sourceGallery.MouseDown, AddressOf OnSourceGalleryMouseDown
			RemoveHandler sourceGallery.MouseMove, AddressOf OnSourceGalleryMouseMove

			targetGallery.AllowDrop = False
			RemoveHandler targetGallery.DragDrop, AddressOf OnTargetGalleryDragDrop
			RemoveHandler targetGallery.DragOver, AddressOf OnTargetGalleryDragOver
		End Sub
	End Class
End Namespace
