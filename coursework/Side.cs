using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace coursework
{
    class Side
    {
        int centerX;
        int centerY;
        Point[] points;
        public Color colour;
        public Side(int centX, int centY)
        {
            centerX = centX;
            centerY = centY;
            colour = Color.White;
            points = new Point[]
            {
                new Point(centerX,centerY+50),
                new Point((int)(centerX - 25*Math.Sqrt(3)),centerY-25),
                new Point((int)(centerX + 25*Math.Sqrt(3)),centerY-25),
            };
        }
        private Point[] Flip()
        {
            return points = new Point[]
            {
                new Point(centerX,centerY-50),
                new Point((int)(centerX - 25*Math.Sqrt(3)),centerY+25),
                new Point((int)(centerX + 25*Math.Sqrt(3)),centerY+25),
            };
        }
        public void Draw(bool flip)
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            if (flip)
            {
                graphics.DrawPolygon(Pens.Black, Flip());
            }
            else
            {
                graphics.DrawPolygon(Pens.Black, points);
            }
        }
        private int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 4);
        }
        public void Paint()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();

            Brush brush = new SolidBrush(Color.White);
            graphics.FillPolygon(brush, points);
            System.Threading.Thread.Sleep(250);

            int color = GetRandomNumber();
            Color[] colors = {Color.Red, Color.Blue, Color.Green, Color.Violet};
            colour = colors[color];
            System.Threading.Thread.Sleep(250);

            Brush new_brush = new SolidBrush(colors[color]);
            graphics.FillPolygon(new_brush, points);
        }

    }
}
