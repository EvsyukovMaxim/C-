using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация матриц
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[n, m];
            int[] RowMatrix = new int[m];
            int[] MinValue = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int a = rnd.Next();
                    matrix1[i, j] = a;
                    RowMatrix[j] = a;
                }
                MinValue [i] = FindMinValue(RowMatrix);
            }

            Console.WriteLine("Вся матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Выводим на консоль заполненный массив с минимальными значениями
            Console.WriteLine("\n");
            Console.WriteLine("Минимальные значения каждой строки Матрицы:");
            Array.Sort(MinValue);
            Array.Reverse(MinValue);
            for (int i = 0; i < n; i++)
            {
                Console.Write(MinValue[i] + " ");
            }

        }
        public static int FindMinValue(int[] array)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i <array.Length; i++)
            {
                int value = array[i];
                if (i == 0)
                {
                    min = value;
                    max = value;
                }
                else
                {
                    if (min > value)
                    {
                        min = value;
                    }
                    if (max < value)
                    {
                        max = value;
                    }
                }
            }
            return min;
        }

    }
}