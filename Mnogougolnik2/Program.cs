using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogougolnik2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Figure
    {
        Point[] point = new Point();
        public Figure()
        {

        }

         public double Dlina (Point p1,Point p2)
        {
            double perim = Math.Sqrt(Math.Pow(p1.X - p1.Y, 2) - Math.Pow(p2.X - p2.Y, 2));
            return perim;
        }

        public void 
        
    }

    class Point
    {
        public Point(string name,double x,double y)
        {
            this._name = name;
            this._x = x;
            this._y = y;
        }


        private string _name;
        public string Name
        {
            get { return _name; }
        }

        private double _x;
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        private double _y;
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }



    }

    
}
