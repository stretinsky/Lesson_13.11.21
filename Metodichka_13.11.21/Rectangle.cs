using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka_13._11._21
{
    class Rectangle : Point
    {
        private double x1, y1, x2, y2, x3, y3;
        public Rectangle(Color color, Status status, double x1, double y1, double x2, double y2, double x3, double y3) : base()
        {
            this.color = color;
            this.status = status;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
        public double GetSquare()
        {
            double edge1 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
            double edge2 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x3), 2) + Math.Pow(Math.Abs(y1 - y3), 2));
            double edge3 = Math.Sqrt(Math.Pow(Math.Abs(x2 - x3), 2) + Math.Pow(Math.Abs(y2 - y3), 2));
            double halfP = (edge1 + edge2 + edge3) * 0.5;
            return Math.Sqrt(halfP * (halfP - edge1) * (halfP - edge2) * (halfP - edge3));
        }
        public override void MovingX(double value)
        {
            x1 += value;
            x2 += value;
            x3 += value;
        }
        public override void MovingY(double value)
        {
            y1 += value;
            y2 += value;
            y3 += value;
        }
        public override void ShowInfo()
        {
            if (IsVisible())
            {
                Console.WriteLine($"Видимый треугольник с вершинами в точках ({x1}, {y1}), ({x2}, {y2}) и ({x3}, {y3}). Площадь = {GetSquare()}. Цвет {color}");
            }
            else
            {
                Console.WriteLine($"Невидимый треугольник с вершинами в точках ({x1}, {y1}), ({x2}, {y2}) и ({x3}, {y3}). Площадь = {GetSquare()}. Цвет {color}");
            }
        }
    }
}
