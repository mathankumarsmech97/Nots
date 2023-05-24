using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Multithreading
{
    internal class MultithreadRealtimeExample
    {
        

        public static void Incrementalcounter1()
        {
            long count = 0;
            for(int i = 0; i < 100000000; i++)
            
                count++;
           Console.WriteLine("Incrementalcounter1 :" + count);
        }
        public static void Incrementalcounter2()
        {
            long count = 0;
            for (int i = 0; i < 100000000; i++)
            
                count++;
           Console.WriteLine("Incrementalcounter2 :" + count);
        }

        public static void Main()
        {
           
            Thread t1 = new Thread(Incrementalcounter1);
            Thread t2 = new Thread(Incrementalcounter2);

            Stopwatch sw = new Stopwatch();
            Stopwatch sw1 = new Stopwatch();


            sw.Start();
            Incrementalcounter1();
            Incrementalcounter2();
            sw.Stop();



            sw1.Start();
            t1.Start();
            t2.Start();
            sw1.Stop();

            t1.Join();
            t2.Join();

            Console.WriteLine("With out thread time" + sw.ElapsedMilliseconds);
           Console.WriteLine(" thread implimented time" + sw1.ElapsedMilliseconds);

            Console.ReadLine();

        }

    }
}
