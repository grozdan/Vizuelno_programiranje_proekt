using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPProject
{
    public class EqualizerCurve : DrawingShapes
    {
        private List<TrackBar> trackbars;
        public EqualizerCurve(PictureBox picGraph, List<TrackBar> bars)
            : base(picGraph)
        {
            png = new Pen(Color.Green, 2);

            this.trackbars = bars;
        }

        public override void Draw()
        {
            Bitmap bufl = new Bitmap(picGraph.Width, picGraph.Height);
            Graphics g = Graphics.FromImage(bufl);
            g.FillRectangle(brush, 0, 0, picGraph.Width, picGraph.Height);
            Point[] points = makePoints();
            g.DrawCurve(png, points);
            picGraph.CreateGraphics().DrawImageUnscaled(bufl, 0, 0);
        }
        public override void stopDrawing()
        {
            picGraph.CreateGraphics().FillRectangle(brush, 0, 0, picGraph.Width, picGraph.Height);
        }

        public Point[] makePoints()
        {
            int j = 7;

            Point[] points = new Point[10];
            for (int i = 0; i < 10; i++)
            {
                Point p = new Point(i + j, -(picGraph.Height / 2 + (int)trackbars[i].Value / 4) + picGraph.Height);
                points[i] = p;
                j += 14;
            }
            return points;
        }
    }
}
