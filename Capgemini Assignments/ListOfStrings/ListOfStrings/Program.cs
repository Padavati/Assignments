using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> obj = new List<string>();
            obj.Add("1");
            obj.Add("2");
            obj.Add("3");
            obj.Add("4");

            Console.Write(obj[0] + obj[0] + obj[0] + obj[0]);
            Console.Write(" " + obj[1] + obj[1] + obj[1] + obj[1]);
            Console.Write(" " + obj[2] + obj[2] + obj[2] + obj[2]);
            Console.Write(" " + obj[3] + obj[3] + obj[3] + obj[3]);
            
            Console.ReadKey();
        }
    }
}
