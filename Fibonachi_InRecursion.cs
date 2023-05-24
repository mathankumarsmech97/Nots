using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes
{
    public class Fibonachi_InRecursion
    {
       public static void FiboInRecursion(int n)
        {
            int a=0, b=1, c=0;
           
            if (n >0)
            {
                c = a + b;
                a = b;
                b=c;
                Console.Write(" "+c );
                n--;
                FiboInRecursion(n);
                


            }
           


        }


    }

    
}
