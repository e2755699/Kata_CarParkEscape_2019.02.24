namespace Tests
{
    public class CarParkEscape
    {
        private int[,] _parkGarage;

        public CarParkEscape()
        {
        }

        public string[] FindExit()
        {
            var move = 0;
            for (var position = 1; position < _parkGarage.Length; position++)
            {
                move++;
            }
            return new[] { $"R{move}" };
        }

        public void ParkGarageDaigram(int[,] parkGarage)
        {
            _parkGarage = parkGarage;
        }
    }
}