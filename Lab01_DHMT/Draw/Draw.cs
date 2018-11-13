using Lab01_DHMT.Shapes;
using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Lab01_DHMT.Shapes.Rectangle;

namespace Lab01_DHMT.Draw
{
    /*
     This class 
     */
    public class Draw
    {
        /*stack Shape contains a list shapes we draw on winform*/
        public static Stack<Shape> stackShape = new Stack<Shape>();
        public static Shape chooseShape(OpenGLControl openGLControl, int _chooseIcon, Point start, Point end, float size, Color color)
        {
            Shape _chooseShape = null;

            /*Choose a shape */
            if (start.X != -1 && start.Y != -1)
            {
                switch (_chooseIcon)
                {
                    case 1://Line
                        _chooseShape = new Line(start, end, size, color);
                        break;
                    case 2://Circle
                        _chooseShape = new Circle(start, end, size, color);
                        break;
                    case 3://Ellipse
                        _chooseShape = new Ellipse(start, end, size, color);
                        break;
                    case 4://Rectangle
                        _chooseShape = new Rectangle(start, end, size, color);
                        break;
                    case 5://Triangle
                        _chooseShape = new Triangle(start, end, size, color);
                        break;
                    case 6://Pentagon
                        _chooseShape = new Pentagon(start, end, size, color);
                        break;
                    case 7://Hexagon
                        _chooseShape = new hexagon(start, end, size, color);
                        break;
                    default:
                        break;
                }
            }

            /*
             Save the shapes to stackShape
             */          
            if (_chooseShape != null)
            {
                if (stackShape.Count > 0)
                {
                    var temp = stackShape.Pop();
                    /*only save shapes have different first point */
                    if (temp.firstPoint != _chooseShape.firstPoint)
                    {
                        stackShape.Push(temp);
                    }
                }

                stackShape.Push(_chooseShape);
            }

            return _chooseShape;
        }


        /*
        draw shapes from stack 
        */
        public static void DrawShape(OpenGLControl openGLControl)
        {
            var glCtrl = openGLControl.OpenGL;
            foreach (var x in stackShape)
            {
                x.Draw(openGLControl);
                glCtrl.Flush();
            }

            glCtrl.Flush();
        }
    }
}