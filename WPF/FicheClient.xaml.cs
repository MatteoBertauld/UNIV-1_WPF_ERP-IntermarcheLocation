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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FicheClient : Window
    {
        bool clientSelectionner;
        bool creerNouveauClient;


        public FicheClient()
        {
            InitializeComponent();
            ClientSelectionner = true;
        }

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
            if(CreerNouveauClient)
            {
                ClientSelectionner = true;
            }

            if (ClientSelectionner)
            {
                DialogResult = true;
            }
            else
            {
                Console.WriteLine("Erreur : Aucun cliet n'est séléctionner");
            }
        }
    }
}
