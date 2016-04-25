using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какое-нЕДь словечКО");
            string myString =  Console.ReadLine();
            int kolichestvo = myString.Length;
            Dictionary<string, int> Slova = new Dictionary<string, int>();
            Slova.Add(myString,kolichestvo);
            Console.WriteLine(Slova[myString]);
        }
    }
}
