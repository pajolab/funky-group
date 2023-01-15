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
    /// Interaction logic for Prijava.xaml
    /// </summary>
    public partial class Prijava : Window
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, RoutedEventArgs e)
        {
            if (!Karta.Registracija(txtIme.Text, txtLozinka.Text))
            {
                MessageBox.Show("Provjerite unos.");
                return;
            }
            GlavniProzor Prozor_Glavni = new GlavniProzor(txtIme.Text);
            Visibility = Visibility.Hidden;
            Prozor_Glavni.ShowDialog();
        }
    }
}
