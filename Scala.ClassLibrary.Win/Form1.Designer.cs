namespace Scala.ClassLibrary.Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPersonen = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblGeboortedatum = new System.Windows.Forms.Label();
            this.lblGeslacht = new System.Windows.Forms.Label();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPersonen
            // 
            this.lstPersonen.FormattingEnabled = true;
            this.lstPersonen.ItemHeight = 15;
            this.lstPersonen.Location = new System.Drawing.Point(24, 21);
            this.lstPersonen.Name = "lstPersonen";
            this.lstPersonen.Size = new System.Drawing.Size(251, 379);
            this.lstPersonen.TabIndex = 0;
            this.lstPersonen.SelectedIndexChanged += new System.EventHandler(this.LstPersonen_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblLeeftijd);
            this.groupBox1.Controls.Add(this.lblGeslacht);
            this.groupBox1.Controls.Add(this.lblGeboortedatum);
            this.groupBox1.Controls.Add(this.lblVoornaam);
            this.groupBox1.Controls.Add(this.lblNaam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(303, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voornaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geboortedatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geslacht";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Leeftijd";
            // 
            // lblNaam
            // 
            this.lblNaam.BackColor = System.Drawing.Color.Linen;
            this.lblNaam.Location = new System.Drawing.Point(118, 26);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(322, 24);
            this.lblNaam.TabIndex = 5;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.BackColor = System.Drawing.Color.Linen;
            this.lblVoornaam.Location = new System.Drawing.Point(118, 58);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(322, 24);
            this.lblVoornaam.TabIndex = 6;
            // 
            // lblGeboortedatum
            // 
            this.lblGeboortedatum.BackColor = System.Drawing.Color.Linen;
            this.lblGeboortedatum.Location = new System.Drawing.Point(118, 91);
            this.lblGeboortedatum.Name = "lblGeboortedatum";
            this.lblGeboortedatum.Size = new System.Drawing.Size(322, 24);
            this.lblGeboortedatum.TabIndex = 7;
            // 
            // lblGeslacht
            // 
            this.lblGeslacht.BackColor = System.Drawing.Color.Linen;
            this.lblGeslacht.Location = new System.Drawing.Point(118, 124);
            this.lblGeslacht.Name = "lblGeslacht";
            this.lblGeslacht.Size = new System.Drawing.Size(322, 24);
            this.lblGeslacht.TabIndex = 8;
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.BackColor = System.Drawing.Color.Linen;
            this.lblLeeftijd.Location = new System.Drawing.Point(118, 162);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(322, 24);
            this.lblLeeftijd.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPersonen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstPersonen;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label lblNaam;
        private Label label5;
        private Label lblLeeftijd;
        private Label lblGeslacht;
        private Label lblGeboortedatum;
        private Label lblVoornaam;
    }
}