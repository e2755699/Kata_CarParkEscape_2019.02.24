using System;

namespace Tests
{
    public class CarParkEscape
    {
        private int[,] _parkGarage;

        public CarParkEscape()
        {
        }

        public string[] EscapePath()
        {
            return FindExit(FindStartParkPlace());
        }

        private int FindStartParkPlace()
        {
            for (var position = 0; position < ParkGarageLength; position++)
            {
                if (_parkGarage[0, position] == 2)
                {
                    return position;
                }
            }
            throw new ArgumentException($"Can't find start park place");
        }

        private int ParkGarageLength => _parkGarage.Length - 1;

        private string[] FindExit(int startParkPlace)
        {
            var move = 0;
            for (var position = startParkPlace; position < ParkGarageLength; position++)
            {
                move++;
            }
            return new[] { $"R{move}" };
        }

        public void ParkGarageDiagram(int[,] parkGarage)
        {
            _parkGarage = parkGarage;
        }
    }
}