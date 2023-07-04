namespace GestionEnsaTanger
{
    partial class ConsultationNotes
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
            this.FiliereBox = new System.Windows.Forms.ComboBox();
            this.NiveauBox = new System.Windows.Forms.ComboBox();
            this.MatiereBox = new System.Windows.Forms.ComboBox();
            this.FiliereLabel = new System.Windows.Forms.Label();
            this.NiveauLabel = new System.Windows.Forms.Label();
            this.MatiereLabel = new System.Windows.Forms.Label();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Notes_Eleves = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moyenne_classe = new System.Windows.Forms.Label();
            this.Moyenne = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notes_Eleves)).BeginInit();
            this.SuspendLayout();
            // 
            // FiliereBox
            // 
            this.FiliereBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiliereBox.FormattingEnabled = true;
            this.FiliereBox.Location = new System.Drawing.Point(132, 89);
            this.FiliereBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FiliereBox.Name = "FiliereBox";
            this.FiliereBox.Size = new System.Drawing.Size(103, 21);
            this.FiliereBox.TabIndex = 0;
            this.FiliereBox.SelectedIndexChanged += new System.EventHandler(this.FiliereBox_SelectedIndexChanged_1);
            // 
            // NiveauBox
            // 
            this.NiveauBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NiveauBox.FormattingEnabled = true;
            this.NiveauBox.Location = new System.Drawing.Point(336, 91);
            this.NiveauBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NiveauBox.Name = "NiveauBox";
            this.NiveauBox.Size = new System.Drawing.Size(103, 21);
            this.NiveauBox.TabIndex = 1;
            this.NiveauBox.SelectedIndexChanged += new System.EventHandler(this.NiveauBox_SelectedIndexChanged_1);
            // 
            // MatiereBox
            // 
            this.MatiereBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatiereBox.FormattingEnabled = true;
            this.MatiereBox.Location = new System.Drawing.Point(132, 137);
            this.MatiereBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MatiereBox.Name = "MatiereBox";
            this.MatiereBox.Size = new System.Drawing.Size(103, 21);
            this.MatiereBox.TabIndex = 2;
            // 
            // FiliereLabel
            // 
            this.FiliereLabel.AutoSize = true;
            this.FiliereLabel.Location = new System.Drawing.Point(60, 89);
            this.FiliereLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FiliereLabel.Name = "FiliereLabel";
            this.FiliereLabel.Size = new System.Drawing.Size(34, 13);
            this.FiliereLabel.TabIndex = 3;
            this.FiliereLabel.Text = "Filière";
            // 
            // NiveauLabel
            // 
            this.NiveauLabel.AutoSize = true;
            this.NiveauLabel.Location = new System.Drawing.Point(255, 91);
            this.NiveauLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NiveauLabel.Name = "NiveauLabel";
            this.NiveauLabel.Size = new System.Drawing.Size(41, 13);
            this.NiveauLabel.TabIndex = 4;
            this.NiveauLabel.Text = "Niveau";
            this.NiveauLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MatiereLabel
            // 
            this.MatiereLabel.AutoSize = true;
            this.MatiereLabel.Location = new System.Drawing.Point(60, 142);
            this.MatiereLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MatiereLabel.Name = "MatiereLabel";
            this.MatiereLabel.Size = new System.Drawing.Size(42, 13);
            this.MatiereLabel.TabIndex = 5;
            this.MatiereLabel.Text = "Matière";
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(324, 137);
            this.Rechercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(127, 22);
            this.Rechercher.TabIndex = 7;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Notes_Eleves
            // 
            this.Notes_Eleves.AllowUserToOrderColumns = true;
            this.Notes_Eleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Notes_Eleves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Nom,
            this.Prenom,
            this.note});
            this.Notes_Eleves.Location = new System.Drawing.Point(63, 179);
            this.Notes_Eleves.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Notes_Eleves.Name = "Notes_Eleves";
            this.Notes_Eleves.ReadOnly = true;
            this.Notes_Eleves.RowHeadersWidth = 62;
            this.Notes_Eleves.RowTemplate.Height = 28;
            this.Notes_Eleves.Size = new System.Drawing.Size(490, 155);
            this.Notes_Eleves.TabIndex = 9;
            // 
            // code
            // 
            this.code.DataPropertyName = "string";
            this.code.Frozen = true;
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 8;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 120;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "string";
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 120;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "string";
            this.Prenom.Frozen = true;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.MinimumWidth = 8;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Width = 120;
            // 
            // note
            // 
            this.note.DataPropertyName = "decimal";
            this.note.Frozen = true;
            this.note.HeaderText = "Note";
            this.note.MinimumWidth = 8;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 120;
            // 
            // Moyenne_classe
            // 
            this.Moyenne_classe.AutoSize = true;
            this.Moyenne_classe.Location = new System.Drawing.Point(82, 361);
            this.Moyenne_classe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Moyenne_classe.Name = "Moyenne_classe";
            this.Moyenne_classe.Size = new System.Drawing.Size(110, 13);
            this.Moyenne_classe.TabIndex = 6;
            this.Moyenne_classe.Text = "Moyenne de la classe";
            // 
            // Moyenne
            // 
            this.Moyenne.Location = new System.Drawing.Point(200, 357);
            this.Moyenne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Moyenne.Name = "Moyenne";
            this.Moyenne.ReadOnly = true;
            this.Moyenne.Size = new System.Drawing.Size(163, 20);
            this.Moyenne.TabIndex = 10;
            this.Moyenne.TextChanged += new System.EventHandler(this.Moyenne_TextChanged);
            // 
            // ConsultationNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 405);
            this.ControlBox = false;
            this.Controls.Add(this.Moyenne);
            this.Controls.Add(this.Notes_Eleves);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Moyenne_classe);
            this.Controls.Add(this.MatiereLabel);
            this.Controls.Add(this.NiveauLabel);
            this.Controls.Add(this.FiliereLabel);
            this.Controls.Add(this.MatiereBox);
            this.Controls.Add(this.NiveauBox);
            this.Controls.Add(this.FiliereBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultationNotes";
            this.Text = "ConsultationNotes";
            this.Load += new System.EventHandler(this.ConsultationNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notes_Eleves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiliereBox;
        private System.Windows.Forms.ComboBox NiveauBox;
        private System.Windows.Forms.ComboBox MatiereBox;
        private System.Windows.Forms.Label FiliereLabel;
        private System.Windows.Forms.Label NiveauLabel;
        private System.Windows.Forms.Label MatiereLabel;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.DataGridView Notes_Eleves;
        private System.Windows.Forms.Label Moyenne_classe;
        private System.Windows.Forms.TextBox Moyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}
