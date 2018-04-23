Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication19
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
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			Me.galleryControl2 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient2 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.galleryControl1.SuspendLayout()
			CType(Me.galleryControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.galleryControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' galleryControl1
			' 
			Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
			Me.galleryControl1.DesignGalleryGroupIndex = 0
			Me.galleryControl1.DesignGalleryItemIndex = 0
			Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Top
			' 
			' galleryControlGallery1
			' 
			galleryItemGroup1.Caption = "Group1"
			galleryItem1.Caption = "Mercedes-Benz"
			galleryItem1.Description = "SL500 Roadster"
			galleryItem1.Image = My.Resources.Car1
			galleryItem2.Caption = "BMW"
			galleryItem2.Description = "530i"
			galleryItem2.Image = My.Resources.Car4
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2})
			Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.galleryControl1.Gallery.ImageSize = New System.Drawing.Size(128, 128)
			Me.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
			Me.galleryControl1.Gallery.ShowItemText = True
			Me.galleryControl1.Location = New System.Drawing.Point(0, 0)
			Me.galleryControl1.Name = "galleryControl1"
			Me.galleryControl1.Size = New System.Drawing.Size(678, 209)
			Me.galleryControl1.TabIndex = 0
			Me.galleryControl1.Text = "galleryControl1"
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.galleryControl1
			Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient1.Size = New System.Drawing.Size(657, 205)
			' 
			' galleryControl2
			' 
			Me.galleryControl2.Controls.Add(Me.galleryControlClient2)
			Me.galleryControl2.DesignGalleryGroupIndex = 0
			Me.galleryControl2.DesignGalleryItemIndex = 0
			Me.galleryControl2.Dock = System.Windows.Forms.DockStyle.Bottom
			' 
			' galleryControlGallery2
			' 
			Me.galleryControl2.Gallery.ImageSize = New System.Drawing.Size(128, 128)
			Me.galleryControl2.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
			Me.galleryControl2.Gallery.ShowItemText = True
			Me.galleryControl2.Location = New System.Drawing.Point(0, 248)
			Me.galleryControl2.Name = "galleryControl2"
			Me.galleryControl2.Size = New System.Drawing.Size(678, 209)
			Me.galleryControl2.TabIndex = 1
			Me.galleryControl2.Text = "galleryControl2"
			' 
			' galleryControlClient2
			' 
			Me.galleryControlClient2.GalleryControl = Me.galleryControl2
			Me.galleryControlClient2.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient2.Size = New System.Drawing.Size(657, 205)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(678, 457)
			Me.Controls.Add(Me.galleryControl2)
			Me.Controls.Add(Me.galleryControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.galleryControl1.ResumeLayout(False)
			CType(Me.galleryControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.galleryControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
		Private galleryControl2 As DevExpress.XtraBars.Ribbon.GalleryControl
		Private galleryControlClient2 As DevExpress.XtraBars.Ribbon.GalleryControlClient
	End Class
End Namespace

