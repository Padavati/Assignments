using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_OccurencesOfEachChar
{
    class RevEachWord
    {
        public void RevEach()
        {
            Console.WriteLine("Enter the input string");
            string str4 = Console.ReadLine();
            string strrev = "";
            string[] item = str4.Split(' ');
            foreach(var val in item)
            {
                string temp = "";
                foreach(var ch in val.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp+" ";
            }
            Console.WriteLine(strrev);
            
            Console.WriteLine("**********************************");
        }
    }
}
