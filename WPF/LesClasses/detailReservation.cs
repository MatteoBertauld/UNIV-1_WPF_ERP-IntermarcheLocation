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

        public string Immatriculation
        {
            get { return immatriculation; }
            set {
                
                if (!Regex.IsMatch(value, "^[A-Z]{2}-[0-9]{3}-[A-Z]{2}$"))
                    throw new ArgumentException("ATTENTION, il faut respecter les caractères de la plaque d'immatriculation !");

                this.telephone = value;
            }
        }

       

        public int NumCaracteristique
        {
            get { return numCaracteristique; }
            set { if (value = null) { throw new ArgumentException("ATTENTION, le numéro caractéristique ne doit pas etre nul !")} numCaracteristique = value; }
        }

        
        public string ValeurCaracteristique
        {
            get { return valeurCaracteristique; }
            set { if (string.IsNullOrEmpty) { throw new ArgumentException("ATTENTION, la valeur caractéristique ne doit pas ere ni nulle ni vide !")} valeurCaracteristique = value; }
        }

        public detailReservation(string immatriculation, int numCaracteristique, string valeurCaracteristique)
        {
            Immatriculation = immatriculation;
            NumCaracteristique = numCaracteristique;
            ValeurCaracteristique = valeurCaracteristique;
        }
    }
}
