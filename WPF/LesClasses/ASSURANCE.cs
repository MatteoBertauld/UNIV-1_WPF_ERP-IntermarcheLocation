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

        public int NumAssurance { get => numAssurance; set => numAssurance = value; }
        public string DescriptionAssurance { get => descriptionAssurance; set => descriptionAssurance = value; }
        public int PrixAssurance1 { get => PrixAssurance; set => PrixAssurance = value; }

        public ASSURANCE(int numAssurance, string descriptionAssurance, int prixAssurance1)
        {
            NumAssurance = numAssurance;
            DescriptionAssurance = descriptionAssurance;
            PrixAssurance1 = prixAssurance1;
        }

    }
    
}
