﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogougolnik
{
	class Program
	{
		static void Main(string[] args)
		{
			Figure figure = new Figure(new Point("A", 1, 4), new Point("B", 2, 6), new Point("c", 5, 7));
			figure.Perim();
			Console.ReadKey();
		}
	}
}
