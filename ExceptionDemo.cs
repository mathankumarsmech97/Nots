using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    internal class ExceptionDemo
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter the number1");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number2");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    return;
                }
                int sum = a / b;
                Console.WriteLine("sum of " + sum);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            finally
            {
                Console.WriteLine("Finally block Excuting");
            }

            Console.WriteLine("End of Programe");




        }



    }
}
