using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    public class BtnShuffle : ButtonShape
    {
        public BtnShuffle()
        {
            this.ImgCurr = Properties.Resources.shuffleButton;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Shuffle: Off/On");
            this.ImgCurr = Properties.Resources.shuffleButtonHover;
            Invalidate(true);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ImgCurr = Properties.Resources.shuffleButton;
            Invalidate(true);
        }
    }
}
