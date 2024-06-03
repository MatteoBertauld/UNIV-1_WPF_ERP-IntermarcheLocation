using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class detailReservation
    {
        private string immatriculation;
        private int numCaracteristique;
        private string valeurCaracteristique;

        public string Immatriculation { get => immatriculation; set => immatriculation = value; }
        public int NumCaracteristique { get => numCaracteristique; set => numCaracteristique = value; }
        public string ValeurCaracteristique { get => valeurCaracteristique; set => valeurCaracteristique = value; }

        public detailReservation(string immatriculation, int numCaracteristique, string valeurCaracteristique)
        {
            Immatriculation = immatriculation;
            NumCaracteristique = numCaracteristique;
            ValeurCaracteristique = valeurCaracteristique;
        }
    }
}
