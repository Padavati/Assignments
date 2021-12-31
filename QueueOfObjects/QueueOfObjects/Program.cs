using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating queue
            Queue q1 = new Queue();

            //taking input from user and store in stack
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                q1.Enqueue(name);
                Console.WriteLine("Enter age:");
                int age = Convert.ToInt32(Console.ReadLine());
                q1.Enqueue(age);
            }
            Console.WriteLine("\n");

            //convert objects to Array
            Object[] arr = q1.ToArray();
            Console.WriteLine(arr[0] + "-" + arr[1]);
            Console.WriteLine(arr[2] + "-" + arr[3]);
            Console.WriteLine(arr[4] + "-" + arr[5]);

            Console.ReadKey();
        }
    }
}
