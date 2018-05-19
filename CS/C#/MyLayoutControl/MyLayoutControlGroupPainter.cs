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

namespace WindowsApplication1
{
    public class MyLayoutControlGroupPainter : LayoutControlGroupPainter
    {

        private MyLayoutControl _LayoutControl;
        public MyLayoutControlGroupPainter(MyLayoutControl lc)
        {
            _LayoutControl = lc;
        }


        protected override void DrawBackground(BaseLayoutItemViewInfo e)
        {
            CustomDrawEventArgs args = new CustomDrawEventArgs(e);
            base.DrawBackground(e);
            _LayoutControl.OnCustomDrawBackground(args);
            if (args.Handled)
                return;
            base.DrawBackground(e);
        }

        protected override void DrawSelection(BaseLayoutItemViewInfo e)
        {
            CustomDrawEventArgs args = new CustomDrawEventArgs(e);
            base.DrawSelection(e);
            _LayoutControl.OnCustomDrawSelection(args);
            if (args.Handled)
                return;
            base.DrawSelection(e);
        }

        protected override void DrawTextArea(BaseLayoutItemViewInfo e)
        {
            CustomDrawEventArgs args = new CustomDrawEventArgs(e);
            base.DrawTextArea(e);
            _LayoutControl.OnCustomDrawTextArea(args);
            if (args.Handled)
                return;
            base.DrawTextArea(e);
        }

        public override void DrawControlsArea(BaseLayoutItemViewInfo e)
        {
            CustomDrawEventArgs args = new CustomDrawEventArgs(e);
            base.DrawControlsArea(e);
            _LayoutControl.OnCustomDrawControlsArea(args);
            if (args.Handled)
                return;
            base.DrawControlsArea(e);
        }
    }
}
