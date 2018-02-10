using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "blablabla";
            Printer inst = new Printer();
            inst.PrintScreen(val);
            NewPrinter inst2 = new NewPrinter();
            inst2.PrintScreen(val);
            Printer up = inst2 as Printer;
            up.PrintScreen(val);
            NewPrinter down = up as NewPrinter;
            down.PrintScreen(val);


            Console.ReadKey();
            
        }
    }
}
