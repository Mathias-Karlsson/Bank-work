using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_work
{
    public class SparKonto : BankKonto
    {
        public SparKonto(string personNr, double ränteSats) : base(personNr, ränteSats)
        {

        }

        public override bool Uttag(double belopp)
        {
            if (belopp <= behållning)
            {
                behållning -= belopp;
                return true;
            }
            else return false;
        }

        public override double BeräknaRänta()
        {
            double ränta = behållning * ränteSats / 100;
            behållning += ränta;
            return ränta;
        }

        public override string ToString()
        {
            return "Sparkonto " + personNr + ": " + behållning;
        }
    }
}
