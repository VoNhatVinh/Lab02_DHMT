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
        public List<Point> plg=null;//list that save the points to draw polygon
        
        public polygon()
        {
            if (plg == null)
            {
                plg = new List<Point>();
            }
        }

        public void addPoint(Point point)//add new point
        {
            plg.Add(point);
        }

        public void drawPolygon(OpenGLControl glControl, Color _clr, float size)
        
        {
<<<<<<< HEAD
=======
            base.Draw(glControl);
            glControl.OpenGL.Begin(OpenGL.GL_LINE_LOOP);
>>>>>>> b12305d3415f35e1fa4c59e50f05e799316d71dc
            glControl.OpenGL.LineWidth(size);

<<<<<<< HEAD
            glControl.OpenGL.Begin(OpenGL.GL_LINE_LOOP);
            glControl.OpenGL.Color(_clr.R / 255.0, _clr.G / 255.0, _clr.B / 255.0);
           plg.ForEach(plgon => glControl.OpenGL.Vertex(plgon.X, glControl.Height- plgon.Y));    
=======
            plg.ForEach(plgon => glControl.OpenGL.Vertex(plgon.X, glControl.Height- plgon.Y));    
>>>>>>> b12305d3415f35e1fa4c59e50f05e799316d71dc
            glControl.OpenGL.End();
            glControl.OpenGL.Flush();
        }
    }
}
