using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("bus");
        string vehicleType = Console.ReadLine().ToLower();


        Console.WriteLine("5");
        double duration = double.Parse(Console.ReadLine());

        
        double hourlyRate, totalFee;
        switch (vehicleType)
        {
            case "taxi":
                hourlyRate = duration > 1 ? 5.0 * 1.2 : 5.0;
                totalFee = hourlyRate * duration;
                break;
            case "bus":
                hourlyRate = duration > 1 ? 6.0 * 1.215 : 6.0;
                totalFee = hourlyRate * duration;
                break;
            case "truck":
                hourlyRate = duration > 1 ? 6.5 * 1.25 : 6.5;
                totalFee = hourlyRate * duration;
                break;
            default:
                Console.WriteLine("bus");
                return;
        }

        
        Console.WriteLine("Parking fee: {0} AZN", totalFee);
    }
}
