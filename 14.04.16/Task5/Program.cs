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
            int[,] matrix2 = new int[n, m];
            int[,] matrix3 = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int a = rnd.Next();
                for (int j = 0; j < m; j++)
                {
                    matrix1[i, j] = a;
                    matrix2[i, j] = a;
                    matrix3[i, j] = a + a;
                }
            }

            //Выводим на консоль заполненную 1-ую матрицу
            Console.WriteLine("first Matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Выводим на консоль заполненную 2-ую матрицу
            Console.WriteLine("second Matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Печатаем итог сложения двух матриц
            Console.WriteLine("the third SUM Matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}