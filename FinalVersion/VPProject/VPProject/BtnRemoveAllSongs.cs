using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    public class BtnRemoveAllSongs : ButtonShape
    {
        public BtnRemoveAllSongs() {
            ImgCurr = Properties.Resources.izbrisiSite;
        }
        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Remove all songs");
        }

    }
}
