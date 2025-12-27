namespace p511_oop
{
    class Car : Transport
    {
        public Car() : base(80, 15, 4, 0.5)
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