using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Lab01_DHMT.Shapes
{
    //class Triangle to draw a triangle
    public class Triangle : Shape
    {
        public Triangle(Point start, Point end, float size, Color color)
        {
            //determine the firstPoint and SecondPoint that makes the frame of the shape
            firstPoint = start;
            double delta_X = Math.Abs(start.X - end.X);
            double delta_Y = Math.Abs(start.Y - end.Y);

            if ((delta_X * Math.Sin(Math.PI / 3)) == delta_Y)
            {
                secondPoint = end;
            }

            if (delta_Y < (delta_X * Math.Sin(Math.PI / 3)))
            {
                secondPoint.Y = end.Y;
                double k = Math.Abs(start.Y - end.Y);
                double theta = Math.Atan(2 / Math.Sqrt(3));
                if (start.X > end.X)
                    secondPoint.X = start.X - (int)(k * Math.Tan(theta));
                else
                    secondPoint.X = start.X + (int)(k * Math.Tan(theta));
            }

            if (delta_Y > (delta_X * Math.Sin(Math.PI / 3)))
            {
                secondPoint.X = end.X;
                double k = Math.Abs(start.X - end.X);
                double theta = Math.Atan(Math.Sqrt(3) / 2);
                if (start.Y > end.Y)
                    secondPoint.Y = start.Y - (int)(k * Math.Tan(theta));
                else
                    secondPoint.Y = start.Y + (int)(k * Math.Tan(theta));
            }

            _size = size;
            _color = color;
        }

        public override void Draw(OpenGLControl glControl)
        {
            double x_Center = (double)(firstPoint.X + secondPoint.X) / 2;

            base.Draw(glControl);

            var glCtrl = glControl.OpenGL;
            glCtrl.Begin(OpenGL.GL_LINE_LOOP);
            glCtrl.Vertex(secondPoint.X, glControl.Height - secondPoint.Y);
            glCtrl.Vertex(firstPoint.X, glControl.Height - secondPoint.Y);
            glCtrl.Vertex(x_Center, glControl.Height - firstPoint.Y);
            glCtrl.End();
            glCtrl.Flush();
        }
    }
}
