using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes
{
    public class Assignment_Set_7
    {
        public static void stringConversion()
        {
            string str = "200";

            int n = Convert.ToInt32(str);
            Console.WriteLine(n);
        }
        public static void stringToChar()
        {
            string str = "ABCDEF";
           

            char[] ch = str.ToCharArray();

           
            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }
        }

        public static void charToString()
        {
            char ch = 'a';
            string str=ch.ToString();
            Console.WriteLine(str);

        }
    }
}
