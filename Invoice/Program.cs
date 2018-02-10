using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(2484998, "Rumiantsau", "Comps&Gadgets") { Article = "notebook", Quantity = 1 };
            inv.SummArticle(false);
            Console.WriteLine(new string('&',50));
            inv.SummArticle(true);
            Console.ReadKey();

        }
    }
}
