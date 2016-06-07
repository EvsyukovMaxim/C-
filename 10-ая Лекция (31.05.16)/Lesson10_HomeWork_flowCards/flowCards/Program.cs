using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace flowCards
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\m.evsyukov\Desktop\flowCards.Card.xml"))
            {
                var doc = new XmlDocument();
                doc.LoadXml(sr.ReadToEnd());

                var promotionalNodes = doc.SelectNodes("Card//Contacts//*[@IsPromotional=\"true\"]");
                var notPromotionalNodes = doc.SelectNodes("Card//Contacts//*[@IsPromotional=\"false\"]");

                using (var streamWriter = new StreamWriter(@"C:\Users\m.evsyukov\Desktop\promoCards.xml"))
                {
                    foreach (XmlNode node in promotionalNodes)
                    {
                        streamWriter.WriteLine(node.OuterXml);
                    }
                }

                using (var streamWriter = new StreamWriter(@"C:\Users\m.evsyukov\Desktop\notPromoCards.xml"))
                {
                    foreach (XmlNode node in notPromotionalNodes)
                    {
                        streamWriter.WriteLine(node.OuterXml);
                    }
                }
            }
        }
    }
}