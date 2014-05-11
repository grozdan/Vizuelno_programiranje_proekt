using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    public class BtnRewind : ButtonShape
    {
        public BtnRewind()
        {
            this.ImgCurr = Properties.Resources.rewind;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Rewind");
            this.ImgCurr = Properties.Resources.rewindHover;
            Invalidate(true);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.ImgCurr = Properties.Resources.rewind;
            Invalidate(true);
        }
    }
}
