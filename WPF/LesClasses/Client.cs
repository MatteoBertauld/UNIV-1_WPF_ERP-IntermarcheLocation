using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class Client
    {
        private int numClient;
        private string nomClient;
        private string adresseRueClient;
        private string adresseCpClient;
        private string adresseVilleClient;
        private string mail;

        public int NumClient { get => numClient; set => numClient = value; }
        public string NomClient { get => nomClient; set => nomClient = value; }
        public string AdresseRueClient { get => adresseRueClient; set => adresseRueClient = value; }
        public string AdresseCpClient { get => adresseCpClient; set => adresseCpClient = value; }
        public string AdresseVilleClient { get => adresseVilleClient; set => adresseVilleClient = value; }
        public string Mail { get => mail; set => mail = value; }

        public Client(int numClient, string nomClient, string adresseRueClient, string adresseCpClient, string adresseVilleClient, string mail)
        {
            NumClient = numClient;
            NomClient = nomClient;
            AdresseRueClient = adresseRueClient;
            AdresseCpClient = adresseCpClient;
            AdresseVilleClient = adresseVilleClient;
            Mail = mail;
        }
    }
}
