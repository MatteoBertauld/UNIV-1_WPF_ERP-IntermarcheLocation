using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF;

namespace SAE2._01
{
    public class Client
    {
        private static int staticAutoIncrementNumClient;

        private int numClient;
        private string nomClient;
        private string adresseRueClient;
        private string adresseCpClient;
        private string adresseVilleClient;
        private string telephone;
        private string mail;

        public int NumClient
        {
            get
            {
                return numClient;
            }

            set
            {
                numClient = value;
            }
        }

        public string NomClient
        {
            get
            {
                return nomClient;
            }

            set
            {
                nomClient = value;
            }
        }

        public string AdresseRueClient
        {
            get
            {
                return adresseRueClient;
            }

            set
            {
                adresseRueClient = value;
            }
        }

        public string AdresseCpClient
        {
            get
            {
                return adresseCpClient;
            }

            set
            {
                adresseCpClient = value;
            }
        }

        public string AdresseVilleClient
        {
            get
            {
                return adresseVilleClient;
            }

            set
            {
                adresseVilleClient = value;
            }
        }

        public string Mail
        {
            get
            {
                return this.mail;
            }

            set
            {
                this.mail = value;
            }
        }

        public static int StaticAutoIncrementNumClient
        {
            get
            {
                staticAutoIncrementNumClient += 1;
                return staticAutoIncrementNumClient;
            }
        }

        public string Telephone
        {
            get
            {
                return this.telephone;
            }

            set
            {
                this.telephone = value;
            }
        }

        public Client(string nomClient, string adresseRueClient, string adresseCpClient, string adresseVilleClient,string telephone, string mail)
        {
            this.NumClient = StaticAutoIncrementNumClient;
            this.NomClient = nomClient;
            this.AdresseRueClient = adresseRueClient;
            this.AdresseCpClient = adresseCpClient;
            this.AdresseVilleClient = adresseVilleClient;
            this.Telephone = telephone;
            this.Mail = mail;
        }


        public int Create()
        {
            String sql = $"insert into client (num_client,nom_client,adresse_rue_client,adresse_cp_client,adresse_ville_client,telephone_client,mail_client) values (" +
            $"'{this.NumClient}','{this.NomClient}'," +
            $"'{this.AdresseRueClient}','{this.AdresseCpClient}','{this.AdresseVilleClient}'," +
            $"{this.Telephone}','{this.Mail}');";

            return DataAccess.Instance.SetData(sql);
        }
        public static ObservableCollection<Client> Read()
        {
            ObservableCollection<Client> lesClients = new ObservableCollection<Client>();
            String sql = "SELECT * FROM client";
            DataTable dt = DataAccess.Instance.GetData(sql);
            
            foreach (DataRow res in dt.Rows)
            {
                Client nouveau = new Client(
                    res["nom_client"].ToString(),
                    res["adresse_rue_client"].ToString(),
                    res["adresse_cp_client"].ToString(),
                    res["adresse_ville_client"].ToString(),
                    res["telephone_client"].ToString(),
                    res["mail_client"].ToString()
                    );
                lesClients.Add(nouveau);
            }
            return lesClients;
        }

    }
}
