using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating File
            string path = "E:\\Assignment1.txt";
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            Console.WriteLine("      ID     Source    Destination    Date    Status    Network");

            Console.ReadKey();
        }
    }
}
 