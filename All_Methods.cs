using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes

{
    public class All_Methods
    {

        //public static void primenumber(int n)
        //{
            
        //    for (int i=2;n>=i;i++)
        //    {
        //        if (n%i == 0)
        //        {
        //            Console.WriteLine(n+":is not a prime number");
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine(n+": is prime number");
        //            break;
        //        }
                           
        //    }
        //}


        //public static void palindrom(string str)
        //{
        //    string str2= "";
        //    for(int i= str.Length - 1; i>=0;i--)
        //    {
        //        str2 = str2+ str[i];

        //    }
        //    if (str == str2)
        //    {
        //        Console.WriteLine(str+": Palindrom");
        //    }
        //    else
        //    {
        //        Console.WriteLine(str+": Not palindrom");
        //    }

        //} 
        //public static void Factorial(int n)
        //{
        //    int a=1;
        //    for(int i=1; i <= n; i++)
        //    {
        //        a = a * i;
        //    }
        //    Console.WriteLine(a+": Factorial of give number");
        //}

        public static void Armstrongnumber(int n)
        {
            int r= n;
            int a,sum=0;
            while (0 < n)
            {
                a = n % 10;
                n= n / 10;
                sum=sum+(a*a*a);

            }
            if (sum == r)
            {
                Console.WriteLine(r + ": is Armstrong number");
            }
            else
            {
                Console.WriteLine(r+":not a Armstrong number");
            }
        }
        public static void randamnumber()
        {
            Random random= new Random();

            for(int i=0; i < 5; i++)
            {
                Console.WriteLine("1 st Randam number :"+random.Next());
            }
            
        } 
    }
}
