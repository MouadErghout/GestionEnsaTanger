using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Filiere : Model
    {

        private string Code;
        private string Designation;

        public Filiere() { }
        public Filiere(string code, string designation)
        {
            this.Code = code;
            this.Designation = designation;
        }

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


        public override string ToString()
        {
            return "ID: " + id + " Code: " + Code + " Designation: " + Designation;
        }
    }
}
