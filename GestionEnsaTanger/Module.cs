using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Module : Model
    {
        private string Code, Designation, Niveau, Semestre, Code_fil;

        public Module() { }
        
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

        public string niveau
        {
            get { return Niveau; }
            set { Niveau = value; }
        }

        public string semestre
        {
            get { return Semestre;}
            set { Semestre = value; }
        }

        public string code_fil
        {
            get { return Code_fil; }
            set { Code_fil = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "code: " + code + " code_fil: " + code_fil;
        }
    }

    
}
