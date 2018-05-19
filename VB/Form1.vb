Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.XtraLayout
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraLayout.Painting
Imports DevExpress.XtraLayout.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports System.Collections

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub myLayoutControl1_CustomDrawBackground(ByVal sender As Object, ByVal e As CustomDrawEventArgs) Handles myLayoutControl1.CustomDrawBackground
			If e.Args.Owner Is layoutControlGroup2 Then
				Dim bounds As Rectangle = (CType(e.Args.BorderInfo, GroupObjectInfoArgs)).ClientBounds
				e.Args.Graphics.FillRectangle(Brushes.Red, bounds)
				e.Args.Graphics.DrawString("Custom draw", AppearanceObject.DefaultFont, Brushes.Yellow, bounds)
				e.Handled = True
			End If
		End Sub

		Private Sub myLayoutControl1_CustomDrawControlsArea(ByVal sender As Object, ByVal e As CustomDrawEventArgs) Handles myLayoutControl1.CustomDrawControlsArea
			If e.Args.Owner Is layoutControlGroup3 Then
				For Each item As BaseLayoutItem In New ArrayList(layoutControlGroup3.Items)
					e.Args.Graphics.DrawString("--Custom draw--", AppearanceObject.DefaultFont, Brushes.Red, item.ViewInfo.BoundsRelativeToControl)
				Next item
				e.Handled = True
			End If
		End Sub


		Private Sub myLayoutControl1_CustomDrawSelection(ByVal sender As Object, ByVal e As CustomDrawEventArgs) Handles myLayoutControl1.CustomDrawSelection
			Dim group As LayoutControlGroup = TryCast(e.Args.Owner, LayoutControlGroup)
			If group IsNot Nothing Then
				If group.ViewInfo.State = ObjectState.Selected Then
					Dim rect As Rectangle = e.Args.PainterBoundsRelativeToControl
					rect.Inflate(-6, -6)
					e.Args.Graphics.DrawRectangle(New Pen(Brushes.Red, 5), rect)
				End If
			End If
			e.Handled = True

		End Sub

		Private Sub myLayoutControl1_CustomDrawTextArea(ByVal sender As Object, ByVal e As CustomDrawEventArgs) Handles myLayoutControl1.CustomDrawTextArea
			e.Handled = True
		End Sub
	End Class
End Namespace