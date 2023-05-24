using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethods
{
    internal class ChildAbstract : AbstractClassandMethods
    {
        public override void mul(int a, int b)
        {
            Console.WriteLine("mltiplecation : "+a * b);
        }
        public override void div(int a, int b)
        {
            Console.WriteLine("divisible by :"+(a / b));
        }

        public static void Main()
        {
            ChildAbstract c = new ChildAbstract();
            c.add(5,5);
            c.mul(5,5);
            c.div(10, 5);
            c.sub(20,10);


            Console.ReadLine();
        }

    }
}
