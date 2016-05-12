namespace Thuisadministratie
{
    partial class Beginpagina
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
            this.btnPost = new System.Windows.Forms.Button();
            this.btnInstellingen = new System.Windows.Forms.Button();
            this.btnFactuur = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(12, 12);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(180, 80);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "Post invoeren";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnInstellingen
            // 
            this.btnInstellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstellingen.Location = new System.Drawing.Point(198, 95);
            this.btnInstellingen.Name = "btnInstellingen";
            this.btnInstellingen.Size = new System.Drawing.Size(180, 80);
            this.btnInstellingen.TabIndex = 1;
            this.btnInstellingen.Text = "Instellingen";
            this.btnInstellingen.UseVisualStyleBackColor = true;
            this.btnInstellingen.Click += new System.EventHandler(this.btnInstellingen_Click);
            // 
            // btnFactuur
            // 
            this.btnFactuur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactuur.Location = new System.Drawing.Point(198, 12);
            this.btnFactuur.Name = "btnFactuur";
            this.btnFactuur.Size = new System.Drawing.Size(180, 80);
            this.btnFactuur.TabIndex = 2;
            this.btnFactuur.Text = "Factuur invoeren";
            this.btnFactuur.UseVisualStyleBackColor = true;
            this.btnFactuur.Click += new System.EventHandler(this.btnFactuur_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoeken.Location = new System.Drawing.Point(12, 95);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(180, 80);
            this.btnZoeken.TabIndex = 3;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // Beginpagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 196);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnFactuur);
            this.Controls.Add(this.btnInstellingen);
            this.Controls.Add(this.btnPost);
            this.Name = "Beginpagina";
            this.Text = "Startpagina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnInstellingen;
        private System.Windows.Forms.Button btnFactuur;
        private System.Windows.Forms.Button btnZoeken;
    }
}

