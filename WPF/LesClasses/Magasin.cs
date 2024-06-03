using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class Magasin
    {
        private int numMagasin;
        private string nomMagasin;
        private string adresseRueMagasin;
        private string adresseCpMagasin;
        private string adresseVilleMagasin;
        private string horaireMagasin;

        public int NumMagasin { get => numMagasin; set => numMagasin = value; }
        public string NomMagasin { get => nomMagasin; set => nomMagasin = value; }
        public string AdresseRueMagasin { get => adresseRueMagasin; set => adresseRueMagasin = value; }
        public string AdresseCpMagasin { get => adresseCpMagasin; set => adresseCpMagasin = value; }
        public string AdresseVilleMagasin { get => adresseVilleMagasin; set => adresseVilleMagasin = value; }
        public string HoraireMagasin { get => horaireMagasin; set => horaireMagasin = value; }

        public Magasin(int numMagasin, string nomMagasin, string adresseRueMagasin, string adresseCpMagasin, string adresseVilleMagasin, string horaireMagasin)
        {
            NumMagasin = numMagasin;
            NomMagasin = nomMagasin;
            AdresseRueMagasin = adresseRueMagasin;
            AdresseCpMagasin = adresseCpMagasin;
            AdresseVilleMagasin = adresseVilleMagasin;
            HoraireMagasin = horaireMagasin;
        }
    }
}
