namespace GSB
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonResponsable = new System.Windows.Forms.Button();
            this.buttonTechnicien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(109, 288);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(114, 31);
            this.buttonConnexion.TabIndex = 2;
            this.buttonConnexion.Text = "Utilisateur";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonResponsable
            // 
            this.buttonResponsable.Location = new System.Drawing.Point(249, 288);
            this.buttonResponsable.Name = "buttonResponsable";
            this.buttonResponsable.Size = new System.Drawing.Size(128, 31);
            this.buttonResponsable.TabIndex = 6;
            this.buttonResponsable.Text = "Responsable";
            this.buttonResponsable.UseVisualStyleBackColor = true;
            this.buttonResponsable.Click += new System.EventHandler(this.buttonResponsable_Click);
            // 
            // buttonTechnicien
            // 
            this.buttonTechnicien.Location = new System.Drawing.Point(414, 288);
            this.buttonTechnicien.Name = "buttonTechnicien";
            this.buttonTechnicien.Size = new System.Drawing.Size(135, 33);
            this.buttonTechnicien.TabIndex = 7;
            this.buttonTechnicien.Text = "Technicien";
            this.buttonTechnicien.UseVisualStyleBackColor = true;
            this.buttonTechnicien.Click += new System.EventHandler(this.buttonTechnicien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Veuillez choisir  votre domaine :";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTechnicien);
            this.Controls.Add(this.buttonResponsable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonConnexion);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonResponsable;
        private System.Windows.Forms.Button buttonTechnicien;
        private System.Windows.Forms.Label label3;
    }
}