using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes
{
    public class Assignment_Set_3
    {
        public static void additionMatrix()
        {
            int[,] a = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
            int[,] b = { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };

            int[,] c = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write(" " + c[i, j]);
                }
                Console.WriteLine("\n");
            }

        }
        public static void subtractMatrix()
        {
            int[,] a = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            int[,] b = { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };

            int[,] c = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                    Console.Write(" " + c[i, j]);
                }
                Console.WriteLine("\n");
            }

        }
        public static void matrixmultiplication()
        {
            int[,] a = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            int[,] b = { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };

            int[,] c = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] * b[i, j];
                    Console.Write(" " + c[i, j]);
                }
                Console.WriteLine("\n");
            }

        }

        public static void matrixEqualornot()
        {
            int[,] a = { { 10, 10, 100 }, { 10, 10, 10 }, { 10, 10, 10 } };
            int[,] b = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };

            int[,] c = new int[3, 3];
            bool flage = true;
            bool flage2 = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] == b[i, j])
                    {
                        flage = true;
                    }
                    else
                    {
                        flage2 = false;
                        break;
                    }

                }

            }
            if (flage2 == true)
            {
                Console.WriteLine(" Two are Matrix are equal ");
            }
            else
            {
                Console.WriteLine("the Two Matrix are not equal ");
            }
        }

        public static void transposeOfMatrix()
        {
            int i, j, r, c;

            int[,] arr1 = new int[30, 30];
            int[,] arr2 = new int[30, 30];
            Console.Write("Rows entered = ");
            r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Columns entered = ");
            c = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    // Console.Write("[{0}],[{1}} :", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Before Transpose");
            for (i = 0; i < r; i++)
            {

                for (j = 0; j < c; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);

                }
                Console.WriteLine("");

            }
            for (i = 0; i < r; i++)
            {

                for (j = 0; j < c; j++)
                {
                    arr2[j, i] = arr1[i, j];
                }
            }
            Console.WriteLine("After Transpose");
            for (i = 0; i < r; i++)
            {

                for (j = 0; j < c; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);

                }
                Console.WriteLine("");

            }
        }


        public static void upperTriangleMatrix()
        {

            int[,] a = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            int[,] b = { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };


            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(b[i, j]+"\t");
                    }
                    else
                    {
                        Console.Write("0\t");
                    }
                }
                Console.Write("\n");
                
            }


        }
        public static void lowerTriangleMatrix()
        {

            int[,] a = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            int[,] b = { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };


            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (i <= j)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("0\t");
                    }
                }
                Console.Write("\n");

            }

        }
        public static void frequnceOfAddandEven()
        {

           // int[,] a = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            int[,] b = { { 3, 2, 5 }, { 3, 2, 3 }, { 3, 6, 4 } };
            int even=0;
            int add = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (b[i,j]%2==0)
                    {
                        even++;   
                    }
                    else
                    {
                        add++;
                    }
                }
                
            }
            Console.WriteLine("Even count :" + even + "\n" + "Add count:" + add);

        }
        public static void sumOfEachColumnAndRow()
        {

            // int[,] a = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            int[,] b = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int row =0;
            int col = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    row = row + b[i, j];
                }
                Console.WriteLine("Sum of " + i + 1 + "Row :" + row);

            }
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    col = col + b[j, i];
                    
                }
                Console.WriteLine("Sum of " + i + 1 + "Column :" + col);

            }


        }




    }
}
