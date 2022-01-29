using NUnit.Framework;
using SolidCarRace;
using System.Collections.Generic;

namespace SolidCarRaceTest
{
    public class Tests
    {
        private static bool hasInstanceOfInCode;

        [SetUp]
        public void Setup()
        {
            hasInstanceOfInCode = false;

        }

        public static IEnumerable<TestCaseData> TwoFordsAndLaps()
        {
            yield return new TestCaseData(-1, 0);
            yield return new TestCaseData(0, 0);
            yield return new TestCaseData(1, 8);
            yield return new TestCaseData(3, 24);
            yield return new TestCaseData(10, 80);
        }

        public static IEnumerable<TestCaseData> TwoFerrariesAndLaps()
        {
            yield return new TestCaseData(-1, 0);
            yield return new TestCaseData(0, 0);
            yield return new TestCaseData(1, 4);
            yield return new TestCaseData(3, 12);
            yield return new TestCaseData(10, 40);
        }
        public static IEnumerable<TestCaseData> TwoFromBothAndLaps()
        {
            yield return new TestCaseData(-1, 0);
            yield return new TestCaseData(0, 0);
            yield return new TestCaseData(1, 12);
            yield return new TestCaseData(3, 36);
            yield return new TestCaseData(10, 120);
        }


        [Test]
        [TestCaseSource("TwoFerrariesAndLaps")]
        public void calculateFuel_worksForFerrariOneLap(int laps, int expected)
        {
            var ferraries = new List<Car> {new Ferrari(), new Ferrari()};
            var race = new Race(laps, ferraries);

            var actual = race.CalculateFuel();

            Assert.AreEqual(expected, actual);

        }

        [Test]
        [TestCaseSource("TwoFordsAndLaps")]
        public void calculateFuel_worksForFordOneLap(int laps, int expected)
        {
            var fords = new List<Car> { new Ford(), new Ford() };
            var race = new Race(laps, fords);

            var actual = race.CalculateFuel();

            Assert.AreEqual(expected, actual);

        }

        [Test]
        [TestCaseSource("TwoFromBothAndLaps")]
        public void calculateFuel_worksForBothOneLap(int laps, int expected)
        {
            var cars = new List<Car>(){
                    new Ferrari(),
                    new Ferrari(),
                    new Ford(),
                    new Ford(),
            };
            var race = new Race(laps, cars);

            var actual = race.CalculateFuel();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void calculateFuel_worksForNull()
        {
            int expected = 0;
            int laps = 1;
            List<Car> cars = null;
            var race = new Race(laps, cars);

            var actual = race.CalculateFuel();
            Assert.AreEqual(expected, actual);
        }
    }

}