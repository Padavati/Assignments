using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Assemble
{
    public static class Assemblyline
    {
        #region SuccessRate
        public static void SuccessRate()
        {
            int Speed = 10;

            if (Speed == 0)
            {
                Console.WriteLine("SuccessRate=" + 0);
            }
            else if (Speed <= 4)
            {
                Console.WriteLine("SuccessRate=" + 1);
            }
            else if (Speed <= 8)
            {
                Console.WriteLine("SuccessRate=" + 0.9);
            }
            else if (Speed == 9)
            {
                Console.WriteLine("SuccessRate=" + 0.8);
            }
            else
            {
                Console.WriteLine("SuccessRate=" + 0.77);
            }

        }
        #endregion SuccessRate

        #region ProductionRatePerHour
        public static void ProductionRatePerHour()
        {
            int hrs = 6;
            double res = hrs * 221*0.9;
            Console.WriteLine("Production RatePerHour=" + res);
        }
        #endregion ProductionRatePerHour

        #region  WorkingItemsPerMinute
        public static void WorkingItemsPerMinute()
        {
            int minutes = 6;

            int res = Convert.ToInt32(6 *3.6*0.9);
            Console.Write("Working Cars Produced Per Minute=" + res);

        }
        #endregion  WorkingItemsPerMinute
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assemblyline.SuccessRate();

            Assemblyline.ProductionRatePerHour();

            Assemblyline.WorkingItemsPerMinute();



            Console.ReadKey();

        }
    }
}
    

