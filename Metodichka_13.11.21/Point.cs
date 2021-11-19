using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka_13._11._21
{
    class Point : Figure
    {
        public Point() : base() { } 
        public Point(Color color, Status status, double x, double y) : base(color, status, x, y)
        {

        }
    }
}
