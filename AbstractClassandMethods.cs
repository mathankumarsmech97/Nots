using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethods
{
   public abstract class AbstractClassandMethods
    {
        public virtual void add(int x,int y)
        {
            Console.WriteLine("addion :" + x + y);
        }
        public virtual void sub(int a,int b)
        {
            Console.WriteLine("sub :" + (a - b));
        }

        public abstract void mul(int a, int b);
       public  abstract void div(int a, int b);
    }
}
