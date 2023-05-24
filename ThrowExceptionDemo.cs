using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DividedByAddNumberException : ApplicationException
{
    public override string Message
    {
        get
        {
            return "Attemppted by Divided by Add number";
        }
    }
}

namespace AllProjects
{
    internal class ThrowExceptionDemo
    {
        public static void Main()
        {


            Console.WriteLine("Enter the number1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b % 2 > 0)
            {
                // throw new ApplicationException("Diviser value Can't b Add number");
                throw new DividedByAddNumberException();
            }

            int sum = a / b;
            Console.WriteLine("sum of " + sum);



        }
    }
}