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
            pupils[2] = GetPupil();
            pupils[3] = GetPupil();
        }

        public ClassRoom(Pupil p1,Pupil p2,Pupil p3)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = GetPupil();
        }

        Random rand = new Random();
        public Pupil GetPupil()
        {
            int i = rand.Next(1, 4);
            if(i==1)
            {
                return new ExcellentPupil();
            }
            if (true)
            {

            }
        }

    }
}
