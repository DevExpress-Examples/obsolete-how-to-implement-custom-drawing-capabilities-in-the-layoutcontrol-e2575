using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraLayout.Registrator;
using DevExpress.XtraLayout;
using DevExpress.LookAndFeel;
using DevExpress.XtraLayout.Painting;
using DevExpress.XtraLayout.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;
using DevExpress.Utils;
using System.Collections;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void myLayoutControl1_CustomDrawBackground(object sender, CustomDrawEventArgs e)
        {
            if (e.Args.Owner == layoutControlGroup2)
            {
                Rectangle bounds = ((GroupObjectInfoArgs)(e.Args.BorderInfo)).ClientBounds;
                e.Args.Graphics.FillRectangle(Brushes.Red, bounds);
                e.Args.Graphics.DrawString("Custom draw", AppearanceObject.DefaultFont, Brushes.Yellow, bounds);
                e.Handled = true;
            }
        }

        private void myLayoutControl1_CustomDrawControlsArea(object sender, CustomDrawEventArgs e)
        {
            if (e.Args.Owner == layoutControlGroup3)
            {
                foreach (BaseLayoutItem item in new ArrayList(layoutControlGroup3.Items))
                    e.Args.Graphics.DrawString("--Custom draw--", AppearanceObject.DefaultFont, Brushes.Red, item.ViewInfo.BoundsRelativeToControl);
                e.Handled = true;
            }
        }


        private void myLayoutControl1_CustomDrawSelection(object sender, CustomDrawEventArgs e)
        {
            LayoutControlGroup group = e.Args.Owner as LayoutControlGroup;
            if (group != null)
                if (group.ViewInfo.State == ObjectState.Selected)
                {
                    Rectangle rect = e.Args.PainterBoundsRelativeToControl;
                    rect.Inflate(-6, -6);
                    e.Args.Graphics.DrawRectangle(new Pen(Brushes.Red, 5), rect);
                }
            e.Handled = true;

        }

        private void myLayoutControl1_CustomDrawTextArea(object sender, CustomDrawEventArgs e)
        {
            e.Handled = true;
        }
    }
}