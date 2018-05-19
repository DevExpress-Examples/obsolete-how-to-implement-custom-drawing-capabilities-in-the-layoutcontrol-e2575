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
    public class CustomDrawEventArgs
    {


        public CustomDrawEventArgs(BaseLayoutItemViewInfo args)
        {
            _Args = args;
        }
        private BaseLayoutItemViewInfo _Args;
        public BaseLayoutItemViewInfo Args
        {
            get { return _Args; }
        }
        private bool _Handled;
        public bool Handled
        {
            get { return _Handled; }
            set { _Handled = value; }
        }
    }

    public delegate void CustomDrawEventHandler(object sender, CustomDrawEventArgs e);
}
