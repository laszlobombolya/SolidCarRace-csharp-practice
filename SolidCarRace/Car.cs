namespace SolidCarRace
{
    public abstract class Car
    {
        protected int FuelConsumption { get; set; }

        public int GetFuelConsumption()
        {
            return FuelConsumption;
        }
    }
}