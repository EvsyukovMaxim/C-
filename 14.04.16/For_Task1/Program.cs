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
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int min = 0;
            int max = 0;
            int even = 0;
            int odd = 1;
            for (int i = 0; i < n; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
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
                if (value % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd = value * odd;
                }
                sum = sum + value;
                Console.WriteLine("Сумма чисел: " + sum);
                Console.WriteLine("Минимальное число: " + min);
                Console.WriteLine("Максимальное число: " + max);
                Console.WriteLine("Количество четных чисел: " + even);
                Console.WriteLine("Произведение нечетных чисел: " + odd);
            }
        }
    }
}