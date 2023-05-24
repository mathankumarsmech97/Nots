using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes
{
    internal class FibonachiSerice0
    {
        public static void fibonachi(int n)
        {
            int a=0,b=1,c=0,i=0;
            Console.WriteLine(a + "\n" + b);

            while (n >= i)
            {
                
                c = a+b;
                Console.WriteLine(c);
                a = b; 
                b=c;
                i++;


            }

            Console.ReadLine();

        }

    }
}
