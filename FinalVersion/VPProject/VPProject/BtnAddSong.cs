using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    public class BtnAddSong : ButtonShape
    {
        public BtnAddSong()
        {
            this.ImgCurr = Properties.Resources.AddSong;
        }
        protected override void OnMouseHover(EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this, "Add a song");
            this.ImgCurr = Properties.Resources.AddSongHover;
            Invalidate(true);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ImgCurr = Properties.Resources.AddSong;
            Invalidate(true);
        }
    }
}
