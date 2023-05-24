using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    internal class HashtableDemo
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();

            ht.Add("Eid", 1010);
            ht.Add("Ename", "josh");
            ht.Add("Job", "Managr");
            ht.Add("Salary", 100000);
            ht.Add("Phonenumber", 12345678);
            ht.Add("EmailId", "josh@123");
            ht.Add("Location", "Kerala");

            Console.WriteLine(ht["EmailId"]);

            //foreach(object key in ht.Keys)
            //{
            //Console.WriteLine(key);
            //}
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]);
            }

            Console.WriteLine("Hello".GetHashCode());


            //foreach (object value in ht.Values)
            //{
            //    Console.WriteLine(value);
            //}





            Console.ReadLine();

        }




    }
}
