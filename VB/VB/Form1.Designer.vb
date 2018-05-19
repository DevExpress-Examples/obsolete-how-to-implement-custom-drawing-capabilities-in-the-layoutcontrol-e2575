Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Me.myLayoutControl1 = New WindowsApplication1.MyLayoutControl()
			Me.colorEdit1 = New DevExpress.XtraEditors.ColorEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
			Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.simpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
			Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.simpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myLayoutControl1.SuspendLayout()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myLayoutControl1
			' 
			Me.myLayoutControl1.Controls.Add(Me.checkBox1)
			Me.myLayoutControl1.Controls.Add(Me.colorEdit1)
			Me.myLayoutControl1.Controls.Add(Me.labelControl1)
			Me.myLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myLayoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControl1.Name = "myLayoutControl1"
			Me.myLayoutControl1.Root = Me.layoutControlGroup1
			Me.myLayoutControl1.Size = New System.Drawing.Size(606, 427)
			Me.myLayoutControl1.TabIndex = 0
			Me.myLayoutControl1.Text = "myLayoutControl1"
'			Me.myLayoutControl1.CustomDrawBackground += New WindowsApplication1.CustomDrawEventHandler(Me.myLayoutControl1_CustomDrawBackground);
'			Me.myLayoutControl1.CustomDrawControlsArea += New WindowsApplication1.CustomDrawEventHandler(Me.myLayoutControl1_CustomDrawControlsArea);
'			Me.myLayoutControl1.CustomDrawSelection += New WindowsApplication1.CustomDrawEventHandler(Me.myLayoutControl1_CustomDrawSelection);
'			Me.myLayoutControl1.CustomDrawTextArea += New WindowsApplication1.CustomDrawEventHandler(Me.myLayoutControl1_CustomDrawTextArea);
			' 
			' colorEdit1
			' 
			Me.colorEdit1.EditValue = System.Drawing.Color.Empty
			Me.colorEdit1.Location = New System.Drawing.Point(135, 227)
			Me.colorEdit1.Name = "colorEdit1"
			Me.colorEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEdit1.Size = New System.Drawing.Size(312, 20)
			Me.colorEdit1.StyleController = Me.myLayoutControl1
			Me.colorEdit1.TabIndex = 5
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(24, 295)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(63, 13)
			Me.labelControl1.StyleController = Me.myLayoutControl1
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "labelControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup5, Me.layoutControlGroup6})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(606, 427)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.Red
			Me.layoutControlGroup2.AppearanceGroup.Options.UseBackColor = True
			Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 251)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(586, 156)
			Me.layoutControlGroup2.Text = "layoutControlGroup2"
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.Red
			Me.layoutControlItem1.AppearanceItemCaption.Options.UseBackColor = True
			Me.layoutControlItem1.Control = Me.labelControl1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(562, 112)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 183)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Size = New System.Drawing.Size(586, 68)
			Me.layoutControlGroup3.Text = "layoutControlGroup3"
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.colorEdit1
			Me.layoutControlItem2.CustomizationFormText = "Group caption color"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(427, 24)
			Me.layoutControlItem2.Text = "Group Caption Color"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(107, 13)
			' 
			' layoutControlGroup4
			' 
			Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4"
			Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.simpleLabelItem1})
			Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 122)
			Me.layoutControlGroup4.Name = "layoutControlGroup4"
			Me.layoutControlGroup4.Size = New System.Drawing.Size(586, 61)
			Me.layoutControlGroup4.Text = "layoutControlGroup4"
			' 
			' simpleLabelItem1
			' 
			Me.simpleLabelItem1.CustomizationFormText = "LabelsimpleLabelItem1"
			Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 0)
			Me.simpleLabelItem1.Name = "simpleLabelItem1"
			Me.simpleLabelItem1.Size = New System.Drawing.Size(562, 17)
			Me.simpleLabelItem1.Text = "LabelsimpleLabelItem1"
			Me.simpleLabelItem1.TextSize = New System.Drawing.Size(107, 13)
			' 
			' layoutControlGroup5
			' 
			Me.layoutControlGroup5.CustomizationFormText = "layoutControlGroup5"
			Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.simpleLabelItem2})
			Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 61)
			Me.layoutControlGroup5.Name = "layoutControlGroup5"
			Me.layoutControlGroup5.Size = New System.Drawing.Size(586, 61)
			Me.layoutControlGroup5.Text = "layoutControlGroup5"
			' 
			' simpleLabelItem2
			' 
			Me.simpleLabelItem2.CustomizationFormText = "LabelsimpleLabelItem2"
			Me.simpleLabelItem2.Location = New System.Drawing.Point(0, 0)
			Me.simpleLabelItem2.Name = "simpleLabelItem2"
			Me.simpleLabelItem2.Size = New System.Drawing.Size(562, 17)
			Me.simpleLabelItem2.Text = "LabelsimpleLabelItem2"
			Me.simpleLabelItem2.TextSize = New System.Drawing.Size(107, 13)
			' 
			' layoutControlGroup6
			' 
			Me.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6"
			Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.simpleLabelItem3})
			Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup6.Name = "layoutControlGroup6"
			Me.layoutControlGroup6.Size = New System.Drawing.Size(586, 61)
			Me.layoutControlGroup6.Text = "layoutControlGroup6"
			' 
			' simpleLabelItem3
			' 
			Me.simpleLabelItem3.CustomizationFormText = "LabelsimpleLabelItem3"
			Me.simpleLabelItem3.Location = New System.Drawing.Point(0, 0)
			Me.simpleLabelItem3.Name = "simpleLabelItem3"
			Me.simpleLabelItem3.Size = New System.Drawing.Size(562, 17)
			Me.simpleLabelItem3.Text = "LabelsimpleLabelItem3"
			Me.simpleLabelItem3.TextSize = New System.Drawing.Size(107, 13)
			' 
			' checkBox1
			' 
			Me.checkBox1.Location = New System.Drawing.Point(562, 227)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(20, 20)
			Me.checkBox1.TabIndex = 6
			Me.checkBox1.Text = "checkBox1"
			Me.checkBox1.UseVisualStyleBackColor = True
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.checkBox1
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(427, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(135, 24)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(107, 13)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(606, 427)
			Me.Controls.Add(Me.myLayoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myLayoutControl1.ResumeLayout(False)
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents myLayoutControl1 As MyLayoutControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private colorEdit1 As DevExpress.XtraEditors.ColorEdit
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
		Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
		Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
		Private simpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
		Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
		Private simpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
		Private checkBox1 As System.Windows.Forms.CheckBox
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem


	End Class
End Namespace

