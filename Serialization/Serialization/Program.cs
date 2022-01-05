using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    public class Demo
    {
        public string AppName { get; set; }
        public int AppID { get; set; }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Serialization.SerializeData();
            Serialization.DeSerializeData();
            Serialization.XmlSerialization();
            Serialization.XmlDeSerialization();

            Console.ReadKey();
        }
    } 
    class Serialization
    {
        public static void SerializeData()
        {
            //Intialize an Object
            Demo obj = new Demo();
            obj.AppID= 1012;
            obj.AppName = "Serialization";

            //Create and Write into the file stream
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(@"E:\Serialization\\Serialization.txt", FileMode.Create, FileAccess.Write);

            //Serialize the object
            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public static void DeSerializeData()
        {
            //Open and Read the File stream
            FileStream fs = new FileStream(@"E:\Serialization\\Serialization.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            
            //DeSerialize the Object
            Demo objnew = (Demo)formatter.Deserialize(fs);

            //Write The Data on Console Window
            Console.WriteLine(objnew.AppID);
            Console.WriteLine(objnew.AppName);

        }
        
        public static void XmlSerialization()
        {
            //Intialize an Object
            AddressDetails add = new AddressDetails();
            add.HouseNo =99;
            add.StreetName = "Cherlopalli";
            add.City = "Tirupati";

            //Create and Write into the file stream
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using(TextWriter tw=new StreamWriter("E:\\Serialization\\XmlData.xml"))
            {
                ////Serialize the object
                serializer.Serialize(tw, add);
            }
        }
        public static void XmlDeSerialization()
        {
            //Open and Read the File stream
            XmlSerializer deserializer = new XmlSerializer(typeof(AddressDetails));
            TextReader tr = new StreamReader("E:\\Serialization\\XmlData.xml");

            //DeSerialize the Object
            AddressDetails addNew = (AddressDetails)deserializer.Deserialize(tr);
            Console.WriteLine();

            //Write The Data on Console Window
            Console.WriteLine(addNew.HouseNo);
            Console.WriteLine(addNew.StreetName);
            Console.WriteLine(addNew.City);
            tr.Close();
        }
    }
    public class AddressDetails
    {
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
    }

}
