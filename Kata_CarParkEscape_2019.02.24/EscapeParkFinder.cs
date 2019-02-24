using System;

namespace Tests
{
    public class EscapeParkFinder
    {
        private int[,] _parkGarage;
        private int _startParkPlace;

        public EscapeParkFinder(int[,] parkGarage)
        {
            _parkGarage = parkGarage;
        }

        public void ParkGarageDiagram(int[,] parkGarage)
        {
            _parkGarage = parkGarage;
        }

        public void FindStartParkPlace()
        {
            for (var position = 0; position < _parkGarage.Length - 1; position++)
            {
                if (_parkGarage[0, position] == 2)
                {
                    _startParkPlace = position;
                    return;
                }
            }
            throw new ArgumentException($"Can't find start park place");
        }

        public string[] FindExit()
        {
            var move = 0;
            for (var position = _startParkPlace; position < _parkGarage.Length - 1; position++)
            {
                move++;
            }
            return new[] { $"R{move}" };
        }
    }
}