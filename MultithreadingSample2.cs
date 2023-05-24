using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class MultithreadingSample2
    {
       
        
        public static void mutlithreadingDemo1(){

        
        
            void Test1()
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Test Method 1: " + i);
                }
                Console.WriteLine("Test 1 is Exiting");
            }
            void Test2()
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Test Method 2: " + i);
                    if (i == 25)
                    {
                        Console.WriteLine("Thread 2 is Sleep");
                        Thread.Sleep(5000);
                        Console.WriteLine("Thread 2 Start");

                    }
                   
                }
                Console.WriteLine("Test 2 is Exiting");
            }
            void Test3()
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Test Method 3: " + i);
                }
                Console.WriteLine("Test 3 is Exiting");
            }
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();t2.Start();t3.Start();
            Console.WriteLine("Test Main is Exiting");



            Console.ReadLine();

         }

        
    }
}




        

    

