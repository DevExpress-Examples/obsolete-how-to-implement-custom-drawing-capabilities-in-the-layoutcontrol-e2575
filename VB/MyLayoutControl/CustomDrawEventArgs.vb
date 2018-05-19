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
	Public Class CustomDrawEventArgs


		Public Sub New(ByVal args As BaseLayoutItemViewInfo)
			_Args = args
		End Sub
		Private _Args As BaseLayoutItemViewInfo
		Public ReadOnly Property Args() As BaseLayoutItemViewInfo
			Get
				Return _Args
			End Get
		End Property
		Private _Handled As Boolean
		Public Property Handled() As Boolean
			Get
				Return _Handled
			End Get
			Set(ByVal value As Boolean)
				_Handled = value
			End Set
		End Property
	End Class

	Public Delegate Sub CustomDrawEventHandler(ByVal sender As Object, ByVal e As CustomDrawEventArgs)
End Namespace
