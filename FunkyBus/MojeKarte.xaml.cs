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
    /// Interaction logic for MojeKarte.xaml
    /// </summary>
    public partial class MojeKarte : Window
    {
        //Globalna varijabla koja je kopija glavne varijable sa svim korisnikovim kartama
        List<Karta> KorisnikoveKarte = new List<Karta>();
        public MojeKarte(List<Karta> Karte)
        {
            InitializeComponent();
            DodajKarte(Karte);
            KorisnikoveKarte = Karte; //Kopiranje originalne varijable u globalnu za ovaj Prozor
        }

        //Dodavamo karte u ComboBox
        private void DodajKarte(List<Karta> Karte)
        {
            if (Karte.Count > 0) //Ako je korisnik uzeo barem 1 kartu, karte se dodavaju u ComboBox
            {
                foreach (Karta karta in Karte)
                {
                    cbxKarte.Items.Add(karta.Destinacija);
                }
            }
        }

        //Kada se promijeni odabir kupljene karte, izvrši radnju
        private void cbxKarte_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxKarte.SelectedIndex < 0)
            {
                return;
            }
            string temp;
            try //Pokušava staviti odabranu kartu kao string
            {
                temp = cbxKarte.SelectedItem.ToString();
            }
            catch
            {
                return;
            }
            foreach (Karta karta in KorisnikoveKarte) //Traži kartu koja ima destinaciju
            {
                if (karta.Destinacija == temp)
                {
                    //Kada ju je našao, ispisuje na labelu destinaciju, datum i termin
                    txtKod.Content = karta.Destinacija;
                    txtDatum.Content = karta.datumOdlaska;
                    txtTermin.Content = karta.Termin;
                    break; //Da se foreach ne vrti bezveze
                }
            }
        }
    }
}
 
