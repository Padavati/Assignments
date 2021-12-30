using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_a_in_ListOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> ls = new List<string>();
            ls.Add("abc");
            ls.Add("cdaef");
            ls.Add("js");
            ls.Add("php");
            string str = ls[0] + " " + ls[1] + " " + ls[2] + " " + ls[3];
            Console.Write(str.Replace("a", ""));
            
            Console.ReadKey();
        }


    }
}
