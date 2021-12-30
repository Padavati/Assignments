using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorRollNo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails sd1 = new StudentDetails("184C5A0414", "Lavanya", "C#");
            sd1.Print();
            sd1.Payment(100);
            sd1.TotalDueAmount();

            StudentDetails sd2 = new StudentDetails("174C5A0413", "Puneeth", "ASP.NET");
            sd2.Print();
            sd2.Payment(200);
            sd2.TotalDueAmount();

            Console.ReadKey();
        }
    }
    public class StudentDetails
    {
        public string RollNo { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int FeePaid { get; set; }
        public StudentDetails(string rollno, string name, string course)
        {
            this.RollNo = rollno;
            this.Name = name;
            this.Course = course;
        }
        public void Print()
        {
            Console.WriteLine("RollNo:" + RollNo);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Course:" + Course);
            Console.WriteLine("TotalFee:" + TotalFeeAmount);
        }
        public void Payment(int amount)
        {
            FeePaid = FeePaid + amount;
            Console.WriteLine("FeePaid:" + FeePaid);
        }
        public double ServiceTax { get; set; }
        public int DueAmount { get; set; }
        public int TotalFee { get; set; }
        public int TotalFeeAmount
        {
            get
            {
                ServiceTax = 12.3 / 100;
                if(Course=="C#")
                {
                    return 2000;
                }
                else
                {
                    return 3000;
                }
            }
        }
        public void TotalDueAmount()
        {
            DueAmount = TotalFeeAmount - FeePaid;
            Console.WriteLine("DueAmount:" + DueAmount);
            Console.WriteLine("\n");
        }
    } 
}
