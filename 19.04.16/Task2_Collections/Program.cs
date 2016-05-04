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
            string slovo =  Console.ReadLine();
            int kolichestvo = slovo.Length;
            Dictionary<char, int> symbols = new Dictionary<char, int>();

            for (int i = 0; i < kolichestvo; i++)
            {
                if (symbols.ContainsKey(slovo[i]))
                {
                    symbols[slovo[i]]++;
                }
                else
                {
                    symbols.Add(slovo[i], 1);
                }
                Console.WriteLine(symbols[slovo[i]]);
            }
        }
    }
}
