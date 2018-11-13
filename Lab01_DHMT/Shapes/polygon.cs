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

        public void drawPolygon(OpenGLControl glControl, Color _clr, float size)
        {
            base.Draw(glControl);
            glControl.OpenGL.Begin(OpenGL.GL_LINE_LOOP);
            glControl.OpenGL.LineWidth(size);
            glControl.OpenGL.Color(_clr.R / 255.0, _clr.G / 255.0, _clr.B / 255.0);

            plg.ForEach(plgon => glControl.OpenGL.Vertex(plgon.X, glControl.Height- plgon.Y));    
            glControl.OpenGL.End();
            glControl.OpenGL.Flush();
        }
    }
}
