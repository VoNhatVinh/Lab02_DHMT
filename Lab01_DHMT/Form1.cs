using Lab01_DHMT.Shapes;
using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_DHMT
{
    public partial class Form1 : Form
    {
        static Point start = new Point(-1, -1), end, mouse_move_down = new Point(-1, -1), mouse_move_up;
        static Color color = Color.Black;
        static float size = 1.0f;                           /*thickness of shape*/
        static int chooseIcon;                              /*choose Shape icon*/
        static polygon plg = new polygon();                      /*poligon*/
        static List<polygon> list_plg = new List<polygon>();  /*list poligon*/
        static bool mouseDown = false;
        static bool mouseLeft = false;
        int mode = 1;
        /*mode=1: draw shape; mode=2 draw polygon; mode=3: translate*/


        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Get the OpenGL object.             
            OpenGL gl = openGLControl.OpenGL;

            //  Clear the color and depth buffer.      
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Set the clear color.            
            gl.ClearColor(255, 255, 255, 0);

            //  Set the projection matrix.            
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.            
            gl.LoadIdentity();
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  Get the OpenGL object.             
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.            
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            //  Load the identity.             
            gl.LoadIdentity();

            //  Create a perspective transformation.            
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.Ortho2D(0, openGLControl.Width, 0, openGLControl.Height);
        }

        /*Draw shape*/
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.Color(color.R / 255.0, color.G / 255.0, color.B / 255.0);

            //Adjust thickness of shapes
            if (!float.TryParse(tbSize.Text, out size))
            {
                size = 1.0f;
            }

            if (mode == 1)//draw shape
            {
                var Item = Draw.Draw.chooseShape(openGLControl, chooseIcon, start, end, size, color);
            }

            //draw polygon
            else if (mode == 2)
            {
                if (mouseLeft == true)
                    plg.drawPolygon_1(openGLControl, color, size);
            }

            //select shape
            else if (mode == 3)
            {
                if (end.X != -1 && end.Y != -1)
                {
                    Draw.Draw.DrawControlPoints(openGLControl, Draw.Draw.stackShape, list_plg, end);
                    // Draw.Draw.translateShape(openGLControl, Draw.Draw.stackShape, list_plg, end);
                }
            }

            list_plg.ForEach(plgon => plgon.drawPolygon(openGLControl));

            //draw shape           
            Draw.Draw.DrawShape(openGLControl);

            //print to textbox Time
            tbTime.Text = clock.Seconds.ToString() + " s " + clock.Milliseconds.ToString() + " ms";
        }


        /*mouse event manipulation and caculate time differ*/
        public DateTime startTime;          /*start time*/
        static TimeSpan clock;              /*time differencce*/
        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode == 1 || mode == 2)
            {
                start = e.Location;
                end = start;
                mouseDown = true;
                startTime = DateTime.Now;
            }

            if (mode == 3)
            {
                mouse_move_down = e.Location;
                mouseDown = true;
            }
        }
        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                end = e.Location;
            }

        }
        private void openGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            //press left mouse anh draw shape
            if (mode == 1 && e.Button == MouseButtons.Left)
            {
                mouseDown = false;
                end = e.Location;
                clock = DateTime.Now.Subtract(startTime);
            }

            /*draw polygon*/
            if (mode == 2)
            {
                //end of drawing polygon
                if (e.Button == MouseButtons.Right)
                {
                    //add to list
                    list_plg.Add(plg);
                    plg = new polygon();

                    mouseLeft = false;
                    clock += DateTime.Now.Subtract(startTime);
                }
                else
                if (e.Button == MouseButtons.Left)//continue drawing
                {
                    plg.addPoint(e.Location);//call function addPoint(Point point) to add new point to list

                    mouseLeft = true;
                    clock += DateTime.Now.Subtract(startTime);
                }
                mouseDown = false;
            }

            /*select shape*/
            if (mode == 3 && e.Button == MouseButtons.Left)
            {
                if (mouseDown == true && mouse_move_down.X != -1)
                {
                    end = e.Location;
                    Draw.Draw.translateShape(openGLControl, end);
                }
                mouseDown = false;
            }

            if (chooseIcon < 1 && mode != 2)
                clock = TimeSpan.Zero;
        }


        /*Choose color by click event*/
        private void pictureColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }


        /*choose shape by click event*/
        private void line_Click(object sender, EventArgs e)
        {
            mode = 1;
            chooseIcon = 1;
            start.X = -1;
            start.Y = -1;
        }
        private void circle_Click(object sender, EventArgs e)
        {
            mode = 1;
            chooseIcon = 2;
            start.X = -1;
            start.Y = -1;
        }
        private void ellipse_Click(object sender, EventArgs e)
        {
            mode = 1;
            chooseIcon = 3;
            start.X = -1;
            start.Y = -1;
        }
        private void rectangle_icon_Click(object sender, EventArgs e)
        {
            mode = 1;
            chooseIcon = 4;
            start.X = -1;
            start.Y = -1;
        }
        private void triangle_icon_Click(object sender, EventArgs e)
        {
            mode = 1;
            chooseIcon = 5;
            start.X = -1;
            start.Y = -1;
        }
        private void pentagol_icon_Click(object sender, EventArgs e)
        {
            chooseIcon = 6;
            mode = 1;
            start.X = -1;
            start.Y = -1;
        }
        private void polygon_icon_Click(object sender, EventArgs e)
        {
            mode = 2;
        }
        private void hexagol_icon_Click(object sender, EventArgs e)
        {
            chooseIcon = 7;
            mode = 1;
            start.X = -1;
            start.Y = -1;
        }

        /*select shape by click event*/
        private void selectShapeLb_Click(object sender, EventArgs e)
        {
            mode = 3;
            start.X = -1;
            start.Y = -1;
        }
    }
}