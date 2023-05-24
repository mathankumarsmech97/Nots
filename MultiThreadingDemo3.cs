using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    public class MultiThreadingDemo3
    {
        public static void test() {
            //void Test()
            //{
            //    for (int i = 1; i <= 50; i++)
            //    {
            //        Console.WriteLine("Test : " + i);
            //    }
                             
            //}
            static void Test(Object max)
            {
                int num =Convert.ToInt32(max);
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine("Test : " + i);
                }
            }
            //ThreadStart obj = new ThreadStart(Test);
            // ThreadStart obj = Test;
            // ThreadStart obj = delegate () { Test(); };
           // ThreadStart obj = () => Test();

            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);

            Thread t = new Thread(obj);

            t.Start(30);

        }

    }
}
