using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_OccurencesOfEachChar
{
    class SecLargestInt
    {
        public void Largest()
        {
            
            int[] arr = new int[] { 3, 2, 1, 5, 4 };
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach(var val in arr)
            {
                if(val>largest)
                {
                    second = largest;
                    largest = val;
                }
                else if(val>second)
                {
                    second = val;
                }
            }
            Console.WriteLine("3 2 1 5 4 In These Integers the second largest number is");
            Console.WriteLine(second);
            Console.WriteLine("**********************************");

        }
    }
}
