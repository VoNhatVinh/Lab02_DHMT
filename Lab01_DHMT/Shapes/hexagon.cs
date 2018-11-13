using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Lab01_DHMT.Shapes
{
    //class hexagon to draw a hexagon
    public class hexagon : Shape
    {
        public hexagon(Point start, Point end, float size, Color color)
        {
            firstPoint = start;

            double theta = Math.Atan(Math.Sqrt(3) / 2);//angle created by route line between 2 point so be stand
            double delta_X = Math.Abs(start.X - end.X);
            double delta_Y = Math.Abs(start.Y - end.Y);

            //determine secondPoint to draw frame
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

            double delta_Y = (double)(firstPoint.Y - secondPoint.Y) / 4;
            double x_Center = (double)(firstPoint.X + secondPoint.X) / 2;

            base.Draw(glControl);
            var glCtrl = glControl.OpenGL;
            glCtrl.Begin(OpenGL.GL_LINE_LOOP);
           
            //determine the points of hexagon
            glCtrl.Vertex(x_Center, glControl.Height - firstPoint.Y);
            glCtrl.Vertex(secondPoint.X, glControl.Height - (firstPoint.Y - delta_Y));
            glCtrl.Vertex(secondPoint.X, glControl.Height - (secondPoint.Y + delta_Y));
            glCtrl.Vertex(x_Center, glControl.Height - secondPoint.Y);
            glCtrl.Vertex(firstPoint.X, glControl.Height - (secondPoint.Y + delta_Y));
            glCtrl.Vertex(firstPoint.X, glControl.Height - (firstPoint.Y - delta_Y));   

            glCtrl.End();
            glCtrl.Flush();
        }
    }
}
