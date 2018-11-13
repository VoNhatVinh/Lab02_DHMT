using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Lab01_DHMT.Shapes
{
    //class Pentagon to draw a pentagon
    public class Pentagon : Shape
    {
        //start is the point when you MouseDown and end is the point when you MouseUp
        //size is the size of the edge; color is the color of the shape
        public Pentagon(Point start, Point end, float size, Color color)//create function
        {
            firstPoint = start;

            double a = 1 + 2 * Math.Cos(2 * Math.PI / 5);
            double b = Math.Sin(Math.PI / 5) + Math.Sin(2 * Math.PI / 5);
            double theta = Math.Atan(a / b);//angle created by route line between 2 point so be stand
            double delta_X = Math.Abs(start.X - end.X);
            double delta_Y = Math.Abs(start.Y - end.Y);

            //determine secondPoint for drawing frames
            if (delta_X == (delta_Y * Math.Tan(theta)))
            {
                secondPoint = end;
            }

            if (delta_X < (delta_Y * Math.Tan(theta)))
            {
                secondPoint.X = end.X;
                double m = Math.PI / 2 - theta;
                double k;

                if (start.X < end.X)
                {
                    k = delta_X * Math.Tan(m);
                    secondPoint.Y = firstPoint.Y + (int)k;
                }
                else
                {
                    k = 0 - delta_X * Math.Tan(m);
                    secondPoint.Y = firstPoint.Y - (int)k;
                }
            }

            if (delta_X > (delta_Y * Math.Tan(theta)))
            {
                secondPoint.Y = end.Y;
                double k;

                if (start.X < end.X)
                {
                    k = delta_Y * Math.Tan(theta);
                }
                else
                {
                    k = 0 - delta_Y * Math.Tan(theta);
                }
                secondPoint.X = firstPoint.X + (int)k;
            }

            _size = size;
            _color = color;
        }

        public override void Draw(OpenGLControl glControl)
        {
            //calculate to determine the points of the pentagon
            double angle = 2 * Math.PI / 5;
            double x_Center = (double)(firstPoint.X + secondPoint.X) / 2;
            double high = (double)(firstPoint.Y - secondPoint.Y);
            double delta_y = high * Math.Sin(angle / 2) / (Math.Sin(angle) + Math.Sin(angle / 2));
            double half_width = (secondPoint.X - firstPoint.X) / 2;
            double delta_x = half_width * Math.Cos(angle) / (Math.Cos(angle) + 0.5);

            base.Draw(glControl);
            var glCtrl = glControl.OpenGL;

            //GL_LINE_LOOP: Connect the coordinates together in a specified order to a closed form
            glCtrl.Begin(OpenGL.GL_LINE_LOOP);

            glCtrl.Vertex(x_Center, glControl.Height - firstPoint.Y);//coordinates of point (x,y)
            glCtrl.Vertex(secondPoint.X, glControl.Height - (firstPoint.Y - delta_y));
            glCtrl.Vertex(secondPoint.X - delta_x, glControl.Height - secondPoint.Y);
            glCtrl.Vertex(firstPoint.X + delta_x, glControl.Height - secondPoint.Y);
            glCtrl.Vertex(firstPoint.X, glControl.Height - (firstPoint.Y - delta_y));

            glCtrl.End();
            glCtrl.Flush();
        }
    }
}
