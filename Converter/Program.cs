using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {

        static void Main(string[] args)
        {
            double _usd, _eur, _rub;
            int count;
            SetCourses();
                Converter conv = new Converter(_usd, _eur, _rub,count);
            
             int ChooseCovert()
            {
                int _choose;
                Console.Clear();
                Console.WriteLine("Choose the direction of conversion");
                Console.WriteLine(new string('#', 50));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1.UAH->USD");
                Console.WriteLine("2.UAH->EUR");
                Console.WriteLine("3.UAH->RUB");
                Console.WriteLine(new string('#', 50));
                Console.ResetColor();
                return _choose = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            void SetCourses()
            {
                double[] arrayconv = new double[3];
                 int i = 0;

                Console.WriteLine("Enter UAH=>USD");
                arrayconv[i] = double.Parse(Console.ReadLine());
                _usd = arrayconv[i];
                i++;
                Console.WriteLine(new string('=', 50));

                Console.WriteLine("Enter UAH=>EUR");
                arrayconv[i] = double.Parse(Console.ReadLine());
                _eur = arrayconv[i];
                i++;
                Console.WriteLine(new string('=', 50));


                Console.WriteLine("Enter UAH=>RUB");
                arrayconv[i] = double.Parse(Console.ReadLine());
                _rub = arrayconv[i];
                i++;
                
                i = ChooseCovert();
                count = i;
            }
            
        }

        
    }
}
