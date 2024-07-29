using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehiculo
    {
        private int gasoline;
        public Car(int startingGasoline)
        {
            gasoline = startingGasoline;
        }

        public void Drive()
        {
            if(gasoline > 0)
            {
                Console.WriteLine("Driving");
                gasoline--;
            }
            else
            {
                Console.WriteLine("Cannot Drive, No Gasoline");
            }
            
        }
        public bool Refuel(int amount)
        {
            if (amount > 0)
            {
                gasoline+=amount;
                return true;
            }
            return false;
        }
    }
    internal class VehicleFuel
    {
        static void Main()
        {
            Car car = new Car(0);

        }
    }
}
