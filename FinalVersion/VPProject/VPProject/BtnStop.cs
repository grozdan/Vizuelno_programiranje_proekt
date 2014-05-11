using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    public class BtnStop : ButtonShape
    {
        public BtnStop()
        {
            this.ImgCurr = Properties.Resources.stop;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Stop");
            this.ImgCurr = Properties.Resources.stop_hover;
            Invalidate(true);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ImgCurr = Properties.Resources.stop;
            Invalidate(true);
        }
    }
}
