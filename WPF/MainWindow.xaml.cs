using SAE2._01;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool Filtre = false;
        bool clientSelectionner = true;
        bool creerNouveauClient;
        ObservableCollection<Client> ListeClients = new ObservableCollection<Client>();


        public bool ClientSelectionner
        {
            get
            {
                return this.clientSelectionner;
            }

            set
            {
                this.clientSelectionner = value;
            }
        }

        public bool CreerNouveauClient
        {
            get
            {
                return this.creerNouveauClient;
            }

            set
            {
                this.creerNouveauClient = value;
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            SeConnecter fenetreConnexion = new SeConnecter();
            fenetreConnexion.ShowDialog();
            if (fenetreConnexion.DialogResult == false)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        // Fenetre MenuEmploye

        private void ButtonVisualiserReservation_Click(object sender, RoutedEventArgs e)
        {
            GridMenuEmploye.Visibility = Visibility.Hidden;
            GridVisualiserReservation.Visibility = Visibility.Visible;
        }

        private void ButtonEffectuerReservation_Click(object sender, RoutedEventArgs e)
        {
            InitialiserFenetreFicheClient();
            GridMenuEmploye.Visibility = Visibility.Hidden;
            GridFicheClient.Visibility = Visibility.Visible;
        }

        // Fenetre Fiche CLient

        private void InitialiserFenetreFicheClient()
        {
            ListeClients = Client.Read();
            ComboBoxSelectionClient.Items.Clear();
            foreach (Client c in ListeClients)
            {
                ComboBoxSelectionClient.Items.Add(c);
            }
        }

        private void ButtonNouveauClient_Checked(object sender, RoutedEventArgs e)
        {
            TextBoxNom.Visibility = Visibility.Visible;
            TextBoxPrenom.Visibility = Visibility.Visible;
            TextBoxAdresse.Visibility = Visibility.Visible;
            TextBoxVille.Visibility = Visibility.Visible;
            TextBoxCodePostal.Visibility = Visibility.Visible;
            TextBoxPays.Visibility = Visibility.Visible;
            TextBoxTelephone.Visibility = Visibility.Visible;
            TextBoxMail.Visibility = Visibility.Visible;
            ButtonEntreprise.Visibility = Visibility.Visible;

            ComboBoxSelectionClient.Visibility = Visibility.Hidden;
            LabelOU.Visibility = Visibility.Hidden;
        }

        private void ButtonValiderFicheClient_Click(object sender, RoutedEventArgs e)
        {
            if (CreerNouveauClient)
            {
                //Client NouveauClient = 
                ClientSelectionner = true;
            }

            if (ClientSelectionner)
            {
                GridReservationVehicule.Visibility = Visibility.Visible;
                GridFicheClient.Visibility = Visibility.Hidden;
            }
            else
            {
                Console.WriteLine("Erreur : Aucun cliet n'est séléctionner");
            }
        }


        // Choix des Vehicules


        private void ButtonMagasin_Checked(object sender, RoutedEventArgs e)
        {
            ComboBoxMagasin.Visibility = Visibility.Visible;
            CalendarReservation.Visibility = Visibility.Hidden;
            ComboBoxCategorieVehicule.Visibility = Visibility.Hidden;
        }

        private void ButtonCategorieVehicule_Checked(object sender, RoutedEventArgs e)
        {
            ComboBoxCategorieVehicule.Visibility = Visibility.Visible;
            CalendarReservation.Visibility = Visibility.Hidden;
            ComboBoxMagasin.Visibility = Visibility.Hidden;
        }

        private void ButtonDateRéservation_Checked(object sender, RoutedEventArgs e)
        {
            CalendarReservation.Visibility = Visibility.Visible;
            ComboBoxMagasin.Visibility = Visibility.Hidden;
            ComboBoxCategorieVehicule.Visibility = Visibility.Hidden;
        }

        private void ButtonFiltre_Click(object sender, RoutedEventArgs e)
        {
            if (Filtre) { ButtonFiltre.Content = "Filtre : Automatique"; }
            else { ButtonFiltre.Content = "Filtre : Manuelle"; }
            Filtre = !Filtre;
        }

        private void ButtonAjouterVehicule_Click(object sender, RoutedEventArgs e)
        {
            ListeBoxVehiculeChoisit.Items.Add("Véhicule");
        }


        private void Valider_Critère_Click(object sender, RoutedEventArgs e)
        {
            /*
            ListeBoxVehiculeRecherche.Items.Clear();
            ListeBoxVehiculeRecherche.Items.Add("Véhicule 1");
            ListeBoxVehiculeRecherche.Items.Add("Véhicule 2");
            ListeBoxVehiculeRecherche.Items.Add("Véhicule 3");
            */
        }

        private void ButtonSuivant_Click(object sender, RoutedEventArgs e)
        {
            GridReservationVehicule.Visibility = Visibility.Hidden;
            GridValidationReservation.Visibility = Visibility.Visible;
        }


        //  Fenetre Validation reservation


        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            GridValidationReservation.Visibility = Visibility.Hidden;
            GridMenuEmploye.Visibility = Visibility.Visible;
        }


        // Fenetre Visualiser Reservation


        private void ButtonRetour_Click(object sender, RoutedEventArgs e)
        {
            GridVisualiserReservation.Visibility = Visibility.Hidden;
            GridMenuEmploye.Visibility = Visibility.Visible;
        }
    }
}
