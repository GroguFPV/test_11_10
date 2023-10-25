using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во переменных = ");
            int n = int.Parse(Console.ReadLine());
            double[,] A = new double[n, n + 1];
            Console.WriteLine("Введите значения");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    A[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            double[] result = SolveUsingSeidelMethod(A, n);

            Console.WriteLine("Решение");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x{i + 1} = {result[i].ToString("N3")}");
            }
        }

        static double[] SolveUsingSeidelMethod(double[,] A, int n)
        {
            const int maxIterations = 1000;
            const double epsilon = 0.0001;
            double[] x = new double[n];
            double[] xPrev = new double[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = 0;
            }

            int iterations = 0;
            double error = 0;
            do
            {
                Array.Copy(x, xPrev, n);
                for (int i = 0; i < n; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                        {
                            sum += A[i, j] * x[j];
                        }
                    }

                    x[i] = (A[i, n] - sum) / A[i, i];
                }
                error = 0;
                for (int i = 0; i < n; i++)
                {
                    double diff = Math.Abs(x[i] - xPrev[i]);
                    if (diff > error)
                    {
                        error = diff;
                    }
                }
                iterations++;
            }
            while (error > epsilon && iterations < maxIterations);
            return x;
        }
    }
}