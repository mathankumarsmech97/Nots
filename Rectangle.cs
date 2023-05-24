using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public  class Rectangle
    {
        public delegate void RectDelegate(double hight, double width);
        public void Area(double hight, double width)
        {
            Console.WriteLine("Area of Rectangle :" + hight + width);
        }
        public void Perimeter(double hight, double width)
        {
            Console.WriteLine("Perimeter of Rectangle :" + (2 * (hight + width)));

        }

        public static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.Area(5, 5);
            rect.Perimeter(5, 5);

            RectDelegate rectDe = rect.Area;

            rectDe += rect.Perimeter;
            rectDe.Invoke(25, 25);

        }
    }
}
