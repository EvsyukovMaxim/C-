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
            SberAccount myClient = new SberAccount(50000);
            AccumulativeAccount myClient2 = new AccumulativeAccount(10000);
            Console.WriteLine(myClient.ReturnCurrentSum);
            Console.WriteLine(myClient.ReturnCurrentSum);

            List<Client> client = new List <Client>();

            client.Add(myClient);
            client.Add(myClient2);
            Console.WriteLine(myClient.CompareTo(myClient2));
        }

    }
}
