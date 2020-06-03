using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_work
{
    public class Bank
    {
        public List<BankKonto> Konton = new List<BankKonto>();

        public double Behållning
        {
            get
            {
                double behållning = 0;
                foreach (BankKonto konto in Konton) behållning += konto.Behållning;
                return behållning;
            }
        }
    }
}
