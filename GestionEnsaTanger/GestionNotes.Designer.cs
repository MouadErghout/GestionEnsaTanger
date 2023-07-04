namespace GestionEnsaTanger
{
    partial class GestionNotes
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
            this.l_CodeEleve = new System.Windows.Forms.Label();
            this.l_matiere = new System.Windows.Forms.Label();
            this.l_Note = new System.Windows.Forms.Label();
            this.t_CodeEleve = new System.Windows.Forms.TextBox();
            this.b_Nouveau = new System.Windows.Forms.Button();
            this.b_Ajouter = new System.Windows.Forms.Button();
            this.b_Modifier = new System.Windows.Forms.Button();
            this.b_Supprimer = new System.Windows.Forms.Button();
            this.b_Rechercher = new System.Windows.Forms.Button();
            this.c_Matiere = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.Label();
            this.t_Note = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.succes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_CodeEleve
            // 
            this.l_CodeEleve.AutoSize = true;
            this.l_CodeEleve.Location = new System.Drawing.Point(140, 82);
            this.l_CodeEleve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_CodeEleve.Name = "l_CodeEleve";
            this.l_CodeEleve.Size = new System.Drawing.Size(90, 20);
            this.l_CodeEleve.TabIndex = 0;
            this.l_CodeEleve.Text = "Code Eleve";
            // 
            // l_matiere
            // 
            this.l_matiere.AutoSize = true;
            this.l_matiere.Location = new System.Drawing.Point(140, 145);
            this.l_matiere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_matiere.Name = "l_matiere";
            this.l_matiere.Size = new System.Drawing.Size(62, 20);
            this.l_matiere.TabIndex = 1;
            this.l_matiere.Text = "Matiere";
            // 
            // l_Note
            // 
            this.l_Note.AutoSize = true;
            this.l_Note.Location = new System.Drawing.Point(140, 212);
            this.l_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Note.Name = "l_Note";
            this.l_Note.Size = new System.Drawing.Size(43, 20);
            this.l_Note.TabIndex = 2;
            this.l_Note.Text = "Note";
            // 
            // t_CodeEleve
            // 
            this.t_CodeEleve.Location = new System.Drawing.Point(280, 77);
            this.t_CodeEleve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_CodeEleve.Name = "t_CodeEleve";
            this.t_CodeEleve.ReadOnly = true;
            this.t_CodeEleve.Size = new System.Drawing.Size(180, 26);
            this.t_CodeEleve.TabIndex = 3;
            // 
            // b_Nouveau
            // 
            this.b_Nouveau.Location = new System.Drawing.Point(543, 72);
            this.b_Nouveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Nouveau.Name = "b_Nouveau";
            this.b_Nouveau.Size = new System.Drawing.Size(112, 35);
            this.b_Nouveau.TabIndex = 6;
            this.b_Nouveau.Text = "Nouveau";
            this.b_Nouveau.UseVisualStyleBackColor = true;
            this.b_Nouveau.Click += new System.EventHandler(this.b_Nouveau_Click);
            // 
            // b_Ajouter
            // 
            this.b_Ajouter.Location = new System.Drawing.Point(543, 135);
            this.b_Ajouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Ajouter.Name = "b_Ajouter";
            this.b_Ajouter.Size = new System.Drawing.Size(112, 35);
            this.b_Ajouter.TabIndex = 7;
            this.b_Ajouter.Text = "Ajouter";
            this.b_Ajouter.UseVisualStyleBackColor = true;
            this.b_Ajouter.Click += new System.EventHandler(this.b_Ajouter_Click);
            // 
            // b_Modifier
            // 
            this.b_Modifier.Location = new System.Drawing.Point(543, 203);
            this.b_Modifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Modifier.Name = "b_Modifier";
            this.b_Modifier.Size = new System.Drawing.Size(112, 35);
            this.b_Modifier.TabIndex = 8;
            this.b_Modifier.Text = "Modifier";
            this.b_Modifier.UseVisualStyleBackColor = true;
            this.b_Modifier.Click += new System.EventHandler(this.b_Modifier_Click);
            // 
            // b_Supprimer
            // 
            this.b_Supprimer.Location = new System.Drawing.Point(741, 102);
            this.b_Supprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Supprimer.Name = "b_Supprimer";
            this.b_Supprimer.Size = new System.Drawing.Size(112, 35);
            this.b_Supprimer.TabIndex = 9;
            this.b_Supprimer.Text = "Supprimer";
            this.b_Supprimer.UseVisualStyleBackColor = true;
            this.b_Supprimer.Click += new System.EventHandler(this.b_Supprimer_Click);
            // 
            // b_Rechercher
            // 
            this.b_Rechercher.Location = new System.Drawing.Point(741, 168);
            this.b_Rechercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Rechercher.Name = "b_Rechercher";
            this.b_Rechercher.Size = new System.Drawing.Size(112, 35);
            this.b_Rechercher.TabIndex = 10;
            this.b_Rechercher.Text = "Rechercher";
            this.b_Rechercher.UseVisualStyleBackColor = true;
            this.b_Rechercher.Click += new System.EventHandler(this.b_Rechercher_Click);
            // 
            // c_Matiere
            // 
            this.c_Matiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_Matiere.FormattingEnabled = true;
            this.c_Matiere.Location = new System.Drawing.Point(280, 145);
            this.c_Matiere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_Matiere.Name = "c_Matiere";
            this.c_Matiere.Size = new System.Drawing.Size(180, 28);
            this.c_Matiere.TabIndex = 11;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(140, 403);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 20);
            this.error.TabIndex = 12;
            // 
            // t_Note
            // 
            this.t_Note.Location = new System.Drawing.Point(280, 208);
            this.t_Note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_Note.Name = "t_Note";
            this.t_Note.Size = new System.Drawing.Size(180, 26);
            this.t_Note.TabIndex = 4;
            // 
            // succes
            // 
            this.succes.AutoSize = true;
            this.succes.ForeColor = System.Drawing.Color.Green;
            this.succes.Location = new System.Drawing.Point(140, 482);
            this.succes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(0, 20);
            this.succes.TabIndex = 13;
            // 
            // GestionNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1340, 805);
            this.ControlBox = false;
            this.Controls.Add(this.succes);
            this.Controls.Add(this.error);
            this.Controls.Add(this.c_Matiere);
            this.Controls.Add(this.b_Rechercher);
            this.Controls.Add(this.b_Supprimer);
            this.Controls.Add(this.b_Modifier);
            this.Controls.Add(this.b_Ajouter);
            this.Controls.Add(this.b_Nouveau);
            this.Controls.Add(this.t_Note);
            this.Controls.Add(this.t_CodeEleve);
            this.Controls.Add(this.l_Note);
            this.Controls.Add(this.l_matiere);
            this.Controls.Add(this.l_CodeEleve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GestionNotes";
            this.Text = "GestionNotes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_CodeEleve;
        private System.Windows.Forms.Label l_matiere;
        private System.Windows.Forms.Label l_Note;
        private System.Windows.Forms.TextBox t_CodeEleve;
        private System.Windows.Forms.Button b_Nouveau;
        private System.Windows.Forms.Button b_Ajouter;
        private System.Windows.Forms.Button b_Modifier;
        private System.Windows.Forms.Button b_Supprimer;
        private System.Windows.Forms.Button b_Rechercher;
        private System.Windows.Forms.ComboBox c_Matiere;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox t_Note;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label succes;
    }
}