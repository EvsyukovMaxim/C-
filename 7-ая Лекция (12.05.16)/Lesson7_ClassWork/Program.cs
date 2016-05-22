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
            Client myClient2 = new Client();
            Console.WriteLine(myClient.GetSumAccum);
            Console.WriteLine(myClient2.GetSumSber);

            List<Client> client = new List <Client>();

            client.Add(myClient);
            client.Add(myClient2);
            Console.WriteLine(myClient.CompareTo(myClient2));
        }

    }
}
