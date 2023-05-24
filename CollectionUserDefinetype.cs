//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace ArrayListDemo
//{
//    internal class CollectionUserDefinetype
//    {
//        public class coustomer
//        {
//            public string name { get; set; }
//            public int custId { get; set; }

//            public string city { get; set; }

//            public double salary { get; set; }
//        }

//        public static void Main()
//        {
//            List<coustomer> Coustomers = new List<coustomer>();


//            coustomer cs1 = new coustomer { name = "texter", custId = 10011, city = "chennai", salary = 50000 };
//            coustomer cs2 = new coustomer { name = "lexluther", custId = 10012, city = "trichy", salary = 40000 };
//            coustomer cs3 = new coustomer { name = "alex", custId = 10013, city = "hosure", salary = 60000 };
//            coustomer cs4 = new coustomer { name = "hulk", custId = 10014, city = "salem", salary = 70000 };

//            Coustomers.Add(cs1);
//            Coustomers.Add(cs2);
//            Coustomers.Add(cs3);
//            Coustomers.Add(cs4);

//            foreach (coustomer obj in Coustomers)
//            {
//                Console.WriteLine(obj.name + " " + obj.city + " " + obj.custId + " " + obj.salary);
//            }


//        }

//    }
//}
