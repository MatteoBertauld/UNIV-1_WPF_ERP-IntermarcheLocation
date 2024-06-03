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
    /// Logique d'interaction pour SeConnecter.xaml
    /// </summary>
    public partial class SeConnecter : Window
    {
        string identifiantSaisie;
        string motDePasseSaisie;


        public string IdentifiantSaisie
        {
            get
            {
                return identifiantSaisie;
            }

            set
            {
                identifiantSaisie = value;
            }
        }

        public string MotDePasseSaisie
        {
            get
            {
                return this.motDePasseSaisie;
            }

            set
            {
                this.motDePasseSaisie = value;
            }
        }


        public SeConnecter()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("Identifiant saisie : " + IdentifiantSaisie + "\nMot de passe Saisie : " + MotDePasseSaisie);

            if (IdentifiantSaisie == "bertaulm" && MotDePasseSaisie == "mdp")
            {
                Console.WriteLine("Connexion réussi");
                DialogResult = true;
            }
            Console.WriteLine("Connexion échoué");
        }

        private void TextBoxIdentifiant_TextChanged(object sender, TextChangedEventArgs e)
        {
            IdentifiantSaisie = TextBoxIdentifiant.Text;
        }

        private void TextBoxMotDePasse_TextChanged(object sender, TextChangedEventArgs e)
        {
            MotDePasseSaisie = TextBoxMotDePasse.Text;
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show(this,
                "Vérifier que l'identifiant et le mot de passe saisie correspond " +
                "; Ci cela ne marche toujours pas conctacter votre employeur", "Aide",
                    MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
