using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnsaTanger
{
    public partial class MDI : Form
    {
        GestionEleves formEleves;
        public MDI()
        {
            InitializeComponent();
            formEleves = new GestionEleves(this);
            formEleves.Show();
        }

        private void GestionEtudiants_Load(object sender, EventArgs e)
        {

        }
        
        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*formEleves.Show();*/
            GestionEleves newMDIChild = new GestionEleves(this);
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Visible = false;
            ConsultationNotes childForm = new ConsultationNotes();
            this.IsMdiContainer = true;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.MdiParent = this;
            childForm.Show();
            /*            new ConsultationNotes().ShowDialog();*/
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Visible = false;
            BilanAnnuel childForm = new BilanAnnuel();
            this.IsMdiContainer = true;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.MdiParent = this; 
            childForm.Show();
        }

        private void restorationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new RestorationEleves(this)).Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
