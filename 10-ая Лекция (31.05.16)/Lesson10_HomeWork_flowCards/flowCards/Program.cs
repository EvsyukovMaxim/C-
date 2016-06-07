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

                //XmlNode node = doc.SelectSingleNode("Card//Contacts");
                var promotionalNodes = doc.SelectNodes("Card//Contacts//*[@IsPromotional=\"true\"]");
                var notPromotionalNodes = doc.SelectNodes("Card//Contacts//*[@IsPromotional=\"false\"]");


                using (StreamWriter output = new StreamWriter(new FileStream(@"C:\Users\m.evsyukov\Desktop\promoCards.xml", FileMode.Create), Encoding.Unicode))
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(output, new XmlWriterSettings()))
                    {
                        foreach (XmlNode node in promotionalNodes)
                        {
                            node.WriteContentTo(xmlWriter);
                            //promotionalDoc.ImportNode(node, false);
                        }

                    }
                }


                //var promotionalDoc = new XmlDocument();
                
                //promotionalDoc.Save(@"C:\Users\m.evsyukov\Desktop\promoCards.xml");

                //using (var sw = new XmlTextWriter(Console.Out))
                //{
                //    foreach (XmlNode node in promotionalNode)
                //    {
                //        node.Save(sw);
                //    }
                //}
            }
        }
    }
}
// C:\Users\m.evsyukov\Desktop\flowCards.Card.xml