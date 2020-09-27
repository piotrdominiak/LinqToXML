using System;
using System.Xml.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Xml;
using System.Data.SqlTypes;

namespace LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            /* XDocument xmlDocument = new XDocument(
                     new XDeclaration("1.0", "utf-8", "yes"),
                     new XComment("Test comment"),
                     new XElement("SRX_coefficients",
                         new XElement("TemperatureStart",1100),
                         new XElement("G", 59701475138),
                         new XElement("Mi_Constant", 8e10)));

             xmlDocument.Save(@"Dat1312a.xml");

             */

            /*   XDocument xmlDocument = new XDocument(
                   new XDeclaration("1.0", "utf-8", "yes"),
                   new XComment("Test comment"),
                   new XElement("Students",

                       from student in Student.GetAllStudens()
                       select new XElement("Student", new XAttribute("Id", student.Id),
                                  new XElement("Name",student.Name),
                                  new XElement("Gender", student.Gender),
                                  new XElement("TotalMarks", student.TotalMarks)             
                   )));
               xmlDocument.Save(@"NewDataataaaa.xml");




            XDocument data = XDocument.Load(@"E:\PracaInzynierska\PracaInzynierska\PracaInzynierska\Data\sampleXML_1.xml");

            data.Save(@"d:\tetetete.xml");
            */

            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\PracaInzynierska\PracaInzynierska\PracaInzynierska\Data\sampleXML_1.xml");

            XmlNodeList nl = doc.SelectNodes("SRX_coefficients");
            XmlNode root = nl[0];

            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.OfType<XComment>()) 
                {
                    
                }

                string name = node.Name;
                double value = Double.Parse(node.InnerText);
                Console.WriteLine("name {0}, value {1}", name, node.InnerText);
                node.InnerText = (value*2).ToString();
                Console.WriteLine("name {0}, value {1}", name, node.InnerText);

                
            }
        }


    }
}
