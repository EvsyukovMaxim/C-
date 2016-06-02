using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson10_ClassWork_Files_XML_s
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter sw = new StreamWriter(@"D:\мой файлик.txt"))
            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();
                sw.WriteLine(number);
            }

            using (StreamReader sr = new StreamReader(@"D:\мой файлик.txt"))
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
