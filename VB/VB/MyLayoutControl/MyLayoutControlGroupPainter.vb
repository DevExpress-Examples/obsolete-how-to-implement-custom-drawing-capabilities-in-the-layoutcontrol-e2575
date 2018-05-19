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

Namespace WindowsApplication1
	Public Class MyLayoutControlGroupPainter
		Inherits LayoutControlGroupPainter

		Private _LayoutControl As MyLayoutControl
		Public Sub New(ByVal lc As MyLayoutControl)
			_LayoutControl = lc
		End Sub


		Protected Overrides Sub DrawBackground(ByVal e As BaseLayoutItemViewInfo)
			Dim args As New CustomDrawEventArgs(e)
			MyBase.DrawBackground(e)
			_LayoutControl.OnCustomDrawBackground(args)
			If args.Handled Then
				Return
			End If
			MyBase.DrawBackground(e)
		End Sub

		Protected Overrides Sub DrawSelection(ByVal e As BaseLayoutItemViewInfo)
			Dim args As New CustomDrawEventArgs(e)
			MyBase.DrawSelection(e)
			_LayoutControl.OnCustomDrawSelection(args)
			If args.Handled Then
				Return
			End If
			MyBase.DrawSelection(e)
		End Sub

		Protected Overrides Sub DrawTextArea(ByVal e As BaseLayoutItemViewInfo)
			Dim args As New CustomDrawEventArgs(e)
			MyBase.DrawTextArea(e)
			_LayoutControl.OnCustomDrawTextArea(args)
			If args.Handled Then
				Return
			End If
			MyBase.DrawTextArea(e)
		End Sub

		Public Overrides Sub DrawControlsArea(ByVal e As BaseLayoutItemViewInfo)
			Dim args As New CustomDrawEventArgs(e)
			MyBase.DrawControlsArea(e)
			_LayoutControl.OnCustomDrawControlsArea(args)
			If args.Handled Then
				Return
			End If
			MyBase.DrawControlsArea(e)
		End Sub
	End Class
End Namespace
