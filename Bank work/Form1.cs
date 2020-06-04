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

        /// <summary>
        /// UppdateraKontoLista är en kommand som uppdateras på varje button press och uppdaterar lbxKonton
        /// </summary>
        private void UppdateraKontoLista()
        {
            lbxKonton.Items.Clear();
            foreach (BankKonto konto in bank.Konton) lbxKonton.Items.Add(konto);
        }

        /// <summary>
        /// Deposit button lägger in hur mycket i konton som du har valt och plusar ihop med vad det har just nu med det nya
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Withdraw button tar ut ett viss antal från konton som du har valt men kan inte går mindre än 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void withdraw_Click(object sender, EventArgs e)
        {
            if (lbxKonton.SelectedItem != null)
            {
                double belopp;
                if (! double.TryParse(tbxBelopp.Text, out belopp))
                {
                    MessageBox.Show("Felaktigt belopp", Text);
                    return;
                }
                if ((lbxKonton.SelectedItem as BankKonto).Uttag(belopp) == false)
                    MessageBox.Show("Medges ej", Text);
                else UppdateraKontoLista();
            }
        }

        private void accountList_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Register button lägger in personNr, ränteSats och kredit i lbxKonton som Sparkonto eller Lånekonto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void register_Click(object sender, EventArgs e)
        {
            double ränteSats;
            if (! double.TryParse(tbxRänta.Text, out ränteSats))
            {
                MessageBox.Show("Felaktigt räntesats", Text);
                return;
            }

            double kredit;
            if (! double.TryParse(tbxKredit.Text, out kredit))
            {
                MessageBox.Show("Felaktigt kredit", Text);
                return;
            }

            BankKonto nyttKonto;
            if (kredit == 0) nyttKonto = new SparKonto(tbxPersonNr.Text, ränteSats);
            else nyttKonto = new LåneKonto(tbxPersonNr.Text, ränteSats, kredit);

            bank.Konton.Add(nyttKonto);
            lbxKonton.Items.Add(nyttKonto);

            foreach (Control kontroll in gbxÖppnaKonto.Controls)
                if (kontroll is TextBox) (kontroll as TextBox).Clear();
        }

        /// <summary>
        /// Update button uppdaterar listan i lbxKonton med vad soms finns i listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_Click(object sender, EventArgs e)
        {
            foreach (BankKonto konto in bank.Konton)
            {
                konto.BeräknaRänta();
            }
            UppdateraKontoLista();
        }
    }
}
