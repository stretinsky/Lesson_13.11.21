using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka_13._11._21
{
    enum Color { Red, Green, Blue, Yellow, White, Black }
    enum Status { Visible, Invisible }
    abstract class Figure
    {
        public Color color;
        public Status status;
        public double x, y;
        public Figure() { }
        public Figure(Color color, Status status, double x, double y)
        {
            this.color = color;
            this.status = status;
            this.x = x;
            this.y = y;
        }
        public virtual void MovingX(double value)
        {
            x += value;
        }
        public virtual void MovingY(double value)
        {
            y += value;
        }
        public void ChangeColor(Color color)
        {
            this.color = color;
        }
        public bool IsVisible()
        {
            if (status.Equals(Status.Visible))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Figure is {status}. Color is {color}. Position is ({x}, {y})");
        }
    }
}
