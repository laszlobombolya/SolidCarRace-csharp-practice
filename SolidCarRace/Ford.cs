namespace SolidCarRace
{
    public class Ford : Car
    {
        private const int Consumption = 4;
        public override int FuelConsumption => Consumption;
    }
}