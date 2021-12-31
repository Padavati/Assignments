using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlCar
{
    public interface IRemoteControlCar
    {
        int DistanceTravelled { get; set; }
        void Drive();
    }

    public class ProductionRemoteControlCar
    {
        public int DistanceTravelled { get; set; }
        public int NumberOfVictories { get; set; }
        public void Drive()
        {
            DistanceTravelled = 10;
        }

    }
    public class ExperimentalRemoteControlCar
    {
        public int DistanceTravelled { get; set; }
        public void Drive()
        {
            DistanceTravelled = 20;
        }
    }
    public static class TestTrack
    {
        public static int Race(IRemoteControlCar car)
        {
            throw new NotImplementedException($"Please implement the (static) TestTrack.Race() method");
        }
        public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
       ProductionRemoteControlCar prc2)
        {
            throw new NotImplementedException($"Please implement the (static) TestTrack.GetRankedCars() method");
        }
    }
    public class InterfacesTests
    {

        public void Race()
        {
            var productionCar = new ProductionRemoteControlCar();
            var experimentalCar = new ExperimentalRemoteControlCar();
            TestTrack.Race((IRemoteControlCar)productionCar);
            TestTrack.Race((IRemoteControlCar)productionCar);
            TestTrack.Race((IRemoteControlCar)experimentalCar);
            TestTrack.Race((IRemoteControlCar)experimentalCar);

        }


        public void RankCars()
        {
            var prc1 = new ProductionRemoteControlCar();
            var prc2 = new ProductionRemoteControlCar();
            prc1.NumberOfVictories = 3;
            prc2.NumberOfVictories = 2;
            var rankings = TestTrack.GetRankedCars(prc1, prc2);
            Console.WriteLine(prc1);

        }


        public void EnsureCarsAreComparable()
        {
            var fast = new ProductionRemoteControlCar();
            var medium = new ProductionRemoteControlCar();
            var slow = new ProductionRemoteControlCar();
            fast.NumberOfVictories = 3;
            medium.NumberOfVictories = 2;
            slow.NumberOfVictories = 1;
            var cars = new List<ProductionRemoteControlCar> { fast, slow, medium };
            cars.Sort();

        }
    }
    class Program
    {
        static void Main()
        {
            ProductionRemoteControlCar prod = new ProductionRemoteControlCar();
            prod.Drive();

            ExperimentalRemoteControlCar exp = new ExperimentalRemoteControlCar();
            exp.Drive();

        }
    }
}
