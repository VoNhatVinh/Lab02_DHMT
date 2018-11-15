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

        /*
        draw control points
        */
        public static void DrawControlPoints(OpenGLControl openGLControl,Stack<Shape> stackShape, List<polygon> list_plg, Point end)
        {
            int eps = 10;//epsilon
            bool inside = false;
            var glCtrl = openGLControl.OpenGL;

            foreach (var pos in stackShape)//xét các shape
            {
                inside = false;

                int fi_x = pos.firstPoint.X;
                int fi_y = pos.firstPoint.Y;
                int se_x = pos.secondPoint.X;
                int se_y = pos.secondPoint.Y;

                if(fi_x < se_x && fi_y < se_y)//firstPoint: topleft, secondPoint: botright
                {
                    if ((fi_x - eps <= end.X && end.X <= se_x + eps) && (fi_y - eps <= end.Y && end.Y < se_y + eps))
                        inside = true;
                }
                
                if(fi_x < se_x && fi_y > se_y)//firstPoint: botleft, secondPoint: topright
                {
                    if ((fi_x - eps <= end.X && end.X <= se_x + eps) && (fi_y + eps <= end.Y && end.Y < se_y - eps))
                        inside = true;
                }

                if (fi_x > se_x && fi_y < se_y)//firstPoint: topright, secondPoint: botleft
                {
                    if ((se_x - eps <= end.X && end.X <= fi_x + eps) && (fi_y - eps <= end.Y && end.Y < se_y + eps))
                        inside = true;
                }

                if (fi_x > se_x && fi_y > se_y)//firstPoint: botright, secondPoint: topleft
                {
                    if ((se_x - eps <= end.X && end.X <= fi_x + eps) && (fi_y + eps <= end.Y && end.Y < se_y - eps))
                        inside = true;
                }

                if(inside == true)
                {
                    pos.drawControlPoints(openGLControl);
                    glCtrl.Flush();
                    break;
                }
            }

            //xet cac polygon
            if(inside == false && list_plg != null)
            {
                foreach(var pol in list_plg)
                {
                    inside = false;

                    pol.SetData_ControlPoint(openGLControl);

                    int fi_x = pol.firstPoint.X;
                    int fi_y = pol.firstPoint.Y;
                    int se_x = pol.secondPoint.X;
                    int se_y = pol.secondPoint.Y;

                    if (fi_x < se_x && fi_y < se_y)//firstPoint: topleft, secondPoint: botright
                    {
                        if ((fi_x - eps <= end.X && end.X <= se_x + eps) && (fi_y - eps <= end.Y && end.Y < se_y + eps))
                            inside = true;
                    }

                    if (fi_x < se_x && fi_y > se_y)//firstPoint: botleft, secondPoint: topright
                    {
                        if ((fi_x - eps <= end.X && end.X <= se_x + eps) && (fi_y + eps <= end.Y && end.Y < se_y - eps))
                            inside = true;
                    }

                    if (fi_x > se_x && fi_y < se_y)//firstPoint: topright, secondPoint: botleft
                    {
                        if ((se_x - eps <= end.X && end.X <= fi_x + eps) && (fi_y - eps <= end.Y && end.Y < se_y + eps))
                            inside = true;
                    }

                    if (fi_x > se_x && fi_y > se_y)//firstPoint: botright, secondPoint: topleft
                    {
                        if ((se_x - eps <= end.X && end.X <= fi_x + eps) && (fi_y + eps <= end.Y && end.Y < se_y - eps))
                            inside = true;
                    }

                    if (inside == true)
                    {
                        pol.drawControlPoints(openGLControl);
                        glCtrl.Flush();
                        
                        break;
                    }
                }
            }
            glCtrl.Flush();
        }
    }
}