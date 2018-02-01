using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromMiau
{
	class GetPasswordClass
	{
		string _password;
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		public string GetPassword(int j)
		{
			Random rand = new Random();
			string s = null;
			
			for (int i = 0; i < j; i++)
			{
				s += Convert.ToChar(rand.Next(97, 121)).ToString();
			}
			return s;
		}

		public GetPasswordClass(int i)
		{
			_password= GetPassword(i);
		}

	}
}
