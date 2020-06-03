using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_work
{
    public class LåneKonto : BankKonto
    {
        protected double kredit = 0;

        public LåneKonto(string personNr, double ränteSats, double kredit) : base(personNr, ränteSats)
        {
            this.kredit = kredit;
        }

        public override bool Uttag(double belopp)
        {
            if (belopp <= behållning + kredit)
            {
                behållning -= belopp;
                return true;
            }
            else return false;
        }

        public override double BeräknaRänta()
        {
            double ränta = 0;
            if (behållning < 0)
            {
                ränta = behållning * ränteSats / 100;
                behållning += ränta;
            }
            return ränta;
        }

        public override string ToString()
        {
            return "Lånekonto " + personNr + ":´" + behållning;
        }
    }
}
