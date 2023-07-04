using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    class Moyennes : Model
    {
        private string Code_eleve, Code_fil, Niveau;
        private Double? Moyenne = null;

        public string code_eleve
        {
            get { return Code_eleve; }
            set { Code_eleve = value; }
        }

        public string code_fil
        {
            get { return Code_fil; }
            set { Code_fil = value; }
        }
        public string niveau
        {
            get { return Niveau; }
            set
            {
                Niveau = value;
            }
        }
        public Double? moyenne
        {
            get { return Moyenne; }
            set
            {
                Moyenne = value;
            }
        }
    }
}
