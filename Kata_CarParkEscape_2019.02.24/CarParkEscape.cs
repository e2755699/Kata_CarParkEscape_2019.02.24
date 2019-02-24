namespace Tests
{
    public class CarParkEscape
    {
        private int[,] _parkGarage;
        private EscapeParkFinder _escapeParkFinder;

        public string[] EscapePath()
        {
            _escapeParkFinder = SetEscapeParkFounder();
            _escapeParkFinder.FindStartParkPlace();
            return _escapeParkFinder.FindExit();
        }

        private EscapeParkFinder SetEscapeParkFounder()
        {
            var escapeParkFounder = new EscapeParkFinder(_parkGarage);
            return escapeParkFounder;
        }

        public void ParkGarageDiagram(int[,] parkGarage)
        {
            _parkGarage = parkGarage;
        }
    }
}