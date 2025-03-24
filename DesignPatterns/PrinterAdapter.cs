using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class PrinterAdapter:INewPrinter
    {
        private readonly OldPrinter Oldprinter;

        public PrinterAdapter(OldPrinter oldprinter)
        {
            this.Oldprinter = oldprinter;
        }
        public void Print(string message)
        {
            Oldprinter.PrintDocument(message);
        }
    }
}
