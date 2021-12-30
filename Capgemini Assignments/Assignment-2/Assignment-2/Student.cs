using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Student
    {
        public Student(string RollNo,string Name,string Course,string FeePaid)
        {
            Console.WriteLine("RollNo:" + RollNo);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Course Joined:" + Course);
            Console.WriteLine("Fee Paid:" + FeePaid);
        }
       

    }
}
