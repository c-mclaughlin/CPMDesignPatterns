/*
 * C# Program to Perform Matrix Multiplication
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_multiplications
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n, o, p;
            Console.WriteLine("Enter the Number of Rows and Columns for Matrix A: ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Enter the First Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix is:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter the Number of Rows and Columns for Matrix B: ");
            o = Convert.ToInt32(Console.ReadLine());
            p = Convert.ToInt32(Console.ReadLine());
            int[,] b = new int[o, p];
            if (n != o)
            {
                Console.WriteLine("These Matrices cannot be Multiplied.");
                return;
            }
                
                
            Console.WriteLine("Enter the Second Matrix");
            for (i = 0; i < o; i++)
            {
                for (j = 0; j < p; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is :");
            for (i = 0; i < o; i++)
            {
                for (j = 0; j < p; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix Multiplication is :");
            int[,] c = new int[m, p];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < p; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < p; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}