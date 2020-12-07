using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializationAndAttributes
{
    [Serializable]
    public class Candies
    {
        public Candies(string filling, string topping, string packaging, int quantity)
        {
            this.Filling = filling;
            this.Topping = topping;
            this.Packaging = packaging;
            this.Quantity = quantity;
        }
        public Candies() { }

        [XmlAttribute("Condiment")]       
        public string Filling { get; set; }
        [XmlAttribute("Topper")]
        public string Topping { get; set; }
        [XmlIgnore]
        public string Packaging { get; set; }
        [XmlAttribute("Pieces")]
        public int Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Candies candiesBDSet = new Candies("almonds", "chocolate", "paperBox", 36);
            Candies result;

            XmlSerializer serializer = new XmlSerializer(typeof(Candies));

            FileStream stream = new FileStream("Candies.xml", FileMode.Create, FileAccess.Write);
            serializer.Serialize(stream, candiesBDSet);
            stream.Close();

            //Uncomment attributes above and serialize the object again

            //XmlSerializer serializerPlusAttributes = new XmlSerializer(typeof(Candies));

            //FileStream streamPlusAttributes = new FileStream("CandiesWithAttributes.xml", FileMode.Create, FileAccess.Write);
            //serializerPlusAttributes.Serialize(streamPlusAttributes, candiesBDSet);
            //stream.Close();
        }

    }
}
