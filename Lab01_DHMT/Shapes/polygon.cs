using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_DHMT.Shapes
{
    public class polygon:Shape
    {
        public List<Point> plg=null;
        public Color _clr = Color.Black;

        public polygon()
        {
            if (plg == null)
            {
                plg = new List<Point>();
            }
        }

        public void addPoint(Point point)
        {
            plg.Add(point);
        }

        public void drawPolygon(OpenGLControl glControl)
        {
            glControl.OpenGL.Begin(OpenGL.GL_LINE_LOOP);
            glControl.OpenGL.Color(_clr.R / 255.0, _clr.G / 255.0, _clr.B / 255.0);

            list_control_points.ForEach(plgon => glControl.OpenGL.Vertex(plgon.X, plgon.Y));    
            glControl.OpenGL.End();
            glControl.OpenGL.Flush();
        }
    }
}
