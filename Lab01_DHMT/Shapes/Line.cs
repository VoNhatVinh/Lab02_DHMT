using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_DHMT.Shapes
{
    /*
     class Line has two methods: constructor and Draw
     */
    public class Line : Shape
    {
        /*
         Line's constructor
         */
        public Line(Point first, Point second, float size, Color color)
        {
            firstPoint = first;
            secondPoint = second;
            _size = size;
            _color = color;
        }

        /*
         * Draw line: define two points and use GL_LINE mode to connect them
         */
        public override void Draw(OpenGLControl glControl)
        {
            base.Draw(glControl);

            var glCtrl = glControl.OpenGL;

            glCtrl.Begin(OpenGL.GL_LINES);
            glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y);
            glCtrl.Vertex(secondPoint.X, glControl.Height - secondPoint.Y);
            glCtrl.End();

            glCtrl.Flush();
        }
    }
}