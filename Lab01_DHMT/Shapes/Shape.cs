using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_DHMT.Shapes
{
    /*This is the parent shape*/
    public class Shape
    {
        public Point firstPoint;
        public Point secondPoint;
        public float _size;
        public Color _color;
        public Point _center;
        public int R; // radius
        public List<Point> list_control_points=new List<Point>();

        public virtual void Draw(OpenGLControl glControl)
        {
            var gl = glControl.OpenGL;

            gl.LineWidth(_size);
            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
        }


        public virtual void drawControlPoints(OpenGLControl gLControl)
        {
            /*Create a list control point contains 8 control points: 
             * 4 points in 4 angles and 4 points in mid of lines cover shape   
             *      0---------4----------1
             *      |                    |
             *      6                    7
             *      |                    |
             *      2---------5----------3
             */        
            
                list_control_points = new List<Point>();
            
                list_control_points.Add(new Point(firstPoint.X, gLControl.Height - firstPoint.Y));
                list_control_points.Add(new Point(secondPoint.X, gLControl.Height - firstPoint.Y));
                list_control_points.Add(new Point(firstPoint.X, gLControl.Height - secondPoint.Y));
                list_control_points.Add(new Point(secondPoint.X, gLControl.Height - secondPoint.Y));
                list_control_points.Add(new Point((firstPoint.X + secondPoint.X) / 2, gLControl.Height - firstPoint.Y));
                list_control_points.Add(new Point((firstPoint.X + secondPoint.X) / 2, gLControl.Height - secondPoint.Y));
                list_control_points.Add(new Point(firstPoint.X, gLControl.Height- (firstPoint.Y+secondPoint.Y)/2));
                list_control_points.Add(new Point(secondPoint.X, gLControl.Height-(firstPoint.Y+secondPoint.Y)/2));
       
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
            list_control_points.ForEach(lst => glCtrl.Vertex(lst.X, lst.Y));
            glCtrl.End();

            //glCtrl.Flush();
        }

        /*This function return the index of control point*/
        public int inControlPoint(OpenGLControl openGLControl, Point A)
        {
            int epsilon_square = 100;
            double r_square;

            for (int i=0; i<8; i++)
            {
                r_square = Math.Pow(list_control_points[i].X - A.X, 2) + Math.Pow(list_control_points[i].Y - (openGLControl.Height- A.Y), 2);
                if (r_square <= epsilon_square)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
