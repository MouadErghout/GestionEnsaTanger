using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionEnsaTanger
{
    public partial class GestionEleves : Form
    {
        public static string code_eleve;
        public GestionEleves(MDI mdi)
        {
            InitializeComponent();
            MdiParent = mdi;
            TopLevel = false;
            Dock = DockStyle.Fill;
            RemplireElevesTable(ListEleves());
            ListFilieres();
        }
        private void Initializer()
        {
            nom.Text = "";
            prenom.Text = "";
            code.Text = "";
            code.Text = "";
            message.Text = "";
            ListFilieres();
            RemplireElevesTable(ListEleves());
        }
        private void Niveau()
        {
            niveau.Items.Clear();

            if (filiere.Text == "AP")
            {
                niveau.Items.Add(filiere.Text+"1");
                niveau.Items.Add(filiere.Text+"2");
            }
            if (filiere.Text == "GINF" || filiere.Text == "GSTR" || filiere.Text == "GIL" || filiere.Text == "GSEA" || filiere.Text == "G3EI")
            {
                niveau.Items.Add(filiere.Text+"1");
                niveau.Items.Add(filiere.Text+"2");
                niveau.Items.Add(filiere.Text+"3");
            }

        }
        private void ListFilieres()
        {
            List<string> filieres = new List<string>();

            List<object> fil = Filiere.all<Filiere>();
            foreach (object item in fil)
                filieres.Add(((Filiere)item).code);

            filiere.Items.Clear();
            foreach (string item in filieres)
                filiere.Items.Add(item);
            Niveau();
        }
        private void RemplireElevesTable(List<object> eleves)
        {
            ElevesTable.Rows.Clear();

            foreach (Eleve eleve in eleves)
            {
                var row = new DataGridViewRow();
                row.CreateCells(ElevesTable);
                row.Cells[0].Value = eleve.code;
                row.Cells[1].Value = eleve.nom;
                row.Cells[2].Value = eleve.prenom;
                row.Cells[3].Value = eleve.niveau;
                row.Cells[4].Value = eleve.code_fil;
                ElevesTable.Rows.Add(row);
            }
        }
        private List<object> ListEleves()
        {
            List<object> eleves = Eleve.all<Eleve>();
            eleves.Reverse();
            return eleves;
        }
        private void buttonGestionNotes_Click(object sender, EventArgs e)
        {
            code_eleve = code.Text;
            GestionNotes newMDIChild = new GestionNotes();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this.MdiParent;
            // Display the new form.
            newMDIChild.Show();
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            Initializer();
        }


        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code.Text) || string.IsNullOrWhiteSpace(prenom.Text) || string.IsNullOrWhiteSpace(nom.Text) || string.IsNullOrWhiteSpace(filiere.Text) || string.IsNullOrWhiteSpace(niveau.Text))
            {
                MessageBox.Show("Error!! Inserer tous les champs");
            }
            else
            {
                if ((new Eleve()).Ajouter(code.Text, prenom.Text, nom.Text, niveau.Text, filiere.Text))
                {
                    Initializer();
                    message.Text = "succès l'élève "+code.Text+" est bien inserer";
                    RemplireElevesTable(ListEleves());
                }
                else
                    message.Text = "erreur! code déja utilisé";
            }
        }

        private void ElevesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the DataGridViewRow object of the clicked row
            DataGridViewRow row = ElevesTable.Rows[e.RowIndex];

            // Access the data in the row using the column names or indexes
            code.Text = row.Cells[0].Value.ToString();
            nom.Text = row.Cells[1].Value.ToString();
            prenom.Text = row.Cells[2].Value.ToString();
            filiere.Text = row.Cells[4].Value.ToString();
            niveau.Text = row.Cells[3].Value.ToString();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code.Text) || string.IsNullOrWhiteSpace(prenom.Text) || string.IsNullOrWhiteSpace(nom.Text) || string.IsNullOrWhiteSpace(filiere.Text) || string.IsNullOrWhiteSpace(niveau.Text))
            {
                MessageBox.Show("Error!! Inserer tous les champs");
            }
            else
            {
                if ((new Eleve()).Modifier(code.Text, nom.Text, prenom.Text, niveau.Text, filiere.Text))
                {
                    Initializer();
                    message.Text = "succès l'élève "+code.Text+" est bien modifié";
                    RemplireElevesTable(ListEleves());
                }
                else
                    message.Text = "erreur! vous pouvez pas changer le code";
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code.Text))
                MessageBox.Show("Error!! Inserer le code ");
            else
            {
                DialogResult result = MessageBox.Show("vous voulez supprimer l'eleve " + code.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if ((new Eleve()).Supprimer(code.Text))
                    {
                        Initializer();
                        message.Text = "succès l'élève "+code.Text+" est bien supprimé";
                        RemplireElevesTable(ListEleves());
                    }
                    else
                        message.Text = "erreur! le code n'existe pas";
                }
            }
        }

        private void filiere_SelectedIndexChanged(object sender, EventArgs e)
        {

            Niveau();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            Eleve eleve = new Eleve();

            if (string.IsNullOrWhiteSpace(code.Text) && string.IsNullOrWhiteSpace(prenom.Text) && string.IsNullOrWhiteSpace(nom.Text) && string.IsNullOrWhiteSpace(filiere.Text) && string.IsNullOrWhiteSpace(niveau.Text))
            {
                MessageBox.Show("Erreur!!, Inserer les champs cocher");
            }
            else
            {
                if (!checkBoxCode.Checked && !checkBoxNom.Checked && !checkBoxPrenom.Checked && !checkBoxFiliere.Checked && !checkBoxNiveau.Checked)
                {
                    MessageBox.Show("Erreur!!, cocher au moins un champ");
                }
                else
                {
                    if (checkBoxCode.Checked)
                    {
                        if (string.IsNullOrEmpty(code.Text))
                        {
                            MessageBox.Show("Erreur!!, Inserer les champs cocher");
                            return;
                        }
                        else
                            eleve.code = code.Text;
                    }
                    if (checkBoxNom.Checked)
                    {
                        if (string.IsNullOrEmpty(nom.Text))
                        {
                            MessageBox.Show("Erreur!!, Inserer les champs cocher");
                            return;
                        }
                        else
                            eleve.nom = nom.Text;
                    }

                    if (checkBoxPrenom.Checked)
                    {
                        if (string.IsNullOrEmpty(prenom.Text))
                        {
                            MessageBox.Show("Erreur!!, Inserer les champs cocher");
                            return;
                        }
                        else
                            eleve.prenom = prenom.Text;
                    }
                    if (checkBoxFiliere.Checked)
                    {
                        if (string.IsNullOrEmpty(filiere.Text))
                        {
                            MessageBox.Show("Erreur!!, Inserer les champs cocher");
                            return;
                        }
                        else
                            eleve.code_fil = filiere.Text;
                    }

                    if (checkBoxNiveau.Checked)
                    {
                        if (string.IsNullOrEmpty(niveau.Text))
                        {
                            MessageBox.Show("Erreur!!, Inserer les champs cocher");
                            return;
                        }
                        else
                            eleve.niveau = niveau.Text;
                    }
                    if (eleve.code == "" && eleve.nom == "" && eleve.prenom == "" && eleve.code_fil == "" && eleve.niveau == "")
                        return;
                    else
                        RemplireElevesTable(eleve.Rechercher());
                }
            }
        }

        private void GestionEleves_Load(object sender, EventArgs e)
        {

        }
    }
}