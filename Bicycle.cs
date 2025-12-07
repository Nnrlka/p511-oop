namespace p511_oop
{
    class Bicycle : Transport
    {
        public Bicycle() : base(10, 1, 4, 0)
        {

        }

        public Bicycle(double speed, double costPerKm, int passengerCapacity, double cargoCapaciity) : base(speed, costPerKm, passengerCapacity, cargoCapaciity)
        {
        }

        public override double GetTime(double distance)
        {
            return distance / speed;
        }
        public override double GetCost(double distance, int passengers, double cargo)
        {
            return (distance / costPerKm) + (passengers * 100) + (cargo + 500);
        }

    }
}