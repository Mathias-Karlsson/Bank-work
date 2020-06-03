using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_work
{
    public abstract class BankKonto
    {
        protected string personNr = "";
        protected double behållning = 0;
        protected double ränteSats = 0;

        public BankKonto(string personNr, double ränteSats)
        {
            this.personNr = personNr;
            this.ränteSats = ränteSats;
        }

        public double Behållning
        {
            get { return this.behållning; }
            set { this.behållning = value; }
        }

        public void Insättning(double belopp)
        {
            this.behållning += belopp;
        }
        public abstract bool Uttag(double belopp);
        public abstract double BeräknaRänta();
    }
}
