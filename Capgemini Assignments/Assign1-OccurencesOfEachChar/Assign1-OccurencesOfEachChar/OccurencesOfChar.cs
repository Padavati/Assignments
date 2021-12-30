using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_OccurencesOfEachChar
{
    class OccurencesOfChar
    {
        public void Occurence()
        {
            string str1 = "hello world";
            while (str1.Length > 0)
            {
                int cal = 0;
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[0] == str1[i])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(str1[0] + "=" + cal);
                str1 = str1.Replace(str1[0].ToString(), string.Empty);
            }
            Console.WriteLine("**********************************");
        }
    }
}
