using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HappyPath()
        {
            var expected = new string[] { "R2"};

            var carParkEscape = new CarParkEscape(new int[,] { { 2, 0, 0 } });
            Assert.AreEqual(expected, carParkEscape.FindExit());
        }
    }
}