using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour ReservationVehicule.xaml
    /// </summary>
    public partial class ReservationVehicule : Window
    {
        private bool Filtre = false;

        public ReservationVehicule()
        {
            InitializeComponent();
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
            ListeBoxVehiculeRecherche.Items.Clear();
            ListeBoxVehiculeRecherche.Items.Add("Véhicule 1");
            ListeBoxVehiculeRecherche.Items.Add("Véhicule 2");
            ListeBoxVehiculeRecherche.Items.Add("Véhicule 3");
        }

        private void ButtonSuivant_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
