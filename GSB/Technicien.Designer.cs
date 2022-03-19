namespace GSB
{
    partial class Technicien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technicien));
            this.textBoxTypeMateriel = new System.Windows.Forms.TextBox();
            this.textBoxTravEffectuer = new System.Windows.Forms.TextBox();
            this.buttonEnregMat = new System.Windows.Forms.Button();
            this.buttonSupMat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonchargeOui = new System.Windows.Forms.RadioButton();
            this.radioButtonchargeNon = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAfficherMateriel = new System.Windows.Forms.Button();
            this.groupBoxLouer = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonOuiLouer = new System.Windows.Forms.RadioButton();
            this.radioButtonNonLouer = new System.Windows.Forms.RadioButton();
            this.groupBoxGarantie = new System.Windows.Forms.GroupBox();
            this.radioButtonOuiGarantie = new System.Windows.Forms.RadioButton();
            this.radioButtonNonGarantie = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewMateriel = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxForunisseur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDateAchat = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSupprimerMateriel = new System.Windows.Forms.DataGridView();
            this.buttonAfficherMat = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAfficherIncident = new System.Windows.Forms.Button();
            this.dataGridViewIncident = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPrendreCharge = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDateTraitement = new System.Windows.Forms.TextBox();
            this.textBoxHeureFin = new System.Windows.Forms.TextBox();
            this.textBoxHeureDebut = new System.Windows.Forms.TextBox();
            this.buttonModifEtat = new System.Windows.Forms.Button();
            this.radioButtonNonResolu = new System.Windows.Forms.RadioButton();
            this.radioButtonEncoursTraitement = new System.Windows.Forms.RadioButton();
            this.radioButtonResolu = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxLouer.SuspendLayout();
            this.groupBoxGarantie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriel)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupprimerMateriel)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncident)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTypeMateriel
            // 
            this.textBoxTypeMateriel.Location = new System.Drawing.Point(135, 31);
            this.textBoxTypeMateriel.Name = "textBoxTypeMateriel";
            this.textBoxTypeMateriel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeMateriel.TabIndex = 0;
            // 
            // textBoxTravEffectuer
            // 
            this.textBoxTravEffectuer.Location = new System.Drawing.Point(178, 182);
            this.textBoxTravEffectuer.Name = "textBoxTravEffectuer";
            this.textBoxTravEffectuer.Size = new System.Drawing.Size(245, 20);
            this.textBoxTravEffectuer.TabIndex = 1;
            // 
            // buttonEnregMat
            // 
            this.buttonEnregMat.Location = new System.Drawing.Point(91, 198);
            this.buttonEnregMat.Name = "buttonEnregMat";
            this.buttonEnregMat.Size = new System.Drawing.Size(162, 33);
            this.buttonEnregMat.TabIndex = 2;
            this.buttonEnregMat.Text = "Enregistrer";
            this.buttonEnregMat.UseVisualStyleBackColor = true;
            this.buttonEnregMat.Click += new System.EventHandler(this.buttonEnregMat_Click);
            // 
            // buttonSupMat
            // 
            this.buttonSupMat.Location = new System.Drawing.Point(285, 242);
            this.buttonSupMat.Name = "buttonSupMat";
            this.buttonSupMat.Size = new System.Drawing.Size(127, 34);
            this.buttonSupMat.TabIndex = 3;
            this.buttonSupMat.Text = "Supprimer Materiel";
            this.buttonSupMat.UseVisualStyleBackColor = true;
            this.buttonSupMat.Click += new System.EventHandler(this.buttonSupMat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type du materiel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Travail effectuer :";
            // 
            // radioButtonchargeOui
            // 
            this.radioButtonchargeOui.AutoSize = true;
            this.radioButtonchargeOui.Location = new System.Drawing.Point(46, 71);
            this.radioButtonchargeOui.Name = "radioButtonchargeOui";
            this.radioButtonchargeOui.Size = new System.Drawing.Size(41, 17);
            this.radioButtonchargeOui.TabIndex = 8;
            this.radioButtonchargeOui.TabStop = true;
            this.radioButtonchargeOui.Text = "Oui";
            this.radioButtonchargeOui.UseVisualStyleBackColor = true;
            // 
            // radioButtonchargeNon
            // 
            this.radioButtonchargeNon.AutoSize = true;
            this.radioButtonchargeNon.Location = new System.Drawing.Point(147, 71);
            this.radioButtonchargeNon.Name = "radioButtonchargeNon";
            this.radioButtonchargeNon.Size = new System.Drawing.Size(45, 17);
            this.radioButtonchargeNon.TabIndex = 9;
            this.radioButtonchargeNon.TabStop = true;
            this.radioButtonchargeNon.Text = "Non";
            this.radioButtonchargeNon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prise en charge d\'un incident :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(28, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 352);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAfficherMateriel);
            this.tabPage1.Controls.Add(this.groupBoxLouer);
            this.tabPage1.Controls.Add(this.groupBoxGarantie);
            this.tabPage1.Controls.Add(this.dataGridViewMateriel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxForunisseur);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxDateAchat);
            this.tabPage1.Controls.Add(this.textBoxTypeMateriel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonEnregMat);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter Materiel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAfficherMateriel
            // 
            this.buttonAfficherMateriel.Location = new System.Drawing.Point(239, 254);
            this.buttonAfficherMateriel.Name = "buttonAfficherMateriel";
            this.buttonAfficherMateriel.Size = new System.Drawing.Size(116, 25);
            this.buttonAfficherMateriel.TabIndex = 20;
            this.buttonAfficherMateriel.Text = "Afficher";
            this.buttonAfficherMateriel.UseVisualStyleBackColor = true;
            this.buttonAfficherMateriel.Click += new System.EventHandler(this.buttonAfficherMateriel_Click);
            // 
            // groupBoxLouer
            // 
            this.groupBoxLouer.Controls.Add(this.label9);
            this.groupBoxLouer.Controls.Add(this.radioButtonOuiLouer);
            this.groupBoxLouer.Controls.Add(this.radioButtonNonLouer);
            this.groupBoxLouer.Location = new System.Drawing.Point(258, 118);
            this.groupBoxLouer.Name = "groupBoxLouer";
            this.groupBoxLouer.Size = new System.Drawing.Size(235, 60);
            this.groupBoxLouer.TabIndex = 19;
            this.groupBoxLouer.TabStop = false;
            this.groupBoxLouer.Text = "Louer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Louer :";
            // 
            // radioButtonOuiLouer
            // 
            this.radioButtonOuiLouer.AutoSize = true;
            this.radioButtonOuiLouer.Location = new System.Drawing.Point(99, 24);
            this.radioButtonOuiLouer.Name = "radioButtonOuiLouer";
            this.radioButtonOuiLouer.Size = new System.Drawing.Size(44, 17);
            this.radioButtonOuiLouer.TabIndex = 13;
            this.radioButtonOuiLouer.TabStop = true;
            this.radioButtonOuiLouer.Text = "OUI";
            this.radioButtonOuiLouer.UseVisualStyleBackColor = true;
            // 
            // radioButtonNonLouer
            // 
            this.radioButtonNonLouer.AutoSize = true;
            this.radioButtonNonLouer.Location = new System.Drawing.Point(176, 26);
            this.radioButtonNonLouer.Name = "radioButtonNonLouer";
            this.radioButtonNonLouer.Size = new System.Drawing.Size(49, 17);
            this.radioButtonNonLouer.TabIndex = 14;
            this.radioButtonNonLouer.TabStop = true;
            this.radioButtonNonLouer.Text = "NON";
            this.radioButtonNonLouer.UseVisualStyleBackColor = true;
            // 
            // groupBoxGarantie
            // 
            this.groupBoxGarantie.Controls.Add(this.radioButtonOuiGarantie);
            this.groupBoxGarantie.Controls.Add(this.radioButtonNonGarantie);
            this.groupBoxGarantie.Controls.Add(this.label8);
            this.groupBoxGarantie.Location = new System.Drawing.Point(258, 57);
            this.groupBoxGarantie.Name = "groupBoxGarantie";
            this.groupBoxGarantie.Size = new System.Drawing.Size(235, 55);
            this.groupBoxGarantie.TabIndex = 18;
            this.groupBoxGarantie.TabStop = false;
            this.groupBoxGarantie.Text = "Garantie";
            // 
            // radioButtonOuiGarantie
            // 
            this.radioButtonOuiGarantie.AutoSize = true;
            this.radioButtonOuiGarantie.Location = new System.Drawing.Point(99, 30);
            this.radioButtonOuiGarantie.Name = "radioButtonOuiGarantie";
            this.radioButtonOuiGarantie.Size = new System.Drawing.Size(44, 17);
            this.radioButtonOuiGarantie.TabIndex = 11;
            this.radioButtonOuiGarantie.TabStop = true;
            this.radioButtonOuiGarantie.Text = "OUI";
            this.radioButtonOuiGarantie.UseVisualStyleBackColor = true;
            // 
            // radioButtonNonGarantie
            // 
            this.radioButtonNonGarantie.AutoSize = true;
            this.radioButtonNonGarantie.Location = new System.Drawing.Point(176, 30);
            this.radioButtonNonGarantie.Name = "radioButtonNonGarantie";
            this.radioButtonNonGarantie.Size = new System.Drawing.Size(49, 17);
            this.radioButtonNonGarantie.TabIndex = 12;
            this.radioButtonNonGarantie.TabStop = true;
            this.radioButtonNonGarantie.Text = "NON";
            this.radioButtonNonGarantie.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Garantie :";
            // 
            // dataGridViewMateriel
            // 
            this.dataGridViewMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriel.Location = new System.Drawing.Point(361, 184);
            this.dataGridViewMateriel.Name = "dataGridViewMateriel";
            this.dataGridViewMateriel.Size = new System.Drawing.Size(282, 117);
            this.dataGridViewMateriel.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fournisseur :";
            // 
            // textBoxForunisseur
            // 
            this.textBoxForunisseur.Location = new System.Drawing.Point(135, 77);
            this.textBoxForunisseur.Name = "textBoxForunisseur";
            this.textBoxForunisseur.Size = new System.Drawing.Size(100, 20);
            this.textBoxForunisseur.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date :";
            // 
            // textBoxDateAchat
            // 
            this.textBoxDateAchat.Location = new System.Drawing.Point(361, 31);
            this.textBoxDateAchat.Name = "textBoxDateAchat";
            this.textBoxDateAchat.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateAchat.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSupprimerMateriel);
            this.tabPage2.Controls.Add(this.buttonAfficherMat);
            this.tabPage2.Controls.Add(this.buttonSupMat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supprimer Materiel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSupprimerMateriel
            // 
            this.dataGridViewSupprimerMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupprimerMateriel.Location = new System.Drawing.Point(90, 25);
            this.dataGridViewSupprimerMateriel.Name = "dataGridViewSupprimerMateriel";
            this.dataGridViewSupprimerMateriel.Size = new System.Drawing.Size(521, 154);
            this.dataGridViewSupprimerMateriel.TabIndex = 8;
            // 
            // buttonAfficherMat
            // 
            this.buttonAfficherMat.Location = new System.Drawing.Point(264, 197);
            this.buttonAfficherMat.Name = "buttonAfficherMat";
            this.buttonAfficherMat.Size = new System.Drawing.Size(160, 29);
            this.buttonAfficherMat.TabIndex = 7;
            this.buttonAfficherMat.Text = "Afficcher Materiel";
            this.buttonAfficherMat.UseVisualStyleBackColor = true;
            this.buttonAfficherMat.Click += new System.EventHandler(this.buttonAfficherMat_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAfficherIncident);
            this.tabPage3.Controls.Add(this.dataGridViewIncident);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.buttonPrendreCharge);
            this.tabPage3.Controls.Add(this.textBoxMessage);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.radioButtonchargeNon);
            this.tabPage3.Controls.Add(this.radioButtonchargeOui);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(710, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Incident";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAfficherIncident
            // 
            this.buttonAfficherIncident.Location = new System.Drawing.Point(456, 232);
            this.buttonAfficherIncident.Name = "buttonAfficherIncident";
            this.buttonAfficherIncident.Size = new System.Drawing.Size(166, 37);
            this.buttonAfficherIncident.TabIndex = 15;
            this.buttonAfficherIncident.Text = "Afficher les incidents";
            this.buttonAfficherIncident.UseVisualStyleBackColor = true;
            this.buttonAfficherIncident.Click += new System.EventHandler(this.buttonAfficherIncident_Click);
            // 
            // dataGridViewIncident
            // 
            this.dataGridViewIncident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncident.Location = new System.Drawing.Point(401, 54);
            this.dataGridViewIncident.Name = "dataGridViewIncident";
            this.dataGridViewIncident.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewIncident.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Message :";
            // 
            // buttonPrendreCharge
            // 
            this.buttonPrendreCharge.Location = new System.Drawing.Point(147, 205);
            this.buttonPrendreCharge.Name = "buttonPrendreCharge";
            this.buttonPrendreCharge.Size = new System.Drawing.Size(195, 23);
            this.buttonPrendreCharge.TabIndex = 12;
            this.buttonPrendreCharge.Text = "Prendre en charge";
            this.buttonPrendreCharge.UseVisualStyleBackColor = true;
            this.buttonPrendreCharge.Click += new System.EventHandler(this.buttonPrendreCharge_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(31, 141);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(219, 45);
            this.textBoxMessage.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.textBoxDateTraitement);
            this.tabPage4.Controls.Add(this.textBoxHeureFin);
            this.tabPage4.Controls.Add(this.textBoxHeureDebut);
            this.tabPage4.Controls.Add(this.buttonModifEtat);
            this.tabPage4.Controls.Add(this.radioButtonNonResolu);
            this.tabPage4.Controls.Add(this.radioButtonEncoursTraitement);
            this.tabPage4.Controls.Add(this.radioButtonResolu);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.textBoxTravEffectuer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(710, 326);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Traitement";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Heure Fin :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Heure Debut :";
            // 
            // textBoxDateTraitement
            // 
            this.textBoxDateTraitement.Location = new System.Drawing.Point(333, 105);
            this.textBoxDateTraitement.Name = "textBoxDateTraitement";
            this.textBoxDateTraitement.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateTraitement.TabIndex = 12;
            // 
            // textBoxHeureFin
            // 
            this.textBoxHeureFin.Location = new System.Drawing.Point(132, 131);
            this.textBoxHeureFin.Name = "textBoxHeureFin";
            this.textBoxHeureFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeureFin.TabIndex = 11;
            // 
            // textBoxHeureDebut
            // 
            this.textBoxHeureDebut.Location = new System.Drawing.Point(132, 105);
            this.textBoxHeureDebut.Name = "textBoxHeureDebut";
            this.textBoxHeureDebut.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeureDebut.TabIndex = 10;
            // 
            // buttonModifEtat
            // 
            this.buttonModifEtat.Location = new System.Drawing.Point(176, 276);
            this.buttonModifEtat.Name = "buttonModifEtat";
            this.buttonModifEtat.Size = new System.Drawing.Size(75, 23);
            this.buttonModifEtat.TabIndex = 9;
            this.buttonModifEtat.Text = "Modifier";
            this.buttonModifEtat.UseVisualStyleBackColor = true;
            this.buttonModifEtat.Click += new System.EventHandler(this.buttonModifEtat_Click);
            // 
            // radioButtonNonResolu
            // 
            this.radioButtonNonResolu.AutoSize = true;
            this.radioButtonNonResolu.Location = new System.Drawing.Point(310, 62);
            this.radioButtonNonResolu.Name = "radioButtonNonResolu";
            this.radioButtonNonResolu.Size = new System.Drawing.Size(76, 17);
            this.radioButtonNonResolu.TabIndex = 8;
            this.radioButtonNonResolu.TabStop = true;
            this.radioButtonNonResolu.Text = "Non résolu";
            this.radioButtonNonResolu.UseVisualStyleBackColor = true;
            // 
            // radioButtonEncoursTraitement
            // 
            this.radioButtonEncoursTraitement.AutoSize = true;
            this.radioButtonEncoursTraitement.Location = new System.Drawing.Point(160, 62);
            this.radioButtonEncoursTraitement.Name = "radioButtonEncoursTraitement";
            this.radioButtonEncoursTraitement.Size = new System.Drawing.Size(131, 17);
            this.radioButtonEncoursTraitement.TabIndex = 7;
            this.radioButtonEncoursTraitement.TabStop = true;
            this.radioButtonEncoursTraitement.Text = "En cours de traitement";
            this.radioButtonEncoursTraitement.UseVisualStyleBackColor = true;
            // 
            // radioButtonResolu
            // 
            this.radioButtonResolu.AutoSize = true;
            this.radioButtonResolu.Location = new System.Drawing.Point(57, 62);
            this.radioButtonResolu.Name = "radioButtonResolu";
            this.radioButtonResolu.Size = new System.Drawing.Size(58, 17);
            this.radioButtonResolu.TabIndex = 6;
            this.radioButtonResolu.TabStop = true;
            this.radioButtonResolu.Text = "Resolu";
            this.radioButtonResolu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Technicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Technicien";
            this.Text = "Technicien";
            this.Load += new System.EventHandler(this.Technicien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxLouer.ResumeLayout(false);
            this.groupBoxLouer.PerformLayout();
            this.groupBoxGarantie.ResumeLayout(false);
            this.groupBoxGarantie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriel)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupprimerMateriel)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncident)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTypeMateriel;
        private System.Windows.Forms.TextBox textBoxTravEffectuer;
        private System.Windows.Forms.Button buttonEnregMat;
        private System.Windows.Forms.Button buttonSupMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonchargeOui;
        private System.Windows.Forms.RadioButton radioButtonchargeNon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrendreCharge;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonModifEtat;
        private System.Windows.Forms.RadioButton radioButtonNonResolu;
        private System.Windows.Forms.RadioButton radioButtonEncoursTraitement;
        private System.Windows.Forms.RadioButton radioButtonResolu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonNonLouer;
        private System.Windows.Forms.RadioButton radioButtonOuiLouer;
        private System.Windows.Forms.RadioButton radioButtonNonGarantie;
        private System.Windows.Forms.RadioButton radioButtonOuiGarantie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxForunisseur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDateAchat;
        private System.Windows.Forms.DataGridView dataGridViewMateriel;
        private System.Windows.Forms.DataGridView dataGridViewIncident;
        private System.Windows.Forms.GroupBox groupBoxLouer;
        private System.Windows.Forms.GroupBox groupBoxGarantie;
        private System.Windows.Forms.TextBox textBoxHeureFin;
        private System.Windows.Forms.TextBox textBoxHeureDebut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDateTraitement;
        private System.Windows.Forms.Button buttonAfficherMateriel;
        private System.Windows.Forms.Button buttonAfficherIncident;
        private System.Windows.Forms.Button buttonAfficherMat;
        private System.Windows.Forms.DataGridView dataGridViewSupprimerMateriel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}