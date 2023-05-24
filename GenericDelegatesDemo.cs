//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Delegates
//{

//    internal class GenericDelegatesDemo
//    {



//        public static void Main()
//        {
//            // Use Func and Lambda Expression

//            Func<int, float, double, double> obj1 = (x, y, z) => { return (x + y + z); };
//            double result = obj1.Invoke(22, 21f, 20.1);
//            Console.WriteLine(result);

//            // Use Action and Lambda Expression

//            Action<int, float, double> obj2 = (x, y, z) => { Console.WriteLine(x + y + z); };
//            obj2.Invoke(22, 21f, 20.1);

//            // Use Predicate and Lambda Expression

//            Predicate<string> obj3 = str =>
//            {
//                if (str.Length > 5)
//                    return true;
//                return false;
//            };
//            bool bo = obj3.Invoke("hellooo");
//            Console.WriteLine(bo);





//        }

//    }
//}
