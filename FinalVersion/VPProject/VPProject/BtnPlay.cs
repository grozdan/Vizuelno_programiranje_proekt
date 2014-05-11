using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    public class BtnPlay : ButtonShape
    {
        public BtnPlay()
        {
            this.ImgCurr = Properties.Resources.play;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Play");
            ImgCurr = Properties.Resources.playHover;
            Invalidate(true);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            ImgCurr = Properties.Resources.play;
            Invalidate(true);
        }
    }
}
