using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ExcellentPupil : Pupil
    {
        public ExcellentPupil()
        {

        }
        public override void Read()
        {
            Console.WriteLine("ExclellentPupil.Read()");
        }

        public override void Relax()
        {
            Console.WriteLine("ExcellentPupil.Relax()");
        }

        public override void Study()
        {
            Console.WriteLine("ExcellentPupil.Study()");
        }

        public override void Write()
        {
            Console.WriteLine("ExcellentPupil.Write()");
        }
    }




    class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("GoodPupil.Read()");
        }

        public override void Relax()
        {
            Console.WriteLine("GoodPupil.Relax()");
        }

        public override void Study()
        {
            Console.WriteLine("GoodPupil.Study()");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil.Write()");
        }
    }




    class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("BadPupil.Read()");
        }

        public override void Relax()
        {
            Console.WriteLine("BadPupil.Relax()");
        }

        public override void Study()
        {
            Console.WriteLine("BadPupil.Study()");
        }

        public override void Write()
        {
            Console.WriteLine("BadPupil.Write()");
        }
    }

    class Pupil
    {
        public virtual void Write()    
        {
            Console.WriteLine("Pupil.Write()");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil.Read()");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil.Relax");
        }

        public virtual void Study()
        {
            Console.WriteLine("Pupil.Study()");
        }

        //**********************************************************************************************************************




        
    }
}
