using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    public class MultiThreadingJoinDemo4
    {
        public static void mutlithreadingJoinDemo()
        {



            void Test1()
            {
                Console.WriteLine("Thread 1 is Start");
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Test Method 1: " + i);
                }
                Console.WriteLine("Thread 1 is Exiting");
            }
            void Test2()
            {
                Console.WriteLine("Thread 2 is Start");
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Test Method 2: " + i);
                    //if (i == 25)
                    //{
                    //    Console.WriteLine("Thread 2 is Sleep");
                    //    Thread.Sleep(5000);
                    //    Console.WriteLine("Thread 2 Start");

                    //}

                }
                Console.WriteLine("Thread 2 is Exiting");
            }
            void Test3()
            {
                Console.WriteLine("Thread 3 is Start");
                for (int i = 0; i <= 50; i++)
                
                    Console.WriteLine("Test Method 3: " + i);
                }
                Console.WriteLine("Thread 3 is Exiting");
            }
            Console.WriteLine("Thread Main is Start");

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(3000);t2.Join();t2.Join();

            Console.WriteLine("Thread Main is Exiting");



            Console.ReadLine();

        }




    }
}
