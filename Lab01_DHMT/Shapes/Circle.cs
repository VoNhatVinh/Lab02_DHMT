using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_DHMT.Shapes
{
    class Circle : Shape
    {
        public Point center, start;
        public int R;
        public float p;

        public Circle(Point start_1, Point end, float size, Color color)
        {
            firstPoint = start_1;
            double size_X = Math.Abs(start_1.X - end.X);
            double size_Y = Math.Abs(start_1.Y - end.Y);

            if (size_X == size_Y)
                secondPoint = end;

            if (size_X < size_Y)
            {
                secondPoint.X = end.X;
                if (start.Y > end.Y)
                {
                    secondPoint.Y = firstPoint.Y - (int)size_X;
                }
                else
                {
                    secondPoint.Y = firstPoint.Y + (int)size_X;
                }
            }

            if (size_X > size_Y)
            {
                secondPoint.Y = end.Y;
                if (start_1.X > end.X)
                {
                    secondPoint.X = firstPoint.X - (int)size_Y;
                }
                else
                {
                    secondPoint.X = firstPoint.X + (int)size_Y;
                }
            }

            if (firstPoint == secondPoint)
                return;

            //_width = R;
            _size = size;
            _color = color;
            center = new Point((firstPoint.X + secondPoint.X) / 2, (firstPoint.Y + secondPoint.Y) / 2);
            R = (int)Math.Sqrt(Math.Pow(secondPoint.X - center.X, 2) + Math.Pow(secondPoint.Y - center.Y, 2));
            start = new Point(0, R);

        }

        public override void Draw(OpenGLControl glControl)
        {
            start = new Point(0, R);
            float x = 0;
            float y = 2 * R;
            float p = 1 - y;


            base.Draw(glControl);
            var glCtrl = glControl.OpenGL;
            glCtrl.PointSize(_size);

            while (x < y)
            {
                if (start.X > start.Y)
                {
                    glCtrl.Flush();
                    return;
                }

                glCtrl.Begin(OpenGL.GL_POINTS);
                glCtrl.Vertex(center.X - start.X, glControl.Height - (center.Y - start.Y));
                glCtrl.Vertex(center.X + start.X, glControl.Height - (center.Y + start.Y));
                glCtrl.Vertex(center.X - start.X, glControl.Height - (center.Y + start.Y));
                glCtrl.Vertex(center.X + start.X, glControl.Height - (center.Y - start.Y));
                glCtrl.Vertex(center.X - start.Y, glControl.Height - (center.Y - start.X));
                glCtrl.Vertex(center.X + start.Y, glControl.Height - (center.Y + start.X));
                glCtrl.Vertex(center.X - start.Y, glControl.Height - (center.Y + start.X));
                glCtrl.Vertex(center.X + start.Y, glControl.Height - (center.Y - start.X));
                glCtrl.End();
                start.X++;
                x += 2;
                if (p < 0)
                {
                    p += x + 1;

                }
                else
                {
                    start.Y--;
                    y -= 2;
                    p += (x - y) + 1;

                }
            }
        }
    }
}