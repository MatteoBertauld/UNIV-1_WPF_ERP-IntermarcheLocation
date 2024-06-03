using SAE2._01;
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
    /// Logique d'interaction pour MenuEmploye.xaml
    /// </summary>
    public partial class MainWindow_MenuEmploye : Window
    {

        public MainWindow_MenuEmploye()
        {
            InitializeComponent();
            SeConnecter fenetreConnexion = new SeConnecter();
            fenetreConnexion.ShowDialog();
            if (fenetreConnexion.DialogResult == false)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }
        
        private void ButtonVisualiserReservation_Click(object sender, RoutedEventArgs e)
        {
            VisualiserReservation fenetreVisualiserReservation = new VisualiserReservation();
            fenetreVisualiserReservation.ShowDialog();
            if (fenetreVisualiserReservation.DialogResult == false)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void ButtonEffectuerReservation_Click(object sender, RoutedEventArgs e)
        {
            FicheClient fenetreFicheClient = new FicheClient();
            fenetreFicheClient.ShowDialog();
            if (fenetreFicheClient.DialogResult == false)
            {
                System.Windows.Application.Current.Shutdown();
            }

            ReservationVehicule fenetreReservationVehicule = new ReservationVehicule();
            fenetreReservationVehicule.ShowDialog();
            if (fenetreReservationVehicule.DialogResult == false)
            {
                System.Windows.Application.Current.Shutdown();
            }

            ValidationReservation fenetreValidationReservation = new ValidationReservation();
            fenetreValidationReservation.ShowDialog();
            if (fenetreValidationReservation.DialogResult == false)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }
    }
}
