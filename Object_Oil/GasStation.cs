using System.Globalization;
using System.Text.RegularExpressions;

namespace FuelPriceNamespace
{
    public class GasStation
    {
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public string Name { get; set; }

        public GasStation(double x, double y, string name)
        {
            LocationX = x;
            LocationY = y;
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