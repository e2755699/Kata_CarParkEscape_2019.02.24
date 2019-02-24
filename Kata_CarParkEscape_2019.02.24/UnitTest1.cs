using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private CarParkEscape _carParkEscape;

        [SetUp]
        public void Setup()
        {
            _carParkEscape = new CarParkEscape();
        }

        [Test]
        public void HappyPath()
        {
            GivenParkGarage(new int[,] { { 2, 0, 0 } });
            EscapeShouldBe(new string[] { "R2" });
        }

        [Test]
        public void StartPositionNotAtFarLeftPareSpace()
        {
            GivenParkGarage(new int[,] { { 0, 2, 0 } });
            EscapeShouldBe(new string[] { "R1" });
        }

        private void EscapeShouldBe(string[] expected)
        {
            Assert.AreEqual(expected, _carParkEscape.EscapePath());
        }

        private void GivenParkGarage(int[,] parkGarage)
        {
            _carParkEscape.ParkGarageDiagram(parkGarage);
        }
    }
}