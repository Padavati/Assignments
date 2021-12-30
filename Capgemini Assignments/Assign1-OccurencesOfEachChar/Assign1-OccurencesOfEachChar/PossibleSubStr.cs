using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_OccurencesOfEachChar
{
    class PossibleSubStr
    { 
        public void Possible()
        {
            Console.WriteLine("Enter a string");
            string str5 = Console.ReadLine();
            for(int i=0;i<str5.Length;i++)
            {
                for(int j=0;j<=str5.Length-i;j++)
                {
                    Console.Write(str5.Substring(i, j) + " ");
                }
            }
            Console.WriteLine("\n"+"**********************************");
        }
    }
}
