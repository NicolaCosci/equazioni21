using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermired(double a, double b)
        {
            bool risp = true;
            if (a != 0 && b !=0)
            {
                risp = false;
            }

            return risp;

        }
        public static bool IsNotDetermired(double a, double b)
        {
            bool risp = false;
            if (a == 0 && b == 0)
            {
                risp = true;
            }

            return risp;

        }
        public static bool IsImpossible(double b, double a)
        {
            bool risp = false;
            if (b != 0 && a == 0)
            {
                risp = true;
            }

            return risp;
        


        }
        public static bool IsDegree2 (double a, double b,double c)
        {
            bool risp = false;
            if (b != 0 && a == 0 && c!=0)
            {
                risp = false;
            }

            return risp;



        }
    }
}
