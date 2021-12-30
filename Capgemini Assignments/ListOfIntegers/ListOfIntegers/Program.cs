using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> ls = new List<int>();
            ls.Add(1);
            ls.Add(2);
            ls.Add(3);
            ls.Add(4);

            foreach(var item in ls)
            {
                Console.Write((item+2)*(5)+" ");
            }
          
            Console.ReadKey();
            
        }
    }
      
}
