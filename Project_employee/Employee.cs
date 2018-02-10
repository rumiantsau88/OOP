using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_employee
{
    class Employee
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _stazh;

        public double Stazh
        {
            get { return _stazh; }
            set { _stazh = value; }
        }


        private string _familiya;

        public string Familiya
        {
            get { return _familiya; }
            set { _familiya = value; }
        }

        public Employee(string name, string fam, double stazh)
        {
            Familiya = fam;
            Name = name;
            Stazh = stazh;
        }

        public double RasZarplata(double stazh)
        {
            double zar;
            zar = 300.0 + (300.0*(stazh*0.05)) ;
            return zar;
        }
        public void Show()
        {
            Console.WriteLine("\tName:{0}\n\tSurname:{1}\n\tStazh:{2}\n\tZarplata:{3}",Name,Familiya,Stazh,Convert.ToString(RasZarplata(Stazh)));
            Console.ReadKey();
        }
    }
}
