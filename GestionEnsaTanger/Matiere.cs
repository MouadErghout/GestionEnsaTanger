using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnsaTanger
{
    class Matiere : DB.Model
    {
        private string Code, Designation;
        private double vh;
        private string Code_module;

        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        public string designation
        {
            get { return Designation; }
            set { Designation = value; }
        }
        public double VH
        {
            get { return vh; }
            set { vh = value; }
        }
        public string code_module
        {
            get { return Code_module; }
            set { Code_module = value; }
        }
        

        public Matiere() { }

        public Matiere(string code, string designation, float vh, string codeModule)
        {
            Code = code;
            Designation = designation;
            VH = vh;
            Code_module = codeModule;
        }

        public override string ToString()
        {
            return $"{Code} - {Designation} ({VH}h) - {Code_module}";
        }

        //working fine
        public void Create()
        {
            int i = save();
            if (i == -2) MessageBox.Show("EXCEPTION");
            if (i == -1) MessageBox.Show("ERROR");
            if (i == 0) MessageBox.Show("Created Successfully");
        }
        public List<Matiere> Read()
        {
            List<Matiere> matieres = new List<Matiere>();
            Dictionary<string, object> dict = ObjectToDictionary<object>(this);
            List<object> data = Select(dict);
            foreach (var item in data)
            {
                matieres.Add((Matiere)item);
            }
            return matieres;
        }
        public void Update(string code, string designation, float vH, string codeModule)
        {
            Matiere m = new Matiere
            {
                Code = code
            };
            List<object> matiere = Select(ObjectToDictionary<object>(m));
            if (matiere.Count > 0)
            {
                id = ((Matiere)matiere[0]).id;
                Code = code;
                Designation = designation;
                VH = vH;
                Code_module = codeModule;
            }

            int i = save();
            if (i == 0) MessageBox.Show("UPDATED SUCCESSFULLY");
            if (i == -1) MessageBox.Show("ERROR");
            if (i == -2) MessageBox.Show("EXCEPTION");
        }

        public void Delete(string code)
        {

            Matiere m = new Matiere
            {
                Code = code
            };

            List<object> matiere = Select(ObjectToDictionary<object>(m));
            if (matiere.Count > 0)
            {
                id = ((Matiere)matiere[0]).id;
            }

            int i = delete();
            if (i != 0 && i != -1) MessageBox.Show("DELETED  Successfully");
            if (i == 0) MessageBox.Show("No Line Deleted");
            if (i == -1) MessageBox.Show("Exception");
        }



    }
}