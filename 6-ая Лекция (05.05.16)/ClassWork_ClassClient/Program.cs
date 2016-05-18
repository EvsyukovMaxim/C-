using ClassWork_ClassClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_ClassClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client(); 
            Console.WriteLine(myClient.GetSum);

        }

    }
}
