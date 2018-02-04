using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class GetData
    {
        public readonly DateTime _date;// datetime value
        private string _login;

        public string Login
        {
            get
            {
                if ( _login == null)
                    return "Value is null";
                return _login;
            }
            set { _login = value; }
        }

        private string _password;

        public string Password
        {
            get
            {
                if (_password == null)
                {
                    return "Value is null";
                }
                else
                {
                    return _password; 
                }
            }
            set { _password = value; }
        }

        private string _age;

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void GetLogin()
        {
            Console.WriteLine("Enter your login");
             this.Login = Console.ReadLine();
        }

        public void GetPassword()
        {
            Console.WriteLine("Enter your password:");
             this.Password = Console.ReadLine();
            
        }

        public void GetAge()
        {
            Console.WriteLine("Enter your age:");
             this.Age = Console.ReadLine();
        }

        

        public GetData()
        {
            this.GetLogin();
            this.GetPassword();
            this.GetAge();
            this._date = DateTime.Now;
        }
    }
}
