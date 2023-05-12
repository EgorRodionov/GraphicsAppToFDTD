using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public abstract class Figure
    {
        public double x { get; set; }
        public double y { get; set; }
        public double Epsilon { get; set; }
        public double Sigma { get; set; }

        public Figure(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract bool IsPointFigure(Point point);
    }
}
