using DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionEnsaTanger
{
    public partial class ConsultationNotes : Form
    {
        public ConsultationNotes()
        {
            InitializeComponent();
            FiliereBox.Items.Clear();
            
            loadFilieres();
            FiliereBox.SelectedIndexChanged += FiliereBox_SelectedIndexChanged;

        }

        private void FiliereBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NiveauBox.SelectedIndex = -1;
            MatiereBox.SelectedIndex = -1;
            NiveauBox.Items.Clear();
            MatiereBox.Items.Clear();
            loadNiveaux();
            NiveauBox.SelectedIndexChanged += NiveauBox_SelectedIndexChanged;
        }

        private void loadFilieres()
        {
            FiliereBox.Items.Clear();

            List<dynamic> L = Filiere.all<Filiere>();
            foreach (Filiere item in L)
                FiliereBox.Items.Add(item.code);
        }

        private void NiveauBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatiereBox.SelectedIndex = -1;
            MatiereBox.Items.Clear();
            loadMatieres();
        }
        private void loadNiveaux()
        {
            NiveauBox.Items.Clear();

            if (FiliereBox.SelectedItem != null)
            {
                if (FiliereBox.SelectedItem.ToString() == "AP")
                {
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "1");
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "2");
                }
                else
                {
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "1");
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "2");
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "3");
                }
            }
        }

        private void loadMatieres()
        {
            MatiereBox.Items.Clear();

            if (NiveauBox.SelectedItem != null)
            {
                string Niveau = NiveauBox.SelectedItem.ToString();
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("niveau", Niveau);
                List<dynamic> Modules = Module.select<Module>(dict);
                foreach (dynamic mod in Modules)
                {
                    Module module = (Module)mod;
                    dict = new Dictionary<string, object>();
                    dict.Add("code_module", module.code);
                    List<dynamic> Matieres = Matiere.select<Matiere>(dict);
                    foreach (dynamic mat in Matieres)
                        MatiereBox.Items.Add(mat.designation);
                }
            }
        }
        private void ConsultationNotes_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (MatiereBox.SelectedItem != null)
            {
                string Mat = MatiereBox.SelectedItem.ToString();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("designation", Mat);

                if (Mat != null)
                {
                    List<dynamic> L = Matiere.select<Matiere>(dic);
                    string req = "SELECT e1.code, e1.nom, e1.prenom, n.note " +
                        "FROM Notes n INNER JOIN Eleve e1 ON n.code_eleve = e1.code " +
                        "WHERE n.code_mat = '" + L[0].code + "'";

                    IDataReader reader = Connexion.Select(req);

                    Notes_Eleves.Rows.Clear();

                    while (reader.Read())
                    {
                        var row = new DataGridViewRow();
                        row.CreateCells(Notes_Eleves);
                        for (int i = 0; i < reader.FieldCount; i++)
                            row.Cells[i].Value = reader.GetValue(i);
                        Notes_Eleves.Rows.Add(row);
                    }
                    reader.Close();
                    req = "SELECT AVG(n.note) as moyenne FROM Notes n INNER JOIN " +
                        "Eleve e1 ON n.code_eleve = e1.code WHERE n.code_mat = '" + L[0].code + "'";
                    reader = Connexion.Select(req);
                    reader.Read();
                    double moyenne = 0.0;
                    if (!reader.IsDBNull(0))
                    {
                        moyenne = reader.GetDouble(0);
                    }
                    Moyenne.Text = moyenne.ToString();
                    reader.Close();
                }
            }
        }

        private void Moyenne_TextChanged(object sender, EventArgs e)
        {
        }

        private void FiliereBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            NiveauBox.SelectedIndex = -1;
            MatiereBox.SelectedIndex = -1;
            NiveauBox.Items.Clear();
            MatiereBox.Items.Clear();
        }

        private void NiveauBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MatiereBox.SelectedIndex = -1;
            MatiereBox.Items.Clear();
        }
    }
}
