namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            Singleton s2 = Singleton.GetInstance;

            s1.PrintMessage("hi");
            s2.PrintMessage("hello");
        }
    }
}
