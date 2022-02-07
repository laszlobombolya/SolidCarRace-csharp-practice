namespace SolidCarRace
{
    public class Ferrari : Car
    {
        private const int Consumption = 2;
        public override int FuelConsumption => Consumption;
    }
}