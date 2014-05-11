using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPProject
{
    public class Bars : DrawingShapes
    {
        private List<Point> pointsDownBlue;
        private List<Point> pointsUpBlue;
        private List<Point> pointsDownGreen;
        private List<Point> pointsUpGreen;

        public Bars(PictureBox picGraph)
            : base(picGraph)
        {
            pnb = new Pen(Color.Blue, 2);
            png = new Pen(Color.Green, 2);
            SIZE = picGraph.Width / 10;

            pointsDownBlue = new List<Point>();
            pointsUpBlue = new List<Point>();
            pointsDownGreen = new List<Point>();
            pointsUpGreen = new List<Point>();
        }
        public override void Draw()
        {
            pointsDownBlue.Clear();
            pointsUpBlue.Clear();
            pointsDownGreen.Clear();
            pointsUpGreen.Clear();
            for (int i = 0; i < SIZE; i++)
            {
                pointsDownBlue.Add(new Point(i * 10, 100));
                pointsUpBlue.Add(new Point(i * 10, random.Next(20, 100)));

                pointsDownGreen.Add(new Point(i * 10 + 5, 100));
                pointsUpGreen.Add(new Point(i * 10 + 5, random.Next(20, 100)));
            }

            Bitmap bufl = new Bitmap(picGraph.Width, picGraph.Height);
            Graphics g = Graphics.FromImage(bufl);
            g.FillRectangle(brush, 0, 0, picGraph.Width, picGraph.Height);
            for (int i = 0; i < SIZE; i++)
            {
                g.DrawLine(pnb, pointsDownBlue[i], pointsUpBlue[i]);
                g.DrawLine(png, pointsDownGreen[i], pointsUpGreen[i]);
            }
            picGraph.CreateGraphics().DrawImageUnscaled(bufl, 0, 0);
        }

        public override void stopDrawing()
        {
            picGraph.CreateGraphics().FillRectangle(brush, 0, 0, picGraph.Width, picGraph.Height);
        }
    }
}
