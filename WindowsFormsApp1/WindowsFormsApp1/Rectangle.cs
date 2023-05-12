using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Rectanglee : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Rectanglee(double x, double y, double width, double height) : base(x,y)
        {
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public override bool IsPointFigure(Point point)
        {
            //расчет попадания координаты внутрь или на границу прямоугольника
            double xMin = x; //минимальные значения координат x
            double xMax = x + Width; //максимальные значения координат x
            double yMin = y; //минимальные значения координат y
            double yMax = y + Height; //максимальные значения координат y

            //Переменные xInBounds и yInBounds используются для проверки, находится ли заданная точка внутри границ прямоугольника.
            //Если xInBounds равен true, то координата x заданной точки находится между xMin и xMax
            bool xInBounds = (point.X >= xMin) && (point.X <= xMax);
            //Если yInBounds равен true, то координата y заданной точки находится между yMin и yMax
            bool yInBounds = (point.Y >= yMin) && (point.Y <= yMax);

            //Если обе переменные равны true, то точка находится внутри прямоугольника.
            return xInBounds && yInBounds;
        }
    }
}
