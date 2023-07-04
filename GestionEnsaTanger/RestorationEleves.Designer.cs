namespace GestionEnsaTanger
{
    partial class RestorationEleves
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
            this.code = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.ElevesTable = new System.Windows.Forms.DataGridView();
            this.ElevesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesGroupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableCode_Fil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRestorer = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.XMLSUPPRIMER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ElevesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.code.Location = new System.Drawing.Point(250, 72);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(162, 20);
            this.code.TabIndex = 20;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(193, 75);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 19;
            this.codeLabel.Text = "Code";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(435, 72);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(141, 21);
            this.buttonRechercher.TabIndex = 26;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
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
            this.ElevesTable.Location = new System.Drawing.Point(103, 172);
            this.ElevesTable.Name = "ElevesTable";
            this.ElevesTable.Size = new System.Drawing.Size(594, 79);
            this.ElevesTable.TabIndex = 28;
            // 
            // ElevesID
            // 
            this.ElevesID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElevesID.DataPropertyName = "TableCode";
            this.ElevesID.HeaderText = "CodeElev";
            this.ElevesID.Name = "ElevesID";
            this.ElevesID.ReadOnly = true;
            // 
            // ElevesNom
            // 
            this.ElevesNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElevesNom.DataPropertyName = "TableNom";
            this.ElevesNom.HeaderText = "Nom";
            this.ElevesNom.Name = "ElevesNom";
            this.ElevesNom.ReadOnly = true;
            // 
            // ElevesPrenom
            // 
            this.ElevesPrenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElevesPrenom.DataPropertyName = "TablePrenom";
            this.ElevesPrenom.HeaderText = "Prenom";
            this.ElevesPrenom.Name = "ElevesPrenom";
            this.ElevesPrenom.ReadOnly = true;
            // 
            // ElevesGroupe
            // 
            this.ElevesGroupe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElevesGroupe.DataPropertyName = "TableNiveau";
            this.ElevesGroupe.HeaderText = "Niveau";
            this.ElevesGroupe.Name = "ElevesGroupe";
            this.ElevesGroupe.ReadOnly = true;
            // 
            // TableCode_Fil
            // 
            this.TableCode_Fil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableCode_Fil.HeaderText = "code_Fil";
            this.TableCode_Fil.Name = "TableCode_Fil";
            this.TableCode_Fil.ReadOnly = true;
            // 
            // buttonRestorer
            // 
            this.buttonRestorer.Location = new System.Drawing.Point(103, 267);
            this.buttonRestorer.Name = "buttonRestorer";
            this.buttonRestorer.Size = new System.Drawing.Size(157, 36);
            this.buttonRestorer.TabIndex = 29;
            this.buttonRestorer.Text = "Restorer";
            this.buttonRestorer.UseVisualStyleBackColor = true;
            this.buttonRestorer.Click += new System.EventHandler(this.buttonRestorer_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(347, 121);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 30;
            // 
            // XMLSUPPRIMER
            // 
            this.XMLSUPPRIMER.Location = new System.Drawing.Point(435, 267);
            this.XMLSUPPRIMER.Name = "XMLSUPPRIMER";
            this.XMLSUPPRIMER.Size = new System.Drawing.Size(157, 36);
            this.XMLSUPPRIMER.TabIndex = 31;
            this.XMLSUPPRIMER.Text = "Liste Eleve Supprimer";
            this.XMLSUPPRIMER.UseVisualStyleBackColor = true;
            this.XMLSUPPRIMER.Click += new System.EventHandler(this.XMLSUPPRIMER_Click);
            // 
            // RestorationEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.XMLSUPPRIMER);
            this.Controls.Add(this.message);
            this.Controls.Add(this.buttonRestorer);
            this.Controls.Add(this.ElevesTable);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.code);
            this.Controls.Add(this.codeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestorationEleves";
            this.ShowIcon = false;
            this.Text = "ResorationEleves";
            this.Load += new System.EventHandler(this.ResorationEleves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElevesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.DataGridView ElevesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableCode_Fil;
        private System.Windows.Forms.Button buttonRestorer;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button XMLSUPPRIMER;
    }
}