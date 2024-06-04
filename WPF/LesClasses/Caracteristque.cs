using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class Caracteristque
    {
        private int numAssurance;
        private string descriptionAssurance;
        private int prixAssurance;


        public int NumAssurance
        {
            get
            {
                return numAssurance;
            }

            set
            {
                if (value <= 0) { throw new ArgumentOutOfRangeException("Attention le numéro d'assurance doit etre supérieur à 0"); }
                numAssurance = value;
            }
        }

        public string DescriptionAssurance
        {
            get
            {
                return descriptionAssurance;
            }

            set
            {
                descriptionAssurance = value;
            }
        }

        public int PrixAssurance
        {
            get
            {
                return this.prixAssurance;
            }

            set
            {
                this.prixAssurance = value;
            }
        }


        public Caracteristque(int numAssurance, string descriptionAssurance, int prixAssurance)
        {
            NumAssurance = numAssurance;
            DescriptionAssurance = descriptionAssurance;
            PrixAssurance = prixAssurance;
        }
    }
}
