using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace GestionEnsaTanger
{
    public partial class BilanAnnuel : Form
    {
        public int number = 0;
        public BilanAnnuel()
        {
            InitializeComponent();
            ListFilieres();

        }

        private void filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            Niveau();
            etudiant.SelectedIndex= -1;
            dataGridView1.Rows.Clear();
        }

        private void niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            elevlist();
            dataGridView1.Rows.Clear();

        }

        private void etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            
            try {
                string codeEleve = etudiant.SelectedItem.ToString();
                calcMoy(codeEleve);
                dataGridView1.Rows.Clear();
                FillDataGridView(codeEleve);          
            }
            catch(Exception ex) {MessageBox.Show("VEUILLEZ INSERER UN ETUDIANT"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void moyenne_TextChanged(object sender, EventArgs e)
        {
        }

        private void BilanAnnuel_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Niveau()
        {
            niveau.Items.Clear();

            if (filiere.Text == "AP")
            {
                niveau.Items.Add(filiere.Text + "1");
                niveau.Items.Add(filiere.Text + "2");
            }
            if (filiere.Text == "GINF" || filiere.Text == "GSTR" || filiere.Text == "GIL" || filiere.Text == "GSEA" || filiere.Text == "G3EI")
            {
                niveau.Items.Add(filiere.Text + "1");
                niveau.Items.Add(filiere.Text + "2");
                niveau.Items.Add(filiere.Text + "3");
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
        
        private void fillist()
        {
            filiere.Refresh();
            filiere.Text = "filiere";
            Filiere fil = new Filiere();
            List<dynamic> filList = fil.All();
            System.Object[] itemObjects = new System.Object[filList.Count];
            int i = 0;
            foreach (Filiere f1 in filList)
            {
                itemObjects[i] = f1.code;
                i++;
            }
            filiere.Items.AddRange(itemObjects);
        }

        private void elevlist()
        {
            etudiant.Items.Clear();
            Eleve eleve = new Eleve();
            eleve.niveau = niveau.SelectedItem.ToString();
            eleve.code_fil = filiere.SelectedItem.ToString();
            List<Object> eleves = eleve.Rechercher();
            
            foreach (Eleve e1 in eleves)
            {
                etudiant.Items.Add(e1.code);
                
            }
        }

        private void FillDataGridView(string codeEleve)
        {
            
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("code_eleve", codeEleve);

            List<dynamic> notes = Model.select<Notes>(parameters);
            
            var row = new DataGridViewRow();
           
            foreach (var note in notes)
            {
                string codeMat = note.code_mat;
                double noteValue = note.note;

                parameters.Clear();
                parameters.Add("code", codeMat);

                List<dynamic> matieres = Model.select<Matiere>(parameters);
                string designation = matieres[0].designation;

                parameters.Clear();

                string codeModule = matieres[0].code_module;

                parameters.Clear();
                parameters.Add("code", codeModule);

                List<dynamic> modules = Model.select<Module>(parameters);
                string semestre = modules[0].semestre;

                dataGridView1.Rows.Add(codeMat, designation, semestre, noteValue);
            }

            /*using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=ENSA_TANGER;Integrated Security=True"))
            {
                connection.Open();

                // create a command to select notes for the specified code_eleve
                using (SqlCommand command = new SqlCommand("SELECT * FROM Notes WHERE code_eleve = @codeEleve", connection))
                {
                    command.Parameters.AddWithValue("@codeEleve", codeEleve);

                    // create a data adapter to fill a data set with the results
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        // loop through each note and retrieve the corresponding matiere and semestre
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            string codeMat = row["code_mat"].ToString();
                            double note = double.Parse(row["note"].ToString());

                            // create a command to select the designation of the matiere
                            using (SqlCommand command2 = new SqlCommand("SELECT designation FROM Matiere WHERE code = @codeMat", connection))
                            {
                                command2.Parameters.AddWithValue("@codeMat", codeMat);
                                string designation = command2.ExecuteScalar().ToString();

                                // create a command to select the semestre of the matiere
                                using (SqlCommand command3 = new SqlCommand("SELECT semestre FROM Module WHERE code_fil IN (SELECT code_fil FROM Eleve WHERE code = @codeEleve)", connection))
                                {
                                    command3.Parameters.AddWithValue("@codeEleve", codeEleve);
                                    string semestre = command3.ExecuteScalar().ToString();

                                    // add a row to the DataGridView with the retrieved values
                                    dataGridView1.Rows.Add(codeMat, designation, semestre, note);
                                }
                            }
                        }
                    }
                }
            }
           */

        }

        private void calcMoy(string codeEleve)
        {
            Moyennes m = new Moyennes();
            m.code_eleve = codeEleve;
            
            List<dynamic> moyennes = Model.select<Moyennes>(m.ObjectToDictionary<Object>(m));
            if (moyennes.Count > 0)
            {
                m = moyennes[0];
                moyenne.Text = "" + Convert.ToDouble(m.moyenne);
            }
            else
            {

                moyenne.Text = "N/A";
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = GetDataTableFromDGV(dataGridView1);
                string codeEleve = etudiant.SelectedItem.ToString();
                exportExcel(dataTable,codeEleve);
                MessageBox.Show("ajouté avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("INSERER ETUDIANT LAYKHALIK !!!!");
            }
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // Add columns to the datatable
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add(column.HeaderText);
                }
            }

            // Add rows to the datatable
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dataRow = dt.NewRow();

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible)
                    {
                        dataRow[i] = row.Cells[i].Value;
                    }
                }

                dt.Rows.Add(dataRow);
            }

            return dt;
        }

        private void exportExcel(DataTable dt, string etudiant)
        {
            // Check if dataGridView1 is null or has no rows
            if (dataGridView1 == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string file = @"C:\Users\mouad\C#.Net Projects\TP4(mini projet)\GestionEnsaTanger\GestionEnsaTanger\";
            string extension = ".xlsx";
            number++;
            string filepath = Path.Combine(file + etudiant + extension);


            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filepath, SpreadsheetDocumentType.Workbook);

            WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

            Sheet sheet = new Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Bilan Annuel"
            };

            sheets.Append(sheet);

            Worksheet worksheet = worksheetPart.Worksheet;
            SheetData sheetData = worksheet.GetFirstChild<SheetData>();

            Row headerRow = new Row();
            foreach (DataColumn column in dt.Columns)
            {
                Cell headerCell = new Cell()
                {
                    DataType = CellValues.String,
                    CellValue = new CellValue(column.ColumnName)
                };
                headerRow.Append(headerCell);
            }
            sheetData.AppendChild(headerRow);

            foreach (DataRow item in dt.Rows)
            {
                Row r = new Row();

                for(int i=0; i<item.ItemArray.Length; i++)
                {
                    Cell c = new Cell()
                    {
                        CellValue = new CellValue(item[i].ToString()),
                        DataType = CellValues.String
                    };
                    r.Append(c);
                }
                sheetData.Append(r);
            }


            worksheetPart.Worksheet.Save();
            spreadsheetDocument.Close();
            
        }


/*        private bool DataTableHasEmptyCells(DataTable dt)
        {
            for (int i = 1; i < dt.Rows.Count; i++) // Start loop at index 1 to skip header row
            {
                bool isEmpty = true;
                foreach (var value in dt.Rows[i].ItemArray)
                {
                    if (value != null && !string.IsNullOrEmpty(value.ToString()))
                    {
                        isEmpty = false;
                        break;
                    }
                }
                if (isEmpty)
                {
                    return true;
                }
            }
            return false;
        }
*/


    }
}
