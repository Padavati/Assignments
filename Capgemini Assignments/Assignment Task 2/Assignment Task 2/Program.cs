using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task_2
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Enter the strings Fs,Ls,ID:");
            string Fs = Console.ReadLine();
            string Ls = Console.ReadLine();
            int ID =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter numScores Value:");
            int numScores = Convert.ToInt32(Console.ReadLine());
            int[] testScores = new int[numScores];
            for(int i=0;i<numScores;i++)
            {
                testScores[i] = Convert.ToInt32(Console.ReadLine());
            }

            Student s = new Student(Fs, Ls, ID, testScores);
            s.Details(Fs, Ls, ID);

            Console.WriteLine("Grade:"+s.Calculate());

            Console.ReadKey();
        } 

    }
}




  

