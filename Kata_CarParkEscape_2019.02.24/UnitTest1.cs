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

        private void EscapeShouldBe(string[] expected)
        {
            Assert.AreEqual(expected, _carParkEscape.FindExit());
        }

        private void GivenParkGarage(int[,] parkGarage)
        {
            _carParkEscape.ParkGarageDaigram(parkGarage);
        }
    }
}