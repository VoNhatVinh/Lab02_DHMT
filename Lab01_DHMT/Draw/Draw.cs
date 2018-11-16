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
        // public bool inside = false;
        public static Shape selectedShape = null;
        public static polygon selectedPolygon = null;
        public static void DrawControlPoints(OpenGLControl openGLControl, Stack<Shape> stackShape, List<polygon> list_plg, Point mouse_position)
        {
            int eps = 10;//epsilon
            //bool inside = false;
            var glCtrl = openGLControl.OpenGL;
            bool inside = false;
            /*traverse shape*/
            foreach (var pos in stackShape)
            {
                int fi_x = pos.firstPoint.X;
                int fi_y = pos.firstPoint.Y;
                int se_x = pos.secondPoint.X;
                int se_y = pos.secondPoint.Y;

                if (fi_x < se_x && fi_y < se_y)//firstPoint: topleft, secondPoint: botright
                {
                    if ((fi_x - eps <= mouse_position.X && mouse_position.X <= se_x + eps)
                        && (fi_y - eps <= mouse_position.Y && mouse_position.Y < se_y + eps))
                    {
                        inside = true;
                    }
                }

                if (fi_x < se_x && fi_y > se_y)//firstPoint: botleft, secondPoint: topright
                {
                    if ((fi_x - eps <= mouse_position.X && mouse_position.X <= se_x + eps)
                        && (fi_y + eps <= mouse_position.Y && mouse_position.Y < se_y - eps))
                    {
                        inside = true;
                    }
                }

                if (fi_x > se_x && fi_y < se_y)//firstPoint: topright, secondPoint: botleft
                {
                    if ((se_x - eps <= mouse_position.X && mouse_position.X <= fi_x + eps)
                        && (fi_y - eps <= mouse_position.Y && mouse_position.Y < se_y + eps))
                    {
                        inside = true;
                    }
                }

                if (fi_x > se_x && fi_y > se_y)//firstPoint: botright, secondPoint: topleft
                {
                    if ((se_x - eps <= mouse_position.X && mouse_position.X <= fi_x + eps)
                        && (fi_y + eps <= mouse_position.Y && mouse_position.Y < se_y - eps))
                    {
                        inside = true;
                    }
                }

                if (inside == true)
                {
                    if (selectedShape == null)
                        selectedShape = new Shape();
                    selectedShape = pos;
                    pos.drawControlPoints(openGLControl);

                    glCtrl.Flush();
                    break;
                }
            }

            //xet cac polygon
            if (inside == false && list_plg != null)
            {
                foreach (var pol in list_plg)
                {
                    pol.SetData_ControlPoint(openGLControl);

                    int fi_x = pol.firstPoint.X;
                    int fi_y = pol.firstPoint.Y;
                    int se_x = pol.secondPoint.X;
                    int se_y = pol.secondPoint.Y;

                    //We calculate position of click-mouse and edges of shape if this distance <=epsilon the inside=true 
                    if (fi_x < se_x && fi_y < se_y)//firstPoint: topleft, secondPoint: botright
                    {
                        if ((fi_x - eps <= mouse_position.X && mouse_position.X <= se_x + eps)
                            && (fi_y - eps <= mouse_position.Y && mouse_position.Y < se_y + eps))
                        {
                            inside = true;
                        }
                    }

                    if (fi_x < se_x && fi_y > se_y)//firstPoint: botleft, secondPoint: topright
                    {
                        if ((fi_x - eps <= mouse_position.X && mouse_position.X <= se_x + eps)
                            && (fi_y + eps <= mouse_position.Y && mouse_position.Y < se_y - eps))
                        {
                            inside = true;
                        }
                    }

                    if (fi_x > se_x && fi_y < se_y)//firstPoint: topright, secondPoint: botleft
                    {
                        if ((se_x - eps <= mouse_position.X && mouse_position.X <= fi_x + eps)
                            && (fi_y - eps <= mouse_position.Y && mouse_position.Y < se_y + eps))
                        {
                            inside = true;
                        }
                    }

                    if (fi_x > se_x && fi_y > se_y)//firstPoint: botright, secondPoint: topleft
                    {
                        if ((se_x - eps <= mouse_position.X && mouse_position.X <= fi_x + eps)
                            && (fi_y + eps <= mouse_position.Y && mouse_position.Y < se_y - eps))
                        {
                            inside = true;
                        }
                    }

                    if (inside == true)
                    {
                        if (selectedPolygon == null)
                            selectedPolygon = new polygon();
                        selectedPolygon = pol;
                        pol.drawControlPoints(openGLControl);
                        glCtrl.Flush();
                        break;
                    }
                }
            }

            //push to buffer
            glCtrl.Flush();
        }

        public static bool inside_shape = false;
        public static bool inside_polygon = false;
        public static bool CheckInside(OpenGLControl openGLControl, Stack<Shape> stackShape, List<polygon> list_plg, Point mouse_position)
        {

            bool check = false;
            foreach (var pos in stackShape)
            {
                int fi_x = pos.firstPoint.X;
                int fi_y = pos.firstPoint.Y;
                int se_x = pos.secondPoint.X;
                int se_y = pos.secondPoint.Y;

                if (fi_x < se_x && fi_y < se_y)//firstPoint: topleft, secondPoint: botright
                {
                    if ((fi_x <= mouse_position.X && mouse_position.X <= se_x)
                        && (fi_y <= mouse_position.Y && mouse_position.Y < se_y))
                    {
                        inside_shape = true;
                    }
                }

                if (fi_x < se_x && fi_y > se_y)//firstPoint: botleft, secondPoint: topright
                {
                    if ((fi_x <= mouse_position.X && mouse_position.X <= se_x)
                        && (fi_y <= mouse_position.Y && mouse_position.Y < se_y))
                    {
                        inside_shape = true;
                    }
                }

                if (fi_x > se_x && fi_y < se_y)//firstPoint: topright, secondPoint: botleft
                {
                    if ((se_x <= mouse_position.X && mouse_position.X <= fi_x)
                        && (fi_y <= mouse_position.Y && mouse_position.Y < se_y))
                    {
                        inside_shape = true;
                    }
                }

                if (fi_x > se_x && fi_y > se_y)//firstPoint: botright, secondPoint: topleft
                {
                    if ((se_x <= mouse_position.X && mouse_position.X <= fi_x)
                        && (fi_y <= mouse_position.Y && mouse_position.Y < se_y))
                    {
                        inside_shape = true;
                    }
                }
            }

            //xet cac polygon
            if (inside_shape == false && list_plg != null)
            {
                foreach (var pol in list_plg)
                {
                    pol.SetData_ControlPoint(openGLControl);

                    int fi_x = pol.firstPoint.X;
                    int fi_y = pol.firstPoint.Y;
                    int se_x = pol.secondPoint.X;
                    int se_y = pol.secondPoint.Y;

                    //We calculate position of click-mouse and edges of shape if this distance <=epsilon the inside=true 
                    if (fi_x < se_x && fi_y < se_y)//firstPoint: topleft, secondPoint: botright
                    {
                        if ((fi_x <= mouse_position.X && mouse_position.X <= se_x)
                            && (fi_y <= mouse_position.Y && mouse_position.Y < se_y))
                        {
                            inside_polygon = true;
                        }
                    }

                    if (fi_x < se_x && fi_y > se_y)//firstPoint: botleft, secondPoint: topright
                    {
                        if ((fi_x <= mouse_position.X && mouse_position.X <= se_x)
                            && (fi_y <= mouse_position.Y && mouse_position.Y < se_y))
                        {
                            inside_polygon = true;
                        }
                    }

                    if (fi_x > se_x && fi_y < se_y)//firstPoint: topright, secondPoint: botleft
                    {
                        if ((se_x <= mouse_position.X && mouse_position.X <= fi_x)
                            && (fi_y <= mouse_position.Y && mouse_position.Y < se_y))
                        {
                            inside_polygon = true;
                        }
                    }

                    if (fi_x > se_x && fi_y > se_y)//firstPoint: botright, secondPoint: topleft
                    {
                        if ((se_x <= mouse_position.X && mouse_position.X <= fi_x)
                            && (fi_y <= mouse_position.Y && mouse_position.Y < se_y))
                        {
                            inside_polygon = true;
                        }
                    }
                }
            }

            if (inside_shape == true || inside_polygon == true)
            {
                check = true;
            }

            return check;
        }

        public static void Translate(OpenGLControl openGLControl, Point start, Point end)
        {
            if (inside_shape == true)
            {
                if (selectedShape != null)
                {
                    selectedShape.firstPoint.X += end.X - start.X;
                    selectedShape.firstPoint.Y += end.Y - start.Y;
                    selectedShape.secondPoint.X += end.X - start.X;
                    selectedShape.secondPoint.Y += end.Y - start.Y;
                    selectedShape.Draw(openGLControl);
                    selectedShape.drawControlPoints(openGLControl);
                }
            }

            if (inside_polygon == true)
            {
                if (selectedPolygon != null)
                {
                    selectedPolygon.firstPoint.X += end.X - start.X;
                    selectedPolygon.firstPoint.Y += end.Y - start.Y;
                    selectedPolygon.secondPoint.X += end.X - start.X;
                    selectedPolygon.secondPoint.Y += end.Y - start.Y;
                    selectedPolygon.ChangePosition(openGLControl, start, end);
                    //selectedPolygon.SetData_ControlPoint(openGLControl);
                    selectedPolygon.drawPolygon(openGLControl);
                    selectedPolygon.drawControlPoints(openGLControl);
                }
            }
        }

        public static void Set(OpenGLControl openGLControl)
        {
            inside_shape = false;
            inside_polygon = false;

            if (selectedShape != null)
                selectedShape = new Shape();

            if (selectedPolygon != null)
                selectedPolygon = new polygon();
        }

        public static void ScaleShape(OpenGLControl openGLControl, int control_position, Point end)
        {
            if (selectedShape != null)
            {
                switch (control_position)
                {
                    case 0:
                        selectedShape.firstPoint.X = end.X;
                        selectedShape.firstPoint.Y = end.Y;
                        break;
                    case 1:
                        selectedShape.secondPoint.X = end.X;
                        selectedShape.firstPoint.Y = end.Y;
                        break;
                    case 2:
                        selectedShape.firstPoint.X = end.X;
                        selectedShape.secondPoint.Y = end.Y;
                        break;
                    case 3:
                        selectedShape.secondPoint.X = end.X;
                        selectedShape.secondPoint.Y = end.Y;
                        break;
                    case 4:
                        selectedShape.firstPoint.Y = end.Y;
                        break;
                    case 5:
                        selectedShape.secondPoint.Y = end.Y;
                        break;
                    case 6:
                        selectedShape.firstPoint.X = end.X;
                        break;
                    case 7:
                        selectedShape.secondPoint.X = end.X;
                        break;
                }
            }
        }
    }
}