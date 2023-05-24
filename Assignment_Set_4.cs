using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes
{
    public class Assignment_Set_4
    {

        public static void rightTrianglePattren()
        {
            int row = 6;
            for(int i=0; i < row; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
        public static void leftTrianglePattren()
        {
            int row = 6;
            for (int i = row; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for(int k = i; k < row; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
        }
        public static void pyramidPattren()
        {
            int row = 6;
            for (int i = 0; i <row; i++)
            {
                for (int j = row-i; j >1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <=i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
        }
        public static void diamondPattren()
        {
            int i, j, row=8, space = 1;
            space = row - 1;

            for (j = 1; j <= row; j++)
            {
                for (i = 1; i <= space; i++)
                {
                    Console.Write(" ");
                }
                space--;
                for (i = 1; i <= 2 * j - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            space = 1;
            for (j = 1; j <= row - 1; j++)
            {
                for (i = 1; i <= space; i++)
                {
                    Console.Write(" ");
                }
                space++;
                for (i = 1; i <= 2 * (row - j) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public static void downWardTriangle()
        {
            int i, j ,row=7,k;
            for (i = 0; i < row; i++)
            {
                for (j = i; j < row; j++)
                {
                    Console.Write("*");
                }
                for (k =i; k >=0; k--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void mirroredRightAngleTriangle()
        {
            int i, j, row = 7, k;
            for (i = 0; i < row; i++)
            {
                for (j = i; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k >= 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void reversePyramid()
        {
            int i, j, k,row=8;
            for (i = 0; i < row; i++)
            {
                for (j = i; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (k = i; k < row; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void rightPascalTriangle()
        {
            int i, j,k,row=8;;
            for (i = 0; i < row; i++)
            {
                for (j = i; j >= 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                
            }
            for (i = 0; i < row; i++)
            {
                for (j = i; j < row; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void leftPascalTriangle()
        {
            int i, j, k, row = 10;

            for (i = 0; i < row; i++)
            {
                for (j = i; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (k =i; k>=0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 0; i < row; i++)
            {
                for (k = i; k >= 0; k--)
                {
                    Console.Write(" ");
                }
                for (j = i; j < row; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }

        public static void sandglassPattern()
        {
            int i,j,k,row = 9;
            for (i = 0; i < row; i++)
            {
                for (k = i; k >= 0; k--)
                {
                    Console.Write(" ");
                }
                for (j = i; j < row; j++)
                {
                    Console.Write("* ");
                }
               
                Console.WriteLine();
            }
            for (i = 0; i < row; i++)
            {
                for (k = i; k < row; k++)
                {
                    Console.Write(" ");
                }
                for (j = i; j >= 0; j--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
        public static void alphabetstarPattern()
        {
            int i, j, k,fr=4,sr=5;

            for (i = 0; i < 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                Console.Write("*   *"+"\n");
            }
            for (i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            for (i = 0; i < 4; i++)
            {
                Console.Write("*   *");
                Console.WriteLine();
            }

        }
        public static void triangleStarPattern()
        {
            int i, j, k,m,row=10;

            for (i = 1; i <= row; i++)
            {
                for (j = i; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <=(2*i-1); k++)
                {
                    if (k == 1 || i == row || k == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
                                              
        }
       
    }
}
