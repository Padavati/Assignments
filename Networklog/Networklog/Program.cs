using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Networklog
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E://networklog.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("\n ID \t\t Source \t\t Destination \t\t Date \t\t\t Status \t Network\n");

            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                string[] val = line.Split(':');


                if (val.Length > 1)
                { 
                    Console.Write(val[1] + "\t\t");  
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
