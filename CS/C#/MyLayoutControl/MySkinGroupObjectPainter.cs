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
    public class MySkinGroupObjectPainter : SkinGroupObjectPainter
    {
        public MySkinGroupObjectPainter(IPanelControlOwner owner, ISkinProvider provider)
            : base(owner, provider)
        {

        }

        public override void DrawObject(ObjectInfoArgs e)
        {
            base.DrawObject(e);
        }

    }
}
