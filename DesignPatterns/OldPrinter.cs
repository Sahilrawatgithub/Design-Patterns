using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class OldPrinter
    {
        public void PrintDocument(string text)
        {
            Console.WriteLine("Printing from old printer "+text);
        }
    }
}
