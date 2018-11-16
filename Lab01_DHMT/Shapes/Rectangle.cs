using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Lab01_DHMT.Shapes
{
    public class Rectangle:Shape
    {
        public Rectangle(Point topLeft, Point botRight, float size, Color color)
        {
            firstPoint = topLeft;
            secondPoint = botRight;
            _size = size;
            _color = color;
            
        }

        public override void Draw(OpenGLControl glControl)
        {
            //center
            _center.X = (int)((firstPoint.X + secondPoint.X) / 2);
            _center.Y = (int)((firstPoint.Y + secondPoint.Y) / 2);

            base.Draw(glControl);

            var glCtrl = glControl.OpenGL;
            glCtrl.Begin(OpenGL.GL_LINE_LOOP);

            if (firstPoint.X < secondPoint.X && firstPoint.Y < secondPoint.Y)/*firstPoint: top left, secondPoint: bot right*/
            {
                glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y);//main point of the shape: top left: firstPoint
                glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y + _size / 2.125);
                glCtrl.Vertex(firstPoint.X, glControl.Height - (secondPoint.Y + _size / 2.025));
                glCtrl.Vertex(firstPoint.X, glControl.Height - secondPoint.Y);//main point of the shape: bot left
                glCtrl.Vertex(secondPoint.X + _size / 2.125, glControl.Height - secondPoint.Y);
                glCtrl.Vertex(secondPoint.X, glControl.Height - secondPoint.Y);//main point of the shape: bot right: secondPoint
                glCtrl.Vertex(secondPoint.X, glControl.Height - firstPoint.Y + _size / 2.025);
                glCtrl.Vertex(secondPoint.X, glControl.Height - firstPoint.Y);//main point of the shape: top right
                glCtrl.Vertex(firstPoint.X - _size / 2.125, glControl.Height - firstPoint.Y);
                //the others are the points that will make the shape look good without changing acreage
            }

            if(firstPoint.X < secondPoint.X && firstPoint.Y > secondPoint.Y)/*firstPoint: bot left, secondPoint: top right*/
            {
                glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y);//main point of the shape: bot left: firstPoint
                glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y - _size / 2.125);
                glCtrl.Vertex(firstPoint.X, glControl.Height - (secondPoint.Y - _size / 2.025));
                glCtrl.Vertex(firstPoint.X, glControl.Height - secondPoint.Y);//main point of the shape: top left
                glCtrl.Vertex(secondPoint.X + _size / 2.125, glControl.Height - secondPoint.Y);
                glCtrl.Vertex(secondPoint.X, glControl.Height - secondPoint.Y);//main point of the shape: top right: secondPoint
                glCtrl.Vertex(secondPoint.X, glControl.Height - firstPoint.Y - _size / 2.025);
                glCtrl.Vertex(secondPoint.X, glControl.Height - firstPoint.Y);//main point of the shape: bot right
                glCtrl.Vertex(firstPoint.X - _size / 2.125, glControl.Height - firstPoint.Y);
                //the others are the points that will make the shape look good without changing acreage
            }

            if (firstPoint.X > secondPoint.X && firstPoint.Y > secondPoint.Y)/*firstPoint: bot right, secondPoint: top left*/
            {
                glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y);//main point of the shape: bot right: firstPoint
                glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y - _size / 2.125);
                glCtrl.Vertex(firstPoint.X, glControl.Height - (secondPoint.Y - _size / 2.025));
                glCtrl.Vertex(firstPoint.X, glControl.Height - secondPoint.Y);//main point of the shape: top right
                glCtrl.Vertex(secondPoint.X - _size / 2.125, glControl.Height - secondPoint.Y);
                glCtrl.Vertex(secondPoint.X, glControl.Height - secondPoint.Y);//main point of the shape: top left: secondPoint
                glCtrl.Vertex(secondPoint.X, glControl.Height - firstPoint.Y - _size / 2.025);
                glCtrl.Vertex(secondPoint.X, glControl.Height - firstPoint.Y);//main point of the shape: bot left
                glCtrl.Vertex(firstPoint.X + _size / 2.125, glControl.Height - firstPoint.Y);
                //the others are the points that will make the shape look good without changing acreage
            }

            if (firstPoint.X > secondPoint.X && firstPoint.Y < secondPoint.Y)/*firstPoint: top right, secondPoint: bot left*/
            {
                glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y);//main point of the shape: top right: firstPoint
                glCtrl.Vertex(firstPoint.X, glControl.Height - firstPoint.Y + _size / 2.125);
                glCtrl.Vertex(firstPoint.X, glControl.Height - (secondPoint.Y + _size / 2.025));
                glCtrl.Vertex(firstPoint.X, glControl.Height - secondPoint.Y);//main point of the shape: bot right
                glCtrl.Vertex(secondPoint.X - _size / 2.125, glControl.Height - secondPoint.Y);
                glCtrl.Vertex(secondPoint.X, glControl.Height - secondPoint.Y);//main point of the shape: bot left: secondPoint
                glCtrl.Vertex(secondPoint.X, glControl.Height - firstPoint.Y + _size / 2.025);
                glCtrl.Vertex(secondPoint.X, glControl.Height - firstPoint.Y);//main point of the shape: top left
                glCtrl.Vertex(firstPoint.X + _size / 2.125, glControl.Height - firstPoint.Y);
                //the others are the points that will make the shape look good without changing acreage
            }

            glCtrl.End();
            glCtrl.Flush();
        }
    }
}
