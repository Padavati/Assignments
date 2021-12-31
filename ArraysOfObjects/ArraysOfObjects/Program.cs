using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                a1.Add(name);
                Console.WriteLine("Enter age:");
                int age = Convert.ToInt32(Console.ReadLine());
                a1.Add(age);
            }
            Console.WriteLine("\n" + a1[0] + "-" + a1[1]);
            Console.WriteLine( a1[2] + "-" + a1[3]);
            Console.WriteLine(a1[4] + "-" + a1[5]);

            Console.ReadKey();
        }
    }
}
