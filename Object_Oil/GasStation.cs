using System.Globalization;
using System.Text.RegularExpressions;

namespace FuelPriceNamespace
{
    public class GasStation
    {
        public double location_X { get; set; }
        public double location_Y { get; set; }
        public string Name { get; set; }

        public GasStation(double x, double y, string name)
        {
            location_X = x;
            location_Y = y;
            Name = name;
        }

        public static GasStation Parse(string input)
        {
            string[] tokens = Regex.Split(input.Trim(), @"\s+");

            return new GasStation(
                double.Parse(tokens[1], CultureInfo.InvariantCulture),
                double.Parse(tokens[2], CultureInfo.InvariantCulture),
                tokens[3]);
        }
    }
}