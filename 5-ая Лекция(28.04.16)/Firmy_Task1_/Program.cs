﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firmy_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client("","",9999999999999999);
            IP myIP = new IP("",new DateTime(2106,04,27),"","",9999999); 
            OOO myOOO = new OOO("","","","", 9999999);

            myIP.ReturnPersonFIO();
            myOOO.ReturnFirmName();
            myClient.ReturnOrderSum();
        }
    }
}
