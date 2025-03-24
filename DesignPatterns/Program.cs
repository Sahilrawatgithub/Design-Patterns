namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter vehicle type : ");
            string vehicle=Console.ReadLine();

            IVehicle vehicle1 = VehicleFactory.GetVehicle(vehicle);
            Console.WriteLine(vehicle1.vehicletype());
            Console.WriteLine(vehicle1.wheels());
        }
    }
}
