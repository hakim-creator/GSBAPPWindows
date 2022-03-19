namespace GSB
{
    partial class Utilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilisateur));
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxObjet = new System.Windows.Forms.TextBox();
            this.buttonDeclIncident = new System.Windows.Forms.Button();
            this.textBoxNivUrg = new System.Windows.Forms.TextBox();
            this.textBoxDateInterv = new System.Windows.Forms.TextBox();
            this.textBoxZoneInterv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewMessage = new System.Windows.Forms.DataGridView();
            this.buttonAfficherMessage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Déclarer incident :";
            // 
            // textBoxObjet
            // 
            this.textBoxObjet.Location = new System.Drawing.Point(352, 226);
            this.textBoxObjet.Multiline = true;
            this.textBoxObjet.Name = "textBoxObjet";
            this.textBoxObjet.Size = new System.Drawing.Size(261, 96);
            this.textBoxObjet.TabIndex = 13;
            // 
            // buttonDeclIncident
            // 
            this.buttonDeclIncident.Location = new System.Drawing.Point(200, 354);
            this.buttonDeclIncident.Name = "buttonDeclIncident";
            this.buttonDeclIncident.Size = new System.Drawing.Size(281, 33);
            this.buttonDeclIncident.TabIndex = 19;
            this.buttonDeclIncident.Text = "Declarer Incident";
            this.buttonDeclIncident.UseVisualStyleBackColor = true;
            this.buttonDeclIncident.Click += new System.EventHandler(this.buttonDeclIncident_Click);
            // 
            // textBoxNivUrg
            // 
            this.textBoxNivUrg.Location = new System.Drawing.Point(136, 213);
            this.textBoxNivUrg.Name = "textBoxNivUrg";
            this.textBoxNivUrg.Size = new System.Drawing.Size(100, 20);
            this.textBoxNivUrg.TabIndex = 20;
            // 
            // textBoxDateInterv
            // 
            this.textBoxDateInterv.Location = new System.Drawing.Point(136, 253);
            this.textBoxDateInterv.Name = "textBoxDateInterv";
            this.textBoxDateInterv.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateInterv.TabIndex = 21;
            // 
            // textBoxZoneInterv
            // 
            this.textBoxZoneInterv.Location = new System.Drawing.Point(136, 302);
            this.textBoxZoneInterv.Name = "textBoxZoneInterv";
            this.textBoxZoneInterv.Size = new System.Drawing.Size(100, 20);
            this.textBoxZoneInterv.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Niveau d\'urgence :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Zone d\'intervention :";
            // 
            // dataGridViewMessage
            // 
            this.dataGridViewMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessage.Location = new System.Drawing.Point(399, 34);
            this.dataGridViewMessage.Name = "dataGridViewMessage";
            this.dataGridViewMessage.Size = new System.Drawing.Size(269, 84);
            this.dataGridViewMessage.TabIndex = 26;
            // 
            // buttonAfficherMessage
            // 
            this.buttonAfficherMessage.Location = new System.Drawing.Point(441, 140);
            this.buttonAfficherMessage.Name = "buttonAfficherMessage";
            this.buttonAfficherMessage.Size = new System.Drawing.Size(172, 38);
            this.buttonAfficherMessage.TabIndex = 27;
            this.buttonAfficherMessage.Text = "Afficher les messages";
            this.buttonAfficherMessage.UseVisualStyleBackColor = true;
            this.buttonAfficherMessage.Click += new System.EventHandler(this.buttonAfficherMessage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAfficherMessage);
            this.Controls.Add(this.dataGridViewMessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxZoneInterv);
            this.Controls.Add(this.textBoxDateInterv);
            this.Controls.Add(this.textBoxNivUrg);
            this.Controls.Add(this.buttonDeclIncident);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxObjet);
            this.Name = "Utilisateur";
            this.Text = "Utilisateur";
            this.Load += new System.EventHandler(this.Utilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxObjet;
        private System.Windows.Forms.Button buttonDeclIncident;
        private System.Windows.Forms.TextBox textBoxNivUrg;
        private System.Windows.Forms.TextBox textBoxDateInterv;
        private System.Windows.Forms.TextBox textBoxZoneInterv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewMessage;
        private System.Windows.Forms.Button buttonAfficherMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}