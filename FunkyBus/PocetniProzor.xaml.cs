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

namespace FunkyBus
{
    /// <summary>
    /// Interaction logic for PocetniProzor.xaml
    /// </summary>
    public partial class PocetniProzor : Window
    {
        public PocetniProzor()
        {
            InitializeComponent();
        }

        //Otvori prozor za prijavu
        private void btnPrijava_Click(object sender, RoutedEventArgs e)
        {
            Prijava Prozor_Prijava = new Prijava();
            Visibility = Visibility.Hidden;
            Prozor_Prijava.ShowDialog();
            Prozor_Prijava.Close();
            Visibility = Visibility.Visible;
        }

        //Otvori prozor za registraciju
        private void btnRegistracija_Click(object sender, RoutedEventArgs e)
        {
            Registracija Prozor_Registracija = new Registracija();
            Visibility = Visibility.Hidden;
            Prozor_Registracija.ShowDialog();
            Prozor_Registracija.Close();
            Visibility = Visibility.Visible;
        }
    }
}
