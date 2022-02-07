using System.Collections.Generic;
using System.Linq;

namespace SolidCarRace
{
    public class Race
    {
        private readonly int _numberOfLaps;
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        private readonly List<Car>? _cars;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        public Race(int laps, List<Car> cars)
        {
            _numberOfLaps = laps <= 0 ? 0 : laps;
            _cars = cars;
        }

        public int CalculateFuel()
        {
            var overallConsumption = _cars?.Sum(car => car.CalculateConsumption(_numberOfLaps));
            return overallConsumption ?? 0;
        }
    }
}
