using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class CategorieVehicule
    {
        private string nomCategorie;


        public string NomCategorie
        {
            get
            {
                return this.nomCategorie;
            }

            set
            {
                if(string.IsNullOrEmpty(value)) { throw new ArgumentNullException("ATTENTION, la valeur ne doit etre ni nulle ni vide !"); }
                this.nomCategorie = value;
            }
        }

        public CategorieVehicule(string nomCategorie)
        {
            NomCategorie = nomCategorie;
        }
    }
}
