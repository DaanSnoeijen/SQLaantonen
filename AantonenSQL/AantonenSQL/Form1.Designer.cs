namespace AantonenSQL
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
            this.Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.Wachtwoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Naam = new System.Windows.Forms.Label();
            this.Leeftijd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gebruikersnaam
            // 
            this.Gebruikersnaam.Location = new System.Drawing.Point(136, 12);
            this.Gebruikersnaam.Name = "Gebruikersnaam";
            this.Gebruikersnaam.Size = new System.Drawing.Size(221, 22);
            this.Gebruikersnaam.TabIndex = 0;
            // 
            // Wachtwoord
            // 
            this.Wachtwoord.Location = new System.Drawing.Point(136, 40);
            this.Wachtwoord.Name = "Wachtwoord";
            this.Wachtwoord.Size = new System.Drawing.Size(221, 22);
            this.Wachtwoord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wachtwoord:";
            // 
            // GetAccount
            // 
            this.GetAccount.Location = new System.Drawing.Point(136, 68);
            this.GetAccount.Name = "GetAccount";
            this.GetAccount.Size = new System.Drawing.Size(221, 44);
            this.GetAccount.TabIndex = 4;
            this.GetAccount.Text = "Account ophalen";
            this.GetAccount.UseVisualStyleBackColor = true;
            this.GetAccount.Click += new System.EventHandler(this.GetAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Leeftijd:";
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(458, 15);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(0, 17);
            this.Naam.TabIndex = 7;
            // 
            // Leeftijd
            // 
            this.Leeftijd.AutoSize = true;
            this.Leeftijd.Location = new System.Drawing.Point(458, 40);
            this.Leeftijd.Name = "Leeftijd";
            this.Leeftijd.Size = new System.Drawing.Size(0, 17);
            this.Leeftijd.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 121);
            this.Controls.Add(this.Leeftijd);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GetAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wachtwoord);
            this.Controls.Add(this.Gebruikersnaam);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Gebruikersnaam;
        private System.Windows.Forms.TextBox Wachtwoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label Leeftijd;
    }
}

