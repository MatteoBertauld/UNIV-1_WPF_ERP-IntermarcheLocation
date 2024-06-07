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
        public static ApplicationData data;
        private bool Filtre = false;
        bool clientSelectionner = true;
        bool creerNouveauClient;
        

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
            
            SeConnecter fenetreConnexion = new SeConnecter();
            fenetreConnexion.ShowDialog();
            if (fenetreConnexion.DialogResult == false)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else
            {
                data = new ApplicationData();
                this.DataContext = data;
                InitializeComponent();
                InitialiserListeFicheClient();
            }
        }

        // Fenetre Fiche Client

        private void InitialiserListeFicheClient()
        {
            ComboBoxSelectionClient.Items.Clear();
            ComboBoxSelectionClient.Items.Add("Selectionner un Client");
            ComboBoxSelectionClient.SelectedIndex = 0;
            foreach (Client c in data.LesClients)
            {
                Console.WriteLine(c);
                ComboBoxSelectionClient.Items.Add(c.NomClient + " " + c.PrenomClient);
            }
        }

        private void ButtonNouveauClient_Checked(object sender, RoutedEventArgs e)
        {
            FicheClient client = new FicheClient(true);
            client.Show();
        }

        private void ButtonAfficherDetailClient_Click(object sender, RoutedEventArgs e)
        {
            FicheClient client = new FicheClient(false);
            client.Show();
        }




        private void ComboBoxSelectionClient_Selected(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ValeurChanger");
            if (ComboBoxSelectionClient.SelectedIndex > 0)
            {
                Client clientSelectionner = (Client)data.LesClients[ComboBoxSelectionClient.SelectedIndex - 1];
            }
        }



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


        private void ButtonAjouterVehicule_Click(object sender, RoutedEventArgs e)
        {
            ListeBoxVehiculeChoisit.Items.Add("Véhicule");
        }

    }
}
