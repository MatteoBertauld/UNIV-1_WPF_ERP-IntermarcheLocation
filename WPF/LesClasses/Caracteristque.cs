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

        public int NumAssurance { get => numAssurance; set => numAssurance = value; }
        public string DescriptionAssurance { get => descriptionAssurance; set => descriptionAssurance = value; }
        public int PrixAssurance { get => prixAssurance; set => prixAssurance = value; }

        public Caracteristque(int numAssurance, string descriptionAssurance, int prixAssurance)
        {
            NumAssurance = numAssurance;
            DescriptionAssurance = descriptionAssurance;
            PrixAssurance = prixAssurance;
        }
    }
}
