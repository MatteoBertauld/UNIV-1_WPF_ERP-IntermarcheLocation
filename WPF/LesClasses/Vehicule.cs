using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class Vehicule
    {
        private string immatriculation;
        private string typeBoite;
        private int numMagasin;
        private string nomCategorie;
        private string nomVehicule;
        private string descriptionVehicule;
        private int nombrePlaces;
        private decimal prixLocation;
        private bool climatisation;
        private string lienPhotoUrl;

        public string Immatriculation { get => immatriculation; set => immatriculation = value; }
        public string TypeBoite { get => typeBoite; set => typeBoite = value; }
        public int NumMagasin { get => numMagasin; set => numMagasin = value; }
        public string NomCategorie { get => nomCategorie; set => nomCategorie = value; }
        public string NomVehicule { get => nomVehicule; set => nomVehicule = value; }
        public string DescriptionVehicule { get => descriptionVehicule; set => descriptionVehicule = value; }
        public int NombrePlaces { get => nombrePlaces; set => nombrePlaces = value; }
        public decimal PrixLocation { get => prixLocation; set => prixLocation = value; }
        public bool Climatisation { get => climatisation; set => climatisation = value; }
        public string LienPhotoUrl { get => lienPhotoUrl; set => lienPhotoUrl = value; }

        public Vehicule(string immatriculation, string typeBoite, int numMagasin, string nomCategorie, string nomVehicule, string descriptionVehicule, int nombrePlaces, decimal prixLocation, bool climatisation, string lienPhotoUrl)
        {
            Immatriculation = immatriculation;
            TypeBoite = typeBoite;
            NumMagasin = numMagasin;
            NomCategorie = nomCategorie;
            NomVehicule = nomVehicule;
            DescriptionVehicule = descriptionVehicule;
            NombrePlaces = nombrePlaces;
            PrixLocation = prixLocation;
            Climatisation = climatisation;
            LienPhotoUrl = lienPhotoUrl;
        }
    }
}
