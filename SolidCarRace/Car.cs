namespace SolidCarRace
{
    public abstract class Car
    {
        public abstract int FuelConsumption { get; }
        public int CalculateConsumption(int laps) => laps * FuelConsumption;
    }
}