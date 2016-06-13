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

            StreamReader sr = new StreamReader(@"C:\Users\m.evsyukov\Desktop\flowCards.Card.xml");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(sr.ReadToEnd());

            XmlNodeList promotionalNodes = doc.SelectNodes("Card//Contacts//*[@IsPromotional=\"true\"]");
            XmlNodeList notPromotionalNodes = doc.SelectNodes("Card//Contacts//*[@IsPromotional=\"false\"]");

            sr.Close();

            using (var streamWriter = new StreamWriter(@"C:\Users\m.evsyukov\Desktop\promoCards.xml"))
            {
                foreach (XmlNode node in promotionalNodes)
                {
                    streamWriter.WriteLine($"<{node.Attributes["Value"]?.Value}> [<{node.Attributes["Description"]?.Value}>]");
                }
            }

            using (var streamWriter = new StreamWriter(@"C:\Users\m.evsyukov\Desktop\notPromoCards.xml"))
            {
                foreach (XmlNode node in notPromotionalNodes)
                {
                    streamWriter.WriteLine($"<{node.Attributes["Value"]?.Value}> [<{node.Attributes["Description"]?.Value}>]");
                }
            }
        }
    }
}