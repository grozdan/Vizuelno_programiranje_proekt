using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    public class BtnForward : ButtonShape
    {
        public BtnForward()
        {
            this.ImgCurr = Properties.Resources.forward;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Forward");
            this.ImgCurr = Properties.Resources.forwardHoverButton;
            Invalidate(true);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ImgCurr = Properties.Resources.forward;
            Invalidate(true);
        }
    }
}
