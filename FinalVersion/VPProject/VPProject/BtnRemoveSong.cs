using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPProject
{
    public class BtnRemoveSong : ButtonShape
    {
        public BtnRemoveSong()
        {
            this.ImgCurr = Properties.Resources.RemoveASong;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Remove the selected song");
        }
    }
}
