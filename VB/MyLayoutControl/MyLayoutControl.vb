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
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyLayoutControl
		Inherits LayoutControl
		Public Event CustomDrawBackground As CustomDrawEventHandler
		Public Event CustomDrawTextArea As CustomDrawEventHandler
		Public Event CustomDrawControlsArea As CustomDrawEventHandler
		Public Event CustomDrawSelection As CustomDrawEventHandler

		Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
			Return New MyLayoutControlImplementor(Me)
		End Function


		#Region "OnCustomDrawBackground"
		''' <summary>
		''' Triggers the CustomDrawBackground event.
		''' </summary>
		Public Overridable Sub OnCustomDrawBackground(ByVal ea As CustomDrawEventArgs)
			RaiseEvent CustomDrawBackground(Me, ea)
		End Sub
		#End Region
		#Region "OnCustomDrawTextArea"
		''' <summary>
		''' Triggers the CustomDrawTextArea event.
		''' </summary>
		Public Overridable Sub OnCustomDrawTextArea(ByVal ea As CustomDrawEventArgs)
			RaiseEvent CustomDrawTextArea(Me, ea)
		End Sub
		#End Region
		#Region "OnCustomDrawControlsArea"
		''' <summary>
		''' Triggers the CustomDrawControlsArea event.
		''' </summary>
		Public Overridable Sub OnCustomDrawControlsArea(ByVal ea As CustomDrawEventArgs)
			RaiseEvent CustomDrawControlsArea(Me, ea)
		End Sub
		#End Region
		#Region "OnCustomDrawSelection"
		''' <summary>
		''' Triggers the CustomDrawSelection event.
		''' </summary>
		Public Overridable Sub OnCustomDrawSelection(ByVal ea As CustomDrawEventArgs)
			RaiseEvent CustomDrawSelection(Me, ea)
		End Sub
		#End Region
	End Class
End Namespace