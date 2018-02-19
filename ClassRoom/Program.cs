using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new ExcellentPupil();
            Pupil p2 = new GoodPupil();
            ClassRoom _class = new ClassRoom(p1, p2);

            _class.Read();
            _class.Write();
            _class.Relax();
            _class.Study();
            Console.ReadKey();
        }
    }
}
