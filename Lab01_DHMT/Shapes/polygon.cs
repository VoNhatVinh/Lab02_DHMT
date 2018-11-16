using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_DHMT.Shapes
{
    public class polygon : Shape
    {
        public List<Point> plg = null;//list that save the points to draw polygon

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
            plg.ForEach(plgon => glControl.OpenGL.Vertex(plgon.X, glControl.Height - plgon.Y));
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

        public void SetData_ControlPoint(OpenGLControl gLControl)//set firstPoint and secondPoint
        {
            int sum_pos_x = 0;
            int sum_pos_y = 0;
            int count = plg.Count;

            int topleft_x = plg[0].X;
            int topleft_y = plg[0].Y;
            int botright_x = plg[plg.Count - 1].X;
            int botright_y = plg[plg.Count - 1].Y;

            foreach (var x in plg)
            {
                if (x.X <= topleft_x)
                    topleft_x = x.X;
                if (x.X >= botright_x)
                    botright_x = x.X;
                if (x.Y <= topleft_y)
                    topleft_y = x.Y;
                if (x.Y >= botright_y)
                    botright_y = x.Y;

                sum_pos_x += x.X;
                sum_pos_y += x.Y;
            }
            firstPoint = new Point(topleft_x, topleft_y);
            secondPoint = new Point(botright_x, botright_y);

            _center = new Point((int)(sum_pos_x / count), (int)(sum_pos_y / count));
        }

        //for the translate
        public void ChangePosition(OpenGLControl glControl, Point start, Point end)
        {
            int delta_x = end.X - start.X;
            int delta_y = end.Y - start.Y;

            for (int i = 0; i < plg.Count; i++)
            {
                int temp1 = plg[i].X + delta_x;
                int temp2 = plg[i].Y + delta_y;
                plg[i] = new Point(temp1, temp2);
            }
            SetData_ControlPoint(glControl);
        }
    }
}
