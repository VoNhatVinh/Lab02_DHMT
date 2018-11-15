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
            _center = new Point((int)((first.X + second.X) / 2),(int)((first.Y + second.Y) / 2));
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

        /*
         * Draw Control Points
         */

        public override void drawControlPoints(OpenGLControl gLControl)
        {
            /*Create a list control point contains 8 control points: 
             * 4 points in 4 angles and 4 points in mid of lines cover shape             
            */

            list_control_points = new List<Point>();
            
            list_control_points.Add(new Point(firstPoint.X, gLControl.Height - firstPoint.Y));
            list_control_points.Add(new Point(secondPoint.X, gLControl.Height - secondPoint.Y));
           
            var glCtrl = gLControl.OpenGL;

            //size control point
            glCtrl.PointSize(5f);

            //color
            Color clr = Color.Red;
            glCtrl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0);

            //draw
            glCtrl.Begin(OpenGL.GL_POINTS);

            foreach (var lst in list_control_points)
            {
                glCtrl.Vertex((double)lst.X, lst.Y);
            }
            //list_control_points.ForEach(lst => glCtrl.Vertex(lst.X, lst.Y));
            glCtrl.End();

            glCtrl.Flush();
        }
    }
}