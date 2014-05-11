using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPProject
{
    public abstract class DrawingShapes
    {
        protected Brush brush;
        protected Random random;
        protected PictureBox picGraph;
        protected Pen png;
        protected Pen pnb;
        protected int SIZE;

        public DrawingShapes(PictureBox picGraph)
        {
            brush = new SolidBrush(Color.Black);
            random = new Random();
            this.picGraph = picGraph;
        }

        public abstract void Draw();
        public abstract void stopDrawing();
    }
}
