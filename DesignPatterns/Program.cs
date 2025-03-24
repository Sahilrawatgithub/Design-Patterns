namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder builder = new SportsCarBuilder();
            Director director = new Director(builder);

            director.ConstructSportsCar();

            Car sportsCar = director.GetCar();
            Console.WriteLine(sportsCar);
        }
    }
}
