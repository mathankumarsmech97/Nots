using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes
{
    public class Assignment_Set_2
    {
    //    public static void copyArray()
    //    {
    //        int[] str = {1,2,3,4,5};
           
    //        int[] str2=new int[str.Length];

    //        for(int i=0;i<str.Length;i++)
    //        {
    //            str2[i] = str[i];
    //            Console.WriteLine(str2[i]+" "); 
    //        }

    //    }

        //public static void frequencyOfElement()
        //{
        //    int[] arr1 = new int[] { 1, 2, 8, 3,2,2,2,5,1 };
        //    int[] arr2 = new int[arr1.Length];

        //    int visited = -1;

        //    for(int i=0;i< arr1.Length;i++) 
        //    {
        //        int no = arr1[i];
        //        int count = 1;
        //        for(int j=i+1;j<arr1.Length;j++)
        //        {
        //            if (no == arr1[j])
        //            {
        //                count++;
        //                arr2[j] = visited;
        //            }
        //        }

        //        if (arr2[i]!= visited)
        //            arr2[i] = count;

        //    }
        //    for(int i = 0; i < arr2.Length; i++)
        //    {
        //        Console.Write(arr1[i]+ "occure:" + arr2[i]+"\n");
        //    }
        //}


        //public static void rotateArrrayElement()
        //{
        //    int[] arr= new int[] {1,2,3,4,5,6};
        //    int rot = 3;
        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        Console.Write(arr[i]+" ");
        //    }

        //    for(int i = 0; i < rot; i++)
        //    {
        //        int j, first;
        //        first = arr[0];
        //        for(j=0; j<arr.Length-1;j++)
        //        {
        //            arr[j] = arr[j+1];
        //        }
        //        arr[j] = first;

        //    }
        //    Console.WriteLine("\n"+"After left rotation");

        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        // }

        //public static void printDuplicate()
        //{
        //    int[] arr=new int[] {1,2,3,4,5,3,6,7,8};
        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        for(int j=i+1;j<arr.Length; j++)
        //        {
        //            if (arr[i] == arr[j])
        //            {
        //                Console.WriteLine(arr[i]);
        //            }
        //        }
        //    }
        //}
        //public static void reverArray()
        //{
        //    int[] arr=new int[] {1,2,3,4,5,6,7,8,9,};

        //    for(int i=arr.Length-1; i>=0; i--)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        //public static void evenNumber()
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

        //    for(int i=0; i<arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0)
        //        {
        //            Console.WriteLine("The even number are :"+arr[i]);
        //        }
        //    }

        //}

        //public static void Addnumber()
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        if (arr[i]%2 != 0)
        //        {
        //            Console.WriteLine("Addnumber are :"+arr[i]);
        //        }
        //    }

       // }

        public static void largestNumber()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 10, 6, 7, 8, 9, };

            int max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
              if(arr[i] > max)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine("Largest number :" + max);
        }
        public static void samllestNumber()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 10, 6, 7, 8, 9, };

            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine("Smallest number :" + min);
        }

        public static void sumOfArray()
        {
            int[] arr = new int[] { 1, 11, 3, 4, 10, 6, 16, 8, 9, };

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }
            Console.WriteLine("Sumofnumber :" + sum);
        }


        public static void ascendingOrder()
        {
            int[] arr = new int[] { 1, 11, 3, 4, 10, 6, 16, 8, 9, };

            int temp ;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                   if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;


                    }

                }

            }
            Console.WriteLine("Ascending order");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
       
        public static void descendingOrder()
        {
            int[] arr = new int[] { 1, 11, 3, 4, 10, 6, 16, 8, 9, };

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;


                    }

                }

            }
            Console.WriteLine("Descending order");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


        public static void firstThreeLargestNumber()
        {
            int[] arr = new int[] { 1, 11, 3, 4, 10, 6, 16, 8, 9, };

            int Fmax = arr[0];
            int Smax = arr[1];
            int Tmax = arr[2];
            int i = 0;
            while(i<arr.Length)
            {
                if (arr[i] > Fmax)
                {
                    Fmax = arr[i];
                }
                else if (arr[i] > Smax)
                {
                    Smax= arr[i];
                }
                else if (arr[i] > Tmax)
                {
                    Tmax = arr[i];
                }
                i++;
            }

            Console.WriteLine("Fmax:" + Fmax + "\n" + "Smax:" + Smax + "Tmax:" + Tmax);

        }
            public static void getlargestNumber()
            {

            int[] arr = new int[] { 1, 11, 3, 4, 10, 6, 16, 8, 9, };

            int largestNumber = arr[0];
            int i=0;

            while (i < arr.Length)
            {
                if (arr[i] > largestNumber)
                {
                    largestNumber = arr[i];
                }
                i++;
            }

            Console.WriteLine("Largest Number in Array :" + largestNumber);


            }
        public static void firstSmallestNumber()
        {
            int[] arr = new int[] {  10, 30, 20, 10, 60, 30, 20, 90, };

            int min = Int32.MaxValue;
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                i++;
            }

            Console.WriteLine("Fisrt minimum value :"+min);

        }

        public static void countDuplicate() 
        {
            int[] arr = new int[] { 10, 30, 20, 10, 60, 30, 20, 90, };

            int[] fer= new int[arr.Length];
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1;j< arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = -1;
                    }

                }
                if (fer[i] != -1)
                fer[i]= count;
            }
            int count2=0;
            for(int i = 0; i < fer.Length; i++)
            {
                if (fer[i] > 1)
                {
                    count2++;
                }
            }
            Console.WriteLine("Duplicate eliments count in array :"+count);





        }






    }
}
