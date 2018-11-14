﻿using SharpGL;
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

        /*Draw with left mouse*/
        public void drawPolygon_1(OpenGLControl glControl, Color _clr, float size)      
        {
            _color = _clr;
            _size = size;
            base.Draw(glControl);
            glControl.OpenGL.LineWidth(size);

            glControl.OpenGL.Begin(OpenGL.GL_LINE_LOOP);
            glControl.OpenGL.Color(_clr.R / 255.0, _clr.G / 255.0, _clr.B / 255.0);
            plg.ForEach(plgon => glControl.OpenGL.Vertex(plgon.X, glControl.Height- plgon.Y));
            glControl.OpenGL.End();

            glControl.OpenGL.Flush();
        }

        /*Draw when click right mouse*/
        public void drawPolygon(OpenGLControl glControl)
        {
            base.Draw(glControl);
            glControl.OpenGL.LineWidth(_size);

            glControl.OpenGL.Begin(OpenGL.GL_LINE_LOOP);
            glControl.OpenGL.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
            plg.ForEach(plgon => glControl.OpenGL.Vertex(plgon.X, glControl.Height - plgon.Y));
            glControl.OpenGL.End();

            glControl.OpenGL.Flush();
        }
    }
}
