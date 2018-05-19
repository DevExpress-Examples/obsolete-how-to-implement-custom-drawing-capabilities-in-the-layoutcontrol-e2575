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
    [System.ComponentModel.DesignerCategory("")]
    public class MyLayoutControl : LayoutControl
    {
        public event CustomDrawEventHandler CustomDrawBackground;
        public event CustomDrawEventHandler CustomDrawTextArea;
        public event CustomDrawEventHandler CustomDrawControlsArea;
        public event CustomDrawEventHandler CustomDrawSelection;

        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }

    
        #region OnCustomDrawBackground
        /// <summary>
        /// Triggers the CustomDrawBackground event.
        /// </summary>
        public virtual void OnCustomDrawBackground(CustomDrawEventArgs ea)
        {
            if (CustomDrawBackground != null)
                CustomDrawBackground(this, ea);
        }
        #endregion
        #region OnCustomDrawTextArea
        /// <summary>
        /// Triggers the CustomDrawTextArea event.
        /// </summary>
        public virtual void OnCustomDrawTextArea(CustomDrawEventArgs ea)
        {
            if (CustomDrawTextArea != null)
                CustomDrawTextArea(this, ea);
        }
        #endregion
        #region OnCustomDrawControlsArea
        /// <summary>
        /// Triggers the CustomDrawControlsArea event.
        /// </summary>
        public virtual void OnCustomDrawControlsArea(CustomDrawEventArgs ea)
        {
            if (CustomDrawControlsArea != null)
                CustomDrawControlsArea(this, ea);
        }
        #endregion
        #region OnCustomDrawSelection
        /// <summary>
        /// Triggers the CustomDrawSelection event.
        /// </summary>
        public virtual void OnCustomDrawSelection(CustomDrawEventArgs ea)
        {
            if (CustomDrawSelection != null)
                CustomDrawSelection(this, ea);
        }
        #endregion
    }
}