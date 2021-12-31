using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating stack
            Stack s1 = new Stack();

            //taking input from user and store in stack
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                s1.Push(name);
                Console.WriteLine("Enter age:");
                int age = Convert.ToInt32(Console.ReadLine());
                s1.Push(age);
            }
            Console.WriteLine("\n");

            //convert objects to Array
            Object[] arr = s1.ToArray();
            Console.WriteLine(arr[1] + "-" + arr[0]);
            Console.WriteLine(arr[3] + "-" + arr[2]);
            Console.WriteLine(arr[5] + "-" + arr[4]);

            Console.ReadKey();
        }
    }
}
