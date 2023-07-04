namespace GestionEnsaTanger
{
    partial class BilanAnnuel
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
            this.rechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code_matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiliereLabel = new System.Windows.Forms.Label();
            this.filiere = new System.Windows.Forms.ComboBox();
            this.etudiant = new System.Windows.Forms.ComboBox();
            this.niveau = new System.Windows.Forms.ComboBox();
            this.EtudiantLabel = new System.Windows.Forms.Label();
            this.NiveauLabel = new System.Windows.Forms.Label();
            this.MoyenneLabel = new System.Windows.Forms.Label();
            this.moyenne = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rechercher.Location = new System.Drawing.Point(512, 109);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(121, 23);
            this.rechercher.TabIndex = 0;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_matiere,
            this.Designation,
            this.Semestre,
            this.Note});
            this.dataGridView1.Location = new System.Drawing.Point(80, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Code_matiere
            // 
            this.Code_matiere.HeaderText = "Code matiere";
            this.Code_matiere.Name = "Code_matiere";
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.Name = "Semestre";
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // FiliereLabel
            // 
            this.FiliereLabel.AutoSize = true;
            this.FiliereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiliereLabel.Location = new System.Drawing.Point(77, 63);
            this.FiliereLabel.Name = "FiliereLabel";
            this.FiliereLabel.Size = new System.Drawing.Size(41, 13);
            this.FiliereLabel.TabIndex = 2;
            this.FiliereLabel.Text = "Filiere";
            // 
            // filiere
            // 
            this.filiere.DisplayMember = "A";
            this.filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere.FormattingEnabled = true;
            this.filiere.Location = new System.Drawing.Point(163, 63);
            this.filiere.Name = "filiere";
            this.filiere.Size = new System.Drawing.Size(121, 21);
            this.filiere.TabIndex = 3;
            this.filiere.ValueMember = "A";
            this.filiere.SelectedIndexChanged += new System.EventHandler(this.filiere_SelectedIndexChanged);
            // 
            // etudiant
            // 
            this.etudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.etudiant.FormattingEnabled = true;
            this.etudiant.Location = new System.Drawing.Point(163, 109);
            this.etudiant.Name = "etudiant";
            this.etudiant.Size = new System.Drawing.Size(121, 21);
            this.etudiant.TabIndex = 4;
            this.etudiant.SelectedIndexChanged += new System.EventHandler(this.etudiant_SelectedIndexChanged);
            // 
            // niveau
            // 
            this.niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.niveau.FormattingEnabled = true;
            this.niveau.Location = new System.Drawing.Point(512, 63);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(121, 21);
            this.niveau.TabIndex = 5;
            this.niveau.SelectedIndexChanged += new System.EventHandler(this.niveau_SelectedIndexChanged);
            // 
            // EtudiantLabel
            // 
            this.EtudiantLabel.AutoSize = true;
            this.EtudiantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtudiantLabel.Location = new System.Drawing.Point(76, 112);
            this.EtudiantLabel.Name = "EtudiantLabel";
            this.EtudiantLabel.Size = new System.Drawing.Size(54, 13);
            this.EtudiantLabel.TabIndex = 6;
            this.EtudiantLabel.Text = "Etudiant";
            // 
            // NiveauLabel
            // 
            this.NiveauLabel.AutoSize = true;
            this.NiveauLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NiveauLabel.Location = new System.Drawing.Point(416, 63);
            this.NiveauLabel.Name = "NiveauLabel";
            this.NiveauLabel.Size = new System.Drawing.Size(47, 13);
            this.NiveauLabel.TabIndex = 7;
            this.NiveauLabel.Text = "Niveau";
            // 
            // MoyenneLabel
            // 
            this.MoyenneLabel.AutoSize = true;
            this.MoyenneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoyenneLabel.Location = new System.Drawing.Point(77, 343);
            this.MoyenneLabel.Name = "MoyenneLabel";
            this.MoyenneLabel.Size = new System.Drawing.Size(111, 13);
            this.MoyenneLabel.TabIndex = 8;
            this.MoyenneLabel.Text = "Moyenne Annuelle";
            // 
            // moyenne
            // 
            this.moyenne.Location = new System.Drawing.Point(217, 340);
            this.moyenne.Name = "moyenne";
            this.moyenne.ReadOnly = true;
            this.moyenne.Size = new System.Drawing.Size(141, 20);
            this.moyenne.TabIndex = 9;
            this.moyenne.TextChanged += new System.EventHandler(this.moyenne_TextChanged);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(558, 168);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 10;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // BilanAnnuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 396);
            this.ControlBox = false;
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.moyenne);
            this.Controls.Add(this.MoyenneLabel);
            this.Controls.Add(this.NiveauLabel);
            this.Controls.Add(this.EtudiantLabel);
            this.Controls.Add(this.niveau);
            this.Controls.Add(this.etudiant);
            this.Controls.Add(this.filiere);
            this.Controls.Add(this.FiliereLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rechercher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BilanAnnuel";
            this.Text = "BilanAnnuel";
            this.Load += new System.EventHandler(this.BilanAnnuel_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FiliereLabel;
        private System.Windows.Forms.ComboBox etudiant;
        private System.Windows.Forms.ComboBox niveau;
        private System.Windows.Forms.Label EtudiantLabel;
        private System.Windows.Forms.Label NiveauLabel;
        private System.Windows.Forms.Label MoyenneLabel;
        private System.Windows.Forms.TextBox moyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_matiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        public System.Windows.Forms.ComboBox filiere;
        private System.Windows.Forms.Button exportButton;
    }
}