namespace Tests
{
    public class CarParkEscape
    {
        private readonly int[,] _parkGarage;

        public CarParkEscape(int[,] parkGarage)
        {
            _parkGarage = parkGarage;
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
    }
}