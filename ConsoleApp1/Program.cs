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
            Console.WriteLine("Введите количество уравнений: ");
            int n = int.Parse(Console.ReadLine());

            double[,] coefficientMatrix = new double[n, n];
            double[] constantTerms = new double[n];
            double[] initialSolution = new double[n];
            double[] solution = new double[n];


            Console.WriteLine("Введите коэффициенты матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    coefficientMatrix[i, j] = double.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("Введите свободные члены:");
            for (int i = 0; i < n; i++)
            {
                constantTerms[i] = double.Parse(Console.ReadLine());
            }


            Console.WriteLine("Введите начальное приближение:");
            for (int i = 0; i < n; i++)
            {
                initialSolution[i] = double.Parse(Console.ReadLine());
            }


            Console.WriteLine("Введите количество итераций:");
            int iterations = int.Parse(Console.ReadLine());


            for (int iter = 0; iter < iterations; iter++)
            {
                for (int i = 0; i < n; i++)
                {
                    double sum = 0.0;
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                        {
                            sum += coefficientMatrix[i, j] * initialSolution[j];
                        }
                    }
                    solution[i] = (constantTerms[i] - sum) / coefficientMatrix[i, i];
                }


                for (int i = 0; i < n; i++)
                {
                    initialSolution[i] = solution[i];
                }
            }


            Console.WriteLine("Решение системы:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x{i + 1} = {solution[i]}");
            }
        }
    }
}