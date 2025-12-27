using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Transport
    {
        protected double speed;
        protected double costPerKm;
        protected int passengerCapacity;
        protected double cargoCapacity;

        public Transport(double speed, double costPerKm, int passengerCapacity, double cargoCapaciity)
        {
            this.speed = speed;
            this.cargoCapacity = cargoCapaciity;
            this.passengerCapacity = passengerCapacity;
            this.costPerKm = costPerKm;
        }

        public abstract double GetTime(double distance);
        public abstract double GetCost(double distance, int passengers, double cargo);

       
    }
}
