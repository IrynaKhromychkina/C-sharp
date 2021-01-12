using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter phoneBookXMLWriter = new XmlTextWriter("PhoneBook.xml", null);
            phoneBookXMLWriter.Formatting = Formatting.Indented;
            phoneBookXMLWriter.IndentChar = '\t';
            phoneBookXMLWriter.Indentation = 1;

            phoneBookXMLWriter.WriteStartDocument();
            phoneBookXMLWriter.WriteStartElement("MyContacts");
            phoneBookXMLWriter.WriteStartElement("Contact");
            phoneBookXMLWriter.WriteStartAttribute("PhoneNumber");
            phoneBookXMLWriter.WriteString("123456780");
            phoneBookXMLWriter.WriteEndAttribute();
            phoneBookXMLWriter.WriteString("MyBestFriend");
            phoneBookXMLWriter.WriteEndElement();

            phoneBookXMLWriter.WriteStartElement("Contact");
            phoneBookXMLWriter.WriteStartAttribute("PhoneNumber");
            phoneBookXMLWriter.WriteString("444465687");
            phoneBookXMLWriter.WriteEndAttribute();
            phoneBookXMLWriter.WriteString("Malina");
            phoneBookXMLWriter.WriteEndElement();

            phoneBookXMLWriter.WriteEndElement();

            phoneBookXMLWriter.Close();

            Console.WriteLine("\tAll xml document data are the following:\n");

            XmlDocument phoneBook = new XmlDocument();
            phoneBook.Load("PhoneBook.xml");
            XmlNode phoneBookRoot = phoneBook.DocumentElement;
            Console.WriteLine($"Root name: {phoneBookRoot.LocalName}\n");

            foreach (XmlNode contacts in phoneBookRoot.ChildNodes)
            {
                Console.WriteLine("Contact found:\n");

                foreach (XmlNode contact in contacts.ChildNodes)
                {
                    Console.WriteLine($"Contact name: \n{contact.InnerText}");
                }
                XmlAttributeCollection attributes = contacts.Attributes;
                if (attributes != null)
                {
                    for (int i = 0; i < attributes.Count; i++)
                    {
                        Console.WriteLine("Attributes:");
                        Console.WriteLine(attributes[i].Value);
                    }
                }
            }

            Console.WriteLine("\n\tAll attributes of the xml document:\n");

            foreach (XmlNode contacts in phoneBookRoot.ChildNodes)
            {
                XmlAttributeCollection attributes = contacts.Attributes;
                if (attributes != null)
                {
                    for (int i = 0; i < attributes.Count; i++)
                    {
                        Console.WriteLine($"Attribute:");
                        Console.WriteLine(attributes[i].Value);
                    }
                }
            }


            Console.ReadKey();







        }
    }
}
