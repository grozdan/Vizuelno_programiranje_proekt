using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    public class BtnPause : ButtonShape
    {
        public bool isPaused { get; set; }

        public BtnPause()
        {
            this.ImgCurr = Properties.Resources.pause;
            isPaused = false;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Pause/Resume");
            this.ImgCurr = Properties.Resources.pauseHoverButton;
            Invalidate(true);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.ImgCurr = Properties.Resources.pause;
            Invalidate(true);
        }
    }
}
