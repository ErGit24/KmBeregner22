using KmBeregner2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmBeregner
{
    public class KilometerBeregner
    {
        private const double PrisOver24Km = 2.16;
        private const int GrænseKilometer = 24;

        private double antalKilometer; 

        public double AntalKilometer
        {
            get { return antalKilometer; }
            set { antalKilometer = value; }
        }

        public double BeregnPris()
        {
            if (AntalKilometer > 120)
            {

                double over120 = AntalKilometer * 1.08;
                

                double tillæg = (AntalKilometer - GrænseKilometer) * PrisOver24Km + over120;


                return tillæg;
            }
            else if (AntalKilometer > GrænseKilometer)
            {
                double tillæg = (AntalKilometer - GrænseKilometer) * PrisOver24Km;
                return tillæg;
            }
            else
            {
                return 0;
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Beregner nyBer = new Beregner();
            nyBer.Start();
        }
    }
}