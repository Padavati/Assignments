using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task_2
{
    public class Student : Person
    {

        private int[] testScores;
        public Student(string Fs, string Ls, int ID, int[] testScores)
        {

            Details(Fs, Ls, ID);
            this.testScores = testScores;
        }
         public char Calculate()
        { 
      
            int sum = 0;
            int avg;
            char Grade;
            Array.ConvertAll(testScores, ele => ele.ToString());

            for (int i=0;i<testScores.Length;i++)
            {

                sum = sum + testScores[i];
            }

            avg = sum / testScores.Length;

            if (avg <= 100 && avg >= 90)
            {
                return Grade = 'O';
            }
            else if (avg < 90 && avg >= 80)
            {
                return Grade = 'E';
            }
            else if (avg < 80 && avg >= 70)
            {
                return Grade = 'A';
            }
            else if (avg < 70 && avg >= 55)
            {
                return Grade = 'P';
            }
            else if (avg < 55 && avg >= 40)
            {
                return Grade = 'D';
            }
            else
            {
                return Grade = 'T';
            }
          
        }
    }
}



