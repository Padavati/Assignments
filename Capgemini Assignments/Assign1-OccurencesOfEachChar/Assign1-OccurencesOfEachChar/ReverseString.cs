using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_OccurencesOfEachChar
{
    class ReverseString
    {
        public void Reverse()
        {
            Console.WriteLine("Enter a input string");
            string str2 = Console.ReadLine();
           
            string revs = "";
            int Length = str2.Length - 1;
            while(Length>=0)
            {
                revs = revs + str2[Length];
                Length--;
            } 
            Console.WriteLine(revs);
            Console.WriteLine("**********************************");
        }
    }
}
