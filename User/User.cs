using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {

        GetData _get = new GetData();    
        public void ShowData()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Login:");
            Console.ResetColor();
            Console.WriteLine(_get.Login);
            Console.WriteLine(new string('*',40));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Passw0rd:");
            Console.ResetColor();
            Console.WriteLine(_get.Password);
            Console.WriteLine(new string('*', 40));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Age:");
            Console.ResetColor();
            Console.WriteLine(_get.Age);
            Console.WriteLine(new string('*', 40));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Date of making account:");
            Console.ResetColor();
            Console.WriteLine(_get._date);
        }
        public User()
        {
            
        }
    }
}
