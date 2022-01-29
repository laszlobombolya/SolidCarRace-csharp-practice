using System.Collections.Generic;

namespace SolidCarRace
{
    public class Race
    {
        private readonly int numberOfLaps;
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        private readonly List<Car>? cars;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        public Race(int laps, List<Car>? cars)
        {
            this.numberOfLaps = laps;
            this.cars = cars;
        }

        public int CalculateFuel()
        {
            var fuel = 0;

            if (numberOfLaps <= 0 || cars is null)
                return 0;

            foreach (var car in cars)
            {
                if (car is Ford)
                {
                    fuel += 4;
                }
                if (car is Ferrari)
                {
                    fuel += 2;
                }
            }

            
            return fuel * numberOfLaps;
        }
    }
}
