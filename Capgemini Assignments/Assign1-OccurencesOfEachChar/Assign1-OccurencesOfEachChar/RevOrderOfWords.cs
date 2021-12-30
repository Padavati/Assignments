using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_OccurencesOfEachChar
{
    class RevOrderOfWords
    {
        public void RevOrder()
        {
            Console.WriteLine("Enter the input string");
            string str3 = Console.ReadLine();
            string[] val= str3.Split(' ');
            Array.Reverse(val);
            for(int i=0;i<=val.Length-1;i++)
            {
                Console.Write(val[i] + " ");
            }
            Console.WriteLine("\n"+"" +"**********************************");

        }
    }
}
