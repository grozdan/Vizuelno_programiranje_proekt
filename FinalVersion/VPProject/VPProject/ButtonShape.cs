using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPProject
{
    public class ButtonShape : Button
    {
        protected Image ImgCurr;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            this.Image = ImgCurr;
            this.CreateGraphics().DrawImageUnscaled(ImgCurr, 0, 0);
        }
    }
}
