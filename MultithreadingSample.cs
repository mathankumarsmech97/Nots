using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class MultithreadingSample
    {
      static public void multithreading()
        {
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine("Test 1 :" + i);
            }
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine("Test 2 :" + i);
                if (i == 0)
                {
                    Console.WriteLine(" Take break 5 Sec");
                    Thread.Sleep(5000);
                    Console.WriteLine("Again pro gramming Start");
                }
            }
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test 3 :" + i);
            }

        }
    }
}
