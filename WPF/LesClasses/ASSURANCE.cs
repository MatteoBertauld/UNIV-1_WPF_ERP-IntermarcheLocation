using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class ASSURANCE
    {
        private int numAssurance;
        private string descriptionAssurance;
        private int PrixAssurance;


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

        public int PrixAssurance1
        {
            get
            {
                return this.PrixAssurance;
            }

            set
            {
                this.PrixAssurance = value;
            }
        }
        public ASSURANCE(int numAssurance, string descriptionAssurance, int prixAssurance1)
        {
            NumAssurance = numAssurance;
            DescriptionAssurance = descriptionAssurance;
            PrixAssurance1 = prixAssurance1;
        }


    }
    
}
