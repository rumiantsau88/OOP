using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        Pupil [] pupils = new Pupil[4];

        public ClassRoom(Pupil p1,Pupil p2)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }

        public ClassRoom(Pupil p1,Pupil p2,Pupil p3)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = GeneratePupil();
        }

        Random rand = new Random();
        public Pupil GeneratePupil()
        {
            int i = rand.Next(1, 4);
            if(i==1)
            {
                return new ExcellentPupil();
            }
            if (i==2)
            {
                return new GoodPupil();
            }
            if (i==3)
            {
                return new BadPupil();
            }
            else
            {
                return new GoodPupil();
            }
        }
        public void Study()
        {
            foreach (Pupil v  in pupils)
            {
                v.Study();
            }
        }
        public void Write()
        {
            foreach (Pupil v  in pupils)
            {
                v.Write();
            }
        }

        public void Read()
        {
            foreach (Pupil v in pupils)
            {
                v.Read();
            }
        }
        public void Relax()
        {
            foreach (Pupil v in pupils)
            {
                v.Relax();
            }
        }

    }
}
