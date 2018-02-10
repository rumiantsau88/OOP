using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class NewPrinter:Printer
    {
        
        public void PrintScreen(string val)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(val);
            Console.ResetColor();
        }
    }
}
