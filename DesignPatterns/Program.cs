namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Factory Type: Regular / Luxury");
            string factoryChoice = Console.ReadLine();

            IVehicleFactory vehicleFactory;

            if (factoryChoice.Equals("Regular", StringComparison.OrdinalIgnoreCase))
            {
                vehicleFactory = new RegularVehicleFactory();
            }
            else if (factoryChoice.Equals("Luxury", StringComparison.OrdinalIgnoreCase))
            {
                vehicleFactory = new LuxuryVehicleFactory();
            }
            else
            {
                Console.WriteLine("Invalid factory type!");
                return;
            }

            Console.WriteLine("\nWhich vehicle do you want to create? Bike / Car");
            string vehicleType = Console.ReadLine();

            IVehicle vehicle = null;

            if (vehicleType.Equals("Bike", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = vehicleFactory.CreateBike();
            }
            else if (vehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = vehicleFactory.CreateCar();
            }
            else
            {
                Console.WriteLine("Invalid vehicle type!");
                return;
            }

            Console.WriteLine("Vehicle Created!");
            Console.WriteLine(vehicle.VehicleType());
            Console.WriteLine("Number of wheels: " + vehicle.Wheels());
        }
    }
}
