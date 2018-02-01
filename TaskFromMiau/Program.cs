using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromMiau
{
	class Program
	{
		static public void Main(string[] args)
		{
			Console.WriteLine("How many characters you want to get in password?");
			GetPasswordClass pass = new GetPasswordClass(int.Parse(Console.ReadLine()));
			Console.WriteLine(pass.Password);
			Console.ReadKey();

			

		}
	}
}
