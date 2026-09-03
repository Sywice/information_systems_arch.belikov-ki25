class Programm
{
    static void Main()
    {
        string line = Console.ReadLine();
        FuelPrice Fuel = FuelPrice.Parse(line);
        Console.WriteLine($"{Fuel.FuelType} {Fuel.Date:yyyy.MM.dd} {Fuel.Price}");
    }
}