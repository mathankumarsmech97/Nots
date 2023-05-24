using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class MultiThreadPriorityDemo
    {
        static long count1 = 0, count2 = 0;

        public static void Main()
        {


            void IncrementCount1()
            {
                while (true)
                {
                    count1 += 1;
                }
            }
            void IncrementCount2()
            {
                while (true)
                {
                    count2 += 1;
                }
            }

            Thread tr1 = new Thread(IncrementCount1);
            Thread tr2 = new Thread(IncrementCount2);

            tr1.Start();
            tr2.Start();

            Console.WriteLine("Man thread going to sleep");

            Thread.Sleep(10000);
            Console.WriteLine("Man thread id Wakeup");

            tr1.Abort();
            tr2.Abort();

            tr1.Join();
            tr2.Join();

            Console.WriteLine("Counter1 :" + count1);
            Console.WriteLine("Counter2 :" + count2);

            Console.ReadLine();

        }



    }
}
