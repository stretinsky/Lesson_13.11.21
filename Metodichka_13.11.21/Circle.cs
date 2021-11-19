using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka_13._11._21
{
    class Circle : Point
    {
        private double radius;
        public Circle(Color color, Status status, double x, double y, double radius) : base(color, status, x, y)
        {
            this.radius = radius;
        }
        public double GetSquare()
        {
            return Math.PI * radius * radius;
        }
        public override void ShowInfo()
        {
            if (IsVisible())
            {
                Console.WriteLine($"Видимая окружность с центром в точке ({x}, {y}) и радиусом {radius}. Площадь = {GetSquare()}. Цвет: {color}");
            }
            else
            {
                Console.WriteLine($"Невидимая окружность с центром в точке ({x}, {y}) и радиусом {radius}. Площадь = {GetSquare()}. Цвет: {color}");
            }
        }
    }
}
