using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogougolnik
{
	class Figure
	{
		Point[] _point;
		string type;

		public string Type
		{
			get { return type; }
		}

		public double LengthSide(Point A,Point B)
		{
			return Convert.ToDouble(Math.Sqrt(Math.Pow(B.Y - A.Y, 2) + Math.Pow(B.X - B.Y, 2)));
		}

		public void Perim()
		{
			double sum = 0;

			for (int i=0;i<_point.Length-1;i++)
			{
				sum += LengthSide(_point[i], _point[i + 1]);
			}
			sum += LengthSide(_point[_point.Length - 1], _point[0]);
			Console.Write("{0}  {1}",sum,Type);
		}
		public Figure(Point p1,Point p2,Point p3)
		{
			_point= new Point[3];
			_point[0] = p1;
			_point[1] = p2;
			_point[2] = p3;
			type = "treug";
		}
	}
}
