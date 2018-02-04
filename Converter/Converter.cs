using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        double _usd, _eur, _rub;
        public double Usd { get => _usd; set => _usd = value; }
        public double Eur { get => _eur; set => _eur = value; }
        public double Rub { get => _rub; set => _rub = value; }
        private int _choose;            

        public int Choose
        {
            get { return _choose; }
            set { _choose = value; }
        }


        public Converter(double usd, double eur, double rub,int choose)
        {
            this.Eur = eur;
            this.Usd = usd;
            this.Rub = rub;
            this._choose = choose;
            CurrencyExchange();
        }
        
        void CurrencyExchange()
        {
            Console.WriteLine("Enter value of currency UAH:");
            double uah = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter value of another currency:);

            if (Choose==1)
            {
                Console.WriteLine("UAH=>USD:{0}",(uah/10)*Usd);
            }
            else if (Choose==2)
            {
                Console.WriteLine("UAH=>EUR:{0}", (uah/10) * Eur);
            }
            else
            {
                Console.WriteLine("UAH=>USD:{0}", uah * (Rub*10));
            }

            Console.ReadKey();
        }
        
    }
}
