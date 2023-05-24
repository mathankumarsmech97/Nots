using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadLock
    {
        public void MultirThreadDemo5()
        {
             void Display()
            {
                lock (this)
                {
                    Console.Write("C# is an ");
                    Thread.Sleep(5000);
                    Console.WriteLine("Object Oriented Program");

                }
                           
                                  
            }

            ThreadLock obj = new ThreadLock();

            Thread t1 =new Thread(Display);
            Thread t2 = new Thread(Display);
            Thread t3 = new Thread(Display);

            t1.Start(); t2.Start(); t3.Start();


            Console.WriteLine();


        }

    }

}
