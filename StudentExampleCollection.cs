using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ArrayListDemo
//{

//    internal class StudentExampleCollection : IComparable<StudentExampleCollection>
//    {
//        public int Sid { get; set; }
//        public string Sname { get; set; }
//        public int Sclass { get; set; }
//        public float Smark { get; set; }

//        public int CompareTo(StudentExampleCollection? other)
//        {
//            if (this.Sid > other.Sid)
//                return 1;
//            else if (this.Sid < other.Sid)
//                return -1;
//            else
//                return 0;
//        }
//        class CompraeStudent : IComparer<StudentExampleCollection>
//        {
//            public int Compare(StudentExampleCollection? x, StudentExampleCollection? y)
//            {
//                if (x.Smark > y.Smark)
//                    return 1;
//                else if (x.Smark < y.Smark)
//                    return -1;
//                else
//                    return 0;
//            }
//        }



//        class Test
//        {
            //Normal Method
            //public static int CompraeName(StudentExampleCollection S1, StudentExampleCollection S2)
            //{
            //  return  S1.Sname.CompareTo(S2.Sname);
            //}




            //public static void Main()
            //{
            //    StudentExampleCollection cs1 = new StudentExampleCollection { Sid = 10014, Sname = "bTexter", Sclass = 10, Smark = 350f };
            //    StudentExampleCollection cs2 = new StudentExampleCollection { Sid = 10012, Sname = "ajon", Sclass = 10, Smark = 450f };
            //    StudentExampleCollection cs3 = new StudentExampleCollection { Sid = 10011, Sname = "Alex", Sclass = 10, Smark = 325f };
            //    StudentExampleCollection cs4 = new StudentExampleCollection { Sid = 10013, Sname = "cVicky", Sclass = 10, Smark = 295f };
            //    StudentExampleCollection cs5 = new StudentExampleCollection { Sid = 10016, Sname = "xRam", Sclass = 10, Smark = 496f };
            //    StudentExampleCollection cs6 = new StudentExampleCollection { Sid = 10015, Sname = "zblock", Sclass = 10, Smark = 310f };

            //    List<StudentExampleCollection> ls = new List<StudentExampleCollection>() { cs1, cs2, cs3, cs4,cs5,cs6};


                // This sort the Deta base on 'n' number Detas that time use this concept

                //ls.Sort();
                //ls.Reverse();

                // This Given input is already define you Consume and sort that 

               // CompraeStudent cs = new CompraeStudent();
                               
                // ls.Sort(cs);

                // This type of input Based on Index count

                //ls.Sort(1, 4, cs);

                //This sort type 3 use the delgate as parameter that delegate point the another method 
                //because the Sort is method and wecannot pass the another method in sort so delegate point the 
                //other method that delegate passing the parameter sort method 

                //Normal Method

                // Comparison<StudentExampleCollection> obj = new Comparison<StudentExampleCollection>(CompraeName);

                // ls.Sort(obj);

                //use Anonymous method

                //ls.Sort(delegate (StudentExampleCollection S1, StudentExampleCollection S2) 
                //{return S1.Sname.CompareTo(S2.Sname);});

                //useing Lambda Expression

//                ls.Sort((S1, S2) => S1.Sname.CompareTo(S2.Sname));
                

//                foreach (StudentExampleCollection ex in ls)
//                {
//                    Console.WriteLine(ex.Sid + " " + ex.Sname + " " + ex.Sclass + " " + ex.Smark);
//                }


//                Console.ReadLine();


//            }
//        }
//    }
//}
