using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_work
{
    public partial class Form1 : Form
    {
        private Bank bank = new Bank();

        public Form1()
        {
            InitializeComponent();
        }

        private void UppdateraKontoLista()
        {
            lbxKonton.Items.Clear();
            foreach (BankKonto konto in bank.Konton) lbxKonton.Items.Add(konto);
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            if (lbxKonton.SelectedItem != null)
            {
                double belopp;
                if (! double.TryParse(tbxBelopp.Text, out belopp))
                {
                    MessageBox.Show("Felaktigt belopp", Text);
                    return;
                }
                (lbxKonton.SelectedItem as BankKonto).Insättning(belopp);
                UppdateraKontoLista();
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {

        }

        private void accountList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
