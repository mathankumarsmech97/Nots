using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes
{
    public class Assignment_Set_6
    {
        public static void linearSearch()
        {
            int[] arr1 = { 12, 20, 30, 40, 55, 43, 12 };
            int i, needNumber = 43;


            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == needNumber)
                {
                    Console.WriteLine(needNumber); break;
                }
            }

        }
        public static object binarySearch(int min, int max, int key)
        {
            int[] arr1 = { 10, 20, 30, 40, 50, 60 };
            min = 0;
            max = arr1.Length - 1;


            int mid = (min + max) / 2;


            while (min <= max)
            {
                if (key == arr1[mid])
                {
                    return ++mid;
                }
                else if (key < arr1[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "None";

        }
        public static void bubbbuleSort()
        {
            int temp;

            int[] arr1 = { 70, 20, 25, 40, 50, 60, };
            int n = arr1.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            foreach(int e in arr1)
            {
                Console.Write(e+" ");
            }

        }
        public static void selectedSort()
        {
            int temp;

            int[] arr1 = { 70, 20, 25, 40, 50, 60, };
            int n = arr1.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[i];
                        arr1[i] = temp;
                    }
                }
            }
            foreach(int r in arr1)
            {
                Console.Write(r+" ");
            }

        }
    }
}
