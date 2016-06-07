using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 5, 3, 7, 3, 9, 6, 4, 3, 2 };

            var filteredNumbers = numbers.Where(u => u % 2 == 0 || u > 5).OrderByDescending(u => u);

            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
