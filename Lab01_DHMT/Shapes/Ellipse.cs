using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Lab01_DHMT.Shapes
{
    public class Ellipse : Shape
    {
        public Ellipse(Point start, Point end, float size, Color color)
        {
            firstPoint = start;
            secondPoint = end;
            _size = size;
            _color = color;
        }

        public override void Draw(OpenGLControl glControl)
        {
            //center of the shape
            _center.X = (firstPoint.X + secondPoint.X) / 2;
            _center.Y = (firstPoint.Y + secondPoint.Y) / 2;

            //radiusX and radiusY
            double ra_X = Math.Abs((firstPoint.X - secondPoint.X) / 2);
            double ra_Y = Math.Abs((firstPoint.Y - secondPoint.Y) / 2);

            double Pi = Math.PI * 2;

            base.Draw(glControl);

            var glCtrl = glControl.OpenGL;
            glCtrl.Begin(OpenGL.GL_LINE_LOOP);

            for (int i = 0; i < 10000; i++)
            {
                //the coordinates of the point
                double x_pos = _center.X + Math.Cos(i * Pi / 10000) * ra_X;
                double y_pos = _center.Y - Math.Sin(i * Pi / 10000) * ra_Y;
                //use Neighborhood-4
                glCtrl.Vertex(x_pos, glControl.Height - y_pos);
                glCtrl.Vertex(x_pos - 1, glControl.Height - y_pos);
                //glCtrl.Vertex(x_pos - 1, glControl.Height - (y_pos - 1));
                glCtrl.Vertex(x_pos, glControl.Height - (y_pos - 1));
                //glCtrl.Vertex(x_pos + 1, glControl.Height - (y_pos - 1));
                glCtrl.Vertex(x_pos + 1, glControl.Height - y_pos);
                //glCtrl.Vertex(x_pos + 1, glControl.Height - (y_pos + 1));
                glCtrl.Vertex(x_pos, glControl.Height - (y_pos + 1));
                //glCtrl.Vertex(x_pos - 1, glControl.Height - (y_pos + 1));
            }

            glCtrl.End();
            glCtrl.Flush();
        }
    }
}
