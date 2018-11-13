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
        static Point start = new Point(-1, -1), end;
        static Color color = Color.Black;
        static float size = 1.0f;                           /*thickness of shape*/
        static int chooseIcon;                              /*choose Shape icon*/
        static bool mouseDown = false;

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
            
            //draw shape
            var Item = Draw.Draw.chooseShape(openGLControl, chooseIcon, start, end, size, color);
            gl.Color(color.R / 255.0, color.G / 255.0, color.B / 255.0);
            Draw.Draw.DrawShape(openGLControl);

            //Adjust thickness of shapes
            if (!float.TryParse(tbSize.Text, out size))
            {
                size = 1.0f;
            }

            //print to textbox Time
            tbTime.Text = clock.Milliseconds.ToString() + " ms";
            
        }


        /*mouse event manipulation and caculate time differ*/
        public DateTime startTime;          /*start time*/
        static TimeSpan clock;              /*time differencce*/
        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            end = start;
            mouseDown = true;
            
            startTime = DateTime.Now;

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
            mouseDown = false;
            end = e.Location;
            clock = DateTime.Now.Subtract(startTime);

            if (chooseIcon < 1)
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


        /*choose shape by Click event*/    
        private void line_Click(object sender, EventArgs e)
        {
            chooseIcon = 1;
            start.X = -1;
            start.Y = -1;
        }
        private void circle_Click(object sender, EventArgs e)
        {
            chooseIcon = 2;
            start.X = -1;
            start.Y = -1;
        }
        private void ellipse_Click(object sender, EventArgs e)
        {
            chooseIcon = 3;
            start.X = -1;
            start.Y = -1;
        }
        private void rectangle_icon_Click(object sender, EventArgs e)
        {
            chooseIcon = 4;
            start.X = -1;
            start.Y = -1;
        }
        private void triangle_icon_Click(object sender, EventArgs e)
        {
            chooseIcon = 5;
            start.X = -1;
            start.Y = -1;
        }
        private void pentagol_icon_Click(object sender, EventArgs e)
        {
            chooseIcon = 6;
            start.X = -1;
            start.Y = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hexagol_icon_Click(object sender, EventArgs e)
        {
            chooseIcon = 7;
            start.X = -1;
            start.Y = -1;
        }       
    }
}