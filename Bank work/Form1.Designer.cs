namespace Bank_work
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.gbxÖppnaKonto = new System.Windows.Forms.GroupBox();
            this.register = new System.Windows.Forms.Button();
            this.tbxKredit = new System.Windows.Forms.TextBox();
            this.tbxRänta = new System.Windows.Forms.TextBox();
            this.tbxPersonNr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.lbxKonton = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gbxÖppnaKonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxBelopp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.withdraw);
            this.groupBox1.Controls.Add(this.deposit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insättning/Uttag";
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(52, 30);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(167, 20);
            this.tbxBelopp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Belopp";
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(144, 210);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(75, 23);
            this.withdraw.TabIndex = 1;
            this.withdraw.Text = "Uttag";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(144, 181);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(75, 23);
            this.deposit.TabIndex = 0;
            this.deposit.Text = "Insättning";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // gbxÖppnaKonto
            // 
            this.gbxÖppnaKonto.Controls.Add(this.register);
            this.gbxÖppnaKonto.Controls.Add(this.tbxKredit);
            this.gbxÖppnaKonto.Controls.Add(this.tbxRänta);
            this.gbxÖppnaKonto.Controls.Add(this.tbxPersonNr);
            this.gbxÖppnaKonto.Controls.Add(this.label4);
            this.gbxÖppnaKonto.Controls.Add(this.label3);
            this.gbxÖppnaKonto.Controls.Add(this.label2);
            this.gbxÖppnaKonto.Location = new System.Drawing.Point(245, 12);
            this.gbxÖppnaKonto.Name = "gbxÖppnaKonto";
            this.gbxÖppnaKonto.Size = new System.Drawing.Size(239, 247);
            this.gbxÖppnaKonto.TabIndex = 4;
            this.gbxÖppnaKonto.TabStop = false;
            this.gbxÖppnaKonto.Text = "Öppna konto";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(100, 210);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(133, 23);
            this.register.TabIndex = 4;
            this.register.Text = "Registrera";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // tbxKredit
            // 
            this.tbxKredit.Location = new System.Drawing.Point(63, 79);
            this.tbxKredit.Name = "tbxKredit";
            this.tbxKredit.Size = new System.Drawing.Size(170, 20);
            this.tbxKredit.TabIndex = 5;
            // 
            // tbxRänta
            // 
            this.tbxRänta.Location = new System.Drawing.Point(63, 53);
            this.tbxRänta.Name = "tbxRänta";
            this.tbxRänta.Size = new System.Drawing.Size(170, 20);
            this.tbxRänta.TabIndex = 4;
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.Location = new System.Drawing.Point(63, 30);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(170, 20);
            this.tbxPersonNr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kredit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Räntesats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PersonNr";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(490, 222);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(237, 23);
            this.update.TabIndex = 6;
            this.update.Text = "Uppdatera med årsränta";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // lbxKonton
            // 
            this.lbxKonton.FormattingEnabled = true;
            this.lbxKonton.Location = new System.Drawing.Point(490, 16);
            this.lbxKonton.Name = "lbxKonton";
            this.lbxKonton.Size = new System.Drawing.Size(237, 199);
            this.lbxKonton.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 271);
            this.Controls.Add(this.lbxKonton);
            this.Controls.Add(this.update);
            this.Controls.Add(this.gbxÖppnaKonto);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxÖppnaKonto.ResumeLayout(false);
            this.gbxÖppnaKonto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.GroupBox gbxÖppnaKonto;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox tbxKredit;
        private System.Windows.Forms.TextBox tbxRänta;
        private System.Windows.Forms.TextBox tbxPersonNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ListBox lbxKonton;
    }
}

