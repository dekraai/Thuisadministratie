namespace Thuisadministratie
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDocument = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.voorWie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOnderwerp = new System.Windows.Forms.TextBox();
            this.tbKenmerk = new System.Windows.Forms.TextBox();
            this.dtBinnen = new System.Windows.Forms.DateTimePicker();
            this.cbVoorWie = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbBedrijf = new System.Windows.Forms.ComboBox();
            this.btnNieuwBedrijf = new System.Windows.Forms.Button();
            this.btnNieuwCategorie = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(120, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(115, 25);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document";
            // 
            // tbDocument
            // 
            this.tbDocument.Enabled = false;
            this.tbDocument.Location = new System.Drawing.Point(10, 55);
            this.tbDocument.Name = "tbDocument";
            this.tbDocument.Size = new System.Drawing.Size(225, 20);
            this.tbDocument.TabIndex = 30;
            // 
            // voorWie
            // 
            this.voorWie.AutoSize = true;
            this.voorWie.Location = new System.Drawing.Point(10, 80);
            this.voorWie.Name = "voorWie";
            this.voorWie.Size = new System.Drawing.Size(48, 13);
            this.voorWie.TabIndex = 3;
            this.voorWie.Text = "Voor wie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum binnenkomst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bedrijf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Onderwerp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kenmerk";
            // 
            // tbOnderwerp
            // 
            this.tbOnderwerp.Location = new System.Drawing.Point(120, 180);
            this.tbOnderwerp.Name = "tbOnderwerp";
            this.tbOnderwerp.Size = new System.Drawing.Size(115, 20);
            this.tbOnderwerp.TabIndex = 14;
            // 
            // tbKenmerk
            // 
            this.tbKenmerk.Location = new System.Drawing.Point(120, 205);
            this.tbKenmerk.Name = "tbKenmerk";
            this.tbKenmerk.Size = new System.Drawing.Size(115, 20);
            this.tbKenmerk.TabIndex = 16;
            // 
            // dtBinnen
            // 
            this.dtBinnen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBinnen.Location = new System.Drawing.Point(120, 105);
            this.dtBinnen.Name = "dtBinnen";
            this.dtBinnen.Size = new System.Drawing.Size(115, 20);
            this.dtBinnen.TabIndex = 8;
            // 
            // cbVoorWie
            // 
            this.cbVoorWie.FormattingEnabled = true;
            this.cbVoorWie.Location = new System.Drawing.Point(120, 80);
            this.cbVoorWie.Name = "cbVoorWie";
            this.cbVoorWie.Size = new System.Drawing.Size(115, 21);
            this.cbVoorWie.TabIndex = 6;
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(120, 130);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(115, 21);
            this.cbCat.TabIndex = 10;
            // 
            // cbBedrijf
            // 
            this.cbBedrijf.FormattingEnabled = true;
            this.cbBedrijf.Location = new System.Drawing.Point(120, 155);
            this.cbBedrijf.Name = "cbBedrijf";
            this.cbBedrijf.Size = new System.Drawing.Size(115, 21);
            this.cbBedrijf.TabIndex = 12;
            // 
            // btnNieuwBedrijf
            // 
            this.btnNieuwBedrijf.Location = new System.Drawing.Point(10, 230);
            this.btnNieuwBedrijf.Name = "btnNieuwBedrijf";
            this.btnNieuwBedrijf.Size = new System.Drawing.Size(105, 25);
            this.btnNieuwBedrijf.TabIndex = 22;
            this.btnNieuwBedrijf.Text = "Nieuw Bedrijf";
            this.btnNieuwBedrijf.UseVisualStyleBackColor = true;
            // 
            // btnNieuwCategorie
            // 
            this.btnNieuwCategorie.Location = new System.Drawing.Point(120, 230);
            this.btnNieuwCategorie.Name = "btnNieuwCategorie";
            this.btnNieuwCategorie.Size = new System.Drawing.Size(115, 25);
            this.btnNieuwCategorie.TabIndex = 24;
            this.btnNieuwCategorie.Text = "Nieuw Categorie";
            this.btnNieuwCategorie.UseVisualStyleBackColor = true;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpslaan.Location = new System.Drawing.Point(49, 283);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(146, 61);
            this.btnOpslaan.TabIndex = 20;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 200);
            this.textBox1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Opmerkingen";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(480, 55);
            this.axAcroPDF1.MaximumSize = new System.Drawing.Size(700, 1000);
            this.axAcroPDF1.MinimumSize = new System.Drawing.Size(200, 300);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(300, 450);
            this.axAcroPDF1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Preview";
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnNieuwCategorie);
            this.Controls.Add(this.btnNieuwBedrijf);
            this.Controls.Add(this.cbBedrijf);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.cbVoorWie);
            this.Controls.Add(this.dtBinnen);
            this.Controls.Add(this.tbKenmerk);
            this.Controls.Add(this.tbOnderwerp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voorWie);
            this.Controls.Add(this.tbDocument);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Post";
            this.Text = "Post";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDocument;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label voorWie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOnderwerp;
        private System.Windows.Forms.TextBox tbKenmerk;
        private System.Windows.Forms.DateTimePicker dtBinnen;
        private System.Windows.Forms.ComboBox cbVoorWie;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.ComboBox cbBedrijf;
        private System.Windows.Forms.Button btnNieuwBedrijf;
        private System.Windows.Forms.Button btnNieuwCategorie;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label label8;
    }
}