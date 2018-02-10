using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee instance = new Employee("Uladzimir", "Rumiantsau", 10.5);
            instance.Show();
        }
    }
}
