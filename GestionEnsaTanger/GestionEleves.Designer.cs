namespace GestionEnsaTanger
{
    partial class GestionEleves
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
            this.buttonGestionNotes = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.filiereLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.filiere = new System.Windows.Forms.ComboBox();
            this.ElevesTable = new System.Windows.Forms.DataGridView();
            this.ElevesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesGroupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableCode_Fil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.niveau = new System.Windows.Forms.ComboBox();
            this.niveauLabel = new System.Windows.Forms.Label();
            this.checkBoxCode = new System.Windows.Forms.CheckBox();
            this.checkBoxNiveau = new System.Windows.Forms.CheckBox();
            this.checkBoxFiliere = new System.Windows.Forms.CheckBox();
            this.checkBoxPrenom = new System.Windows.Forms.CheckBox();
            this.checkBoxNom = new System.Windows.Forms.CheckBox();
            this.message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ElevesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGestionNotes
            // 
            this.buttonGestionNotes.Location = new System.Drawing.Point(660, 285);
            this.buttonGestionNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGestionNotes.Name = "buttonGestionNotes";
            this.buttonGestionNotes.Size = new System.Drawing.Size(212, 32);
            this.buttonGestionNotes.TabIndex = 26;
            this.buttonGestionNotes.Text = "Gestion des notes";
            this.buttonGestionNotes.UseVisualStyleBackColor = true;
            this.buttonGestionNotes.Click += new System.EventHandler(this.buttonGestionNotes_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(660, 243);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(212, 32);
            this.buttonRechercher.TabIndex = 25;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(660, 198);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(212, 35);
            this.buttonSupprimer.TabIndex = 24;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(660, 154);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(212, 35);
            this.buttonModifier.TabIndex = 23;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(660, 106);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(212, 38);
            this.buttonAjouter.TabIndex = 22;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(330, 123);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(241, 26);
            this.nom.TabIndex = 21;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(330, 168);
            this.prenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(241, 26);
            this.prenom.TabIndex = 20;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(330, 72);
            this.code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(241, 26);
            this.code.TabIndex = 18;
            // 
            // filiereLabel
            // 
            this.filiereLabel.AutoSize = true;
            this.filiereLabel.Location = new System.Drawing.Point(184, 220);
            this.filiereLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filiereLabel.Name = "filiereLabel";
            this.filiereLabel.Size = new System.Drawing.Size(51, 20);
            this.filiereLabel.TabIndex = 17;
            this.filiereLabel.Text = "Filiere";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(184, 172);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(78, 20);
            this.prenomLabel.TabIndex = 16;
            this.prenomLabel.Text = "PRENOM";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(184, 128);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(45, 20);
            this.nomLabel.TabIndex = 15;
            this.nomLabel.Text = "NOM";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(184, 77);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(47, 20);
            this.codeLabel.TabIndex = 14;
            this.codeLabel.Text = "Code";
            // 
            // filiere
            // 
            this.filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere.FormattingEnabled = true;
            this.filiere.Location = new System.Drawing.Point(330, 215);
            this.filiere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filiere.Name = "filiere";
            this.filiere.Size = new System.Drawing.Size(241, 28);
            this.filiere.TabIndex = 28;
            this.filiere.SelectedIndexChanged += new System.EventHandler(this.filiere_SelectedIndexChanged);
            // 
            // ElevesTable
            // 
            this.ElevesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElevesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ElevesID,
            this.ElevesNom,
            this.ElevesPrenom,
            this.ElevesGroupe,
            this.TableCode_Fil});
            this.ElevesTable.Location = new System.Drawing.Point(105, 402);
            this.ElevesTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ElevesTable.Name = "ElevesTable";
            this.ElevesTable.RowHeadersWidth = 62;
            this.ElevesTable.Size = new System.Drawing.Size(891, 258);
            this.ElevesTable.TabIndex = 27;
            this.ElevesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ElevesTable_CellClick);
            // 
            // ElevesID
            // 
            this.ElevesID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElevesID.DataPropertyName = "TableCode";
            this.ElevesID.HeaderText = "CodeElev";
            this.ElevesID.MinimumWidth = 8;
            this.ElevesID.Name = "ElevesID";
            this.ElevesID.ReadOnly = true;
            // 
            // ElevesNom
            // 
            this.ElevesNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElevesNom.DataPropertyName = "TableNom";
            this.ElevesNom.HeaderText = "Nom";
            this.ElevesNom.MinimumWidth = 8;
            this.ElevesNom.Name = "ElevesNom";
            this.ElevesNom.ReadOnly = true;
            // 
            // ElevesPrenom
            // 
            this.ElevesPrenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElevesPrenom.DataPropertyName = "TablePrenom";
            this.ElevesPrenom.HeaderText = "Prenom";
            this.ElevesPrenom.MinimumWidth = 8;
            this.ElevesPrenom.Name = "ElevesPrenom";
            this.ElevesPrenom.ReadOnly = true;
            // 
            // ElevesGroupe
            // 
            this.ElevesGroupe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElevesGroupe.DataPropertyName = "TableNiveau";
            this.ElevesGroupe.HeaderText = "Niveau";
            this.ElevesGroupe.MinimumWidth = 8;
            this.ElevesGroupe.Name = "ElevesGroupe";
            this.ElevesGroupe.ReadOnly = true;
            // 
            // TableCode_Fil
            // 
            this.TableCode_Fil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableCode_Fil.HeaderText = "code_Fil";
            this.TableCode_Fil.MinimumWidth = 8;
            this.TableCode_Fil.Name = "TableCode_Fil";
            this.TableCode_Fil.ReadOnly = true;
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(660, 62);
            this.buttonNouveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(212, 35);
            this.buttonNouveau.TabIndex = 29;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // niveau
            // 
            this.niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.niveau.FormattingEnabled = true;
            this.niveau.Location = new System.Drawing.Point(330, 269);
            this.niveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(241, 28);
            this.niveau.TabIndex = 31;
            // 
            // niveauLabel
            // 
            this.niveauLabel.AutoSize = true;
            this.niveauLabel.Location = new System.Drawing.Point(184, 274);
            this.niveauLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.niveauLabel.Name = "niveauLabel";
            this.niveauLabel.Size = new System.Drawing.Size(57, 20);
            this.niveauLabel.TabIndex = 30;
            this.niveauLabel.Text = "Niveau";
            // 
            // checkBoxCode
            // 
            this.checkBoxCode.AutoSize = true;
            this.checkBoxCode.Location = new System.Drawing.Point(582, 77);
            this.checkBoxCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxCode.Name = "checkBoxCode";
            this.checkBoxCode.Size = new System.Drawing.Size(22, 21);
            this.checkBoxCode.TabIndex = 32;
            this.checkBoxCode.UseVisualStyleBackColor = true;
            // 
            // checkBoxNiveau
            // 
            this.checkBoxNiveau.AutoSize = true;
            this.checkBoxNiveau.Location = new System.Drawing.Point(582, 272);
            this.checkBoxNiveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxNiveau.Name = "checkBoxNiveau";
            this.checkBoxNiveau.Size = new System.Drawing.Size(22, 21);
            this.checkBoxNiveau.TabIndex = 33;
            this.checkBoxNiveau.UseVisualStyleBackColor = true;
            // 
            // checkBoxFiliere
            // 
            this.checkBoxFiliere.AutoSize = true;
            this.checkBoxFiliere.Location = new System.Drawing.Point(582, 220);
            this.checkBoxFiliere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxFiliere.Name = "checkBoxFiliere";
            this.checkBoxFiliere.Size = new System.Drawing.Size(22, 21);
            this.checkBoxFiliere.TabIndex = 34;
            this.checkBoxFiliere.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrenom
            // 
            this.checkBoxPrenom.AutoSize = true;
            this.checkBoxPrenom.Location = new System.Drawing.Point(582, 172);
            this.checkBoxPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPrenom.Name = "checkBoxPrenom";
            this.checkBoxPrenom.Size = new System.Drawing.Size(22, 21);
            this.checkBoxPrenom.TabIndex = 35;
            this.checkBoxPrenom.UseVisualStyleBackColor = true;
            // 
            // checkBoxNom
            // 
            this.checkBoxNom.AutoSize = true;
            this.checkBoxNom.Location = new System.Drawing.Point(582, 128);
            this.checkBoxNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxNom.Name = "checkBoxNom";
            this.checkBoxNom.Size = new System.Drawing.Size(22, 21);
            this.checkBoxNom.TabIndex = 36;
            this.checkBoxNom.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(432, 349);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 20);
            this.message.TabIndex = 37;
            // 
            // GestionEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 768);
            this.ControlBox = false;
            this.Controls.Add(this.message);
            this.Controls.Add(this.checkBoxNom);
            this.Controls.Add(this.checkBoxPrenom);
            this.Controls.Add(this.checkBoxFiliere);
            this.Controls.Add(this.checkBoxNiveau);
            this.Controls.Add(this.checkBoxCode);
            this.Controls.Add(this.niveau);
            this.Controls.Add(this.niveauLabel);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.filiere);
            this.Controls.Add(this.ElevesTable);
            this.Controls.Add(this.buttonGestionNotes);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.code);
            this.Controls.Add(this.filiereLabel);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.codeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GestionEleves";
            this.Text = "GestionEleves";
            this.Load += new System.EventHandler(this.GestionEleves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElevesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGestionNotes;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label filiereLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.ComboBox filiere;
        private System.Windows.Forms.DataGridView ElevesTable;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.ComboBox niveau;
        private System.Windows.Forms.Label niveauLabel;
        private System.Windows.Forms.CheckBox checkBoxCode;
        private System.Windows.Forms.CheckBox checkBoxNiveau;
        private System.Windows.Forms.CheckBox checkBoxFiliere;
        private System.Windows.Forms.CheckBox checkBoxPrenom;
        private System.Windows.Forms.CheckBox checkBoxNom;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableCode_Fil;
    }
}