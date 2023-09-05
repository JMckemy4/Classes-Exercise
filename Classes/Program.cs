using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Subaru";
            car1.Model = "WRX";
            car1.Year = 2021;

            Console.WriteLine($"My car is {car1.Year} {car1.Make} {car1.Model}");

        }
    }
}
