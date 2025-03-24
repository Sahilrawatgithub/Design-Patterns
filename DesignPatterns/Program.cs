namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OldPrinter oldPrinter = new OldPrinter();
            INewPrinter printer = new PrinterAdapter(oldPrinter);
            printer.Print("hihi");
        }
    }
}
