using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPProject
{
    public class Curves : DrawingShapes
    {
        private List<int> linesGreen;
        private List<int> linesBlue;

        public Curves(PictureBox picGraph)
            : base(picGraph)
        {
            pnb = new Pen(Color.Blue, 1);
            png = new Pen(Color.Green, 1);
            SIZE = picGraph.Width / 2;

            linesGreen = new List<int>();
            linesBlue = new List<int>();
        }

        public override void Draw()
        {
            linesGreen.Clear();
            linesBlue.Clear();
            for (int i = 0; i < SIZE; i++)
            {
                linesGreen.Add(random.Next(0, 100));
                linesBlue.Add(random.Next(30, 70));
            }
            Bitmap bufl = new Bitmap(picGraph.Width, picGraph.Height);
            Graphics g = Graphics.FromImage(bufl);
            g.FillRectangle(brush, 0, 0, picGraph.Width, picGraph.Height);
            for (int i = 1; i < SIZE; i++)
            {
                g.DrawLine(png, (i - 1) * 2, 100 - linesGreen[i - 1], i * 2, 100 - linesGreen[i]);
                g.DrawLine(pnb, (i - 1) * 2, 100 - linesBlue[i - 1], i * 2, 100 - linesBlue[i]);
            }
            picGraph.CreateGraphics().DrawImageUnscaled(bufl, 0, 0);
        }

        public override void stopDrawing()
        {
            picGraph.CreateGraphics().FillRectangle(brush, 0, 0, picGraph.Width, picGraph.Height);
        }
    }
}
