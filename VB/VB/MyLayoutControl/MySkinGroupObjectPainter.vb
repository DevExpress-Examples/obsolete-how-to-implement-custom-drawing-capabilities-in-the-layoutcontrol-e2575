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
	Public Class MySkinGroupObjectPainter
		Inherits SkinGroupObjectPainter
		Public Sub New(ByVal owner As IPanelControlOwner, ByVal provider As ISkinProvider)
			MyBase.New(owner, provider)

		End Sub

		Public Overrides Overloads Sub DrawObject(ByVal e As ObjectInfoArgs)
			MyBase.DrawObject(e)
		End Sub

	End Class
End Namespace
