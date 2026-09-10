using FuelPriceNamespace;

class Program
{
    static void Main()
    {
        List<FuelPrice> oils = [];
        List<GasStation> stations = [];

        foreach (string line in File.ReadLines("input.txt"))
        {
            string[] data = line.Split();

            if (data[0] == "OIL") 
            {
                oils.Add(FuelPrice.Parse(line));
            }
                
            else if (data[0] == "GASSTATION")
            {
                stations.Add(GasStation.Parse(line));
            }
        }

        foreach (FuelPrice oil in oils)
            Console.WriteLine($"{oil.FuelType} {oil.Date:yyyy.MM.dd} {oil.Price}");

        foreach (GasStation station in stations)
            Console.WriteLine(
                $"{station.Name} {station.LocationX} {station.LocationY}");
    }
}