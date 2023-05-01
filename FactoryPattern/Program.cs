using FactoryPattern;

namespace FactoryPatternVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfWheels;
            bool input = false;
            do

            {
                Console.WriteLine("Enter the amount of tires for the vehicle you want to create.");

                input = int.TryParse(Console.ReadLine(), out amountOfWheels);
            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(amountOfWheels);
            vehicle.Build();

        }
    }
}
