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
using System.IO;

namespace FunkyBus
{
    /// <summary>
    /// Interaction logic for KupiKartu.xaml
    /// </summary>
    public partial class KupiKartu : Window
    {
        //Globalne varijable
        public Karta NovaKarta = new Karta();
        public bool KupljenaKarta = false;

        public KupiKartu()
        {
            InitializeComponent();
            DodajMjesta();
            DodajDatume();
            DodajTermine();
        }

        //Dodavamo mjesta u ComboBox za Mjesta
        private void DodajMjesta()
        {
            //Čitamo iz datoteke i pretvaramo to u listu
            //Ovo u buduće zamijeniti sa API-om
            List<string> Mjesta = Properties.Resources.Mjesta.Split('\n').ToList();
            foreach (string Mjesto in Mjesta)
            {
                //Dodavamo mjesta u ComboBoxove za mjesto polaska i mjesto dolaska
                cbxMjestoPolaska.Items.Add(Mjesto);
                cbxMjestoDolaska.Items.Add(Mjesto);
            }
        }

        //Dodavamo datume u ComboBox za Datume
        private void DodajDatume()
        {
            //Čitamo iz datoteke i pretvaramo to u listu
            //Ovo u buduće zamijeniti sa API-om
            List<string> Datumi = Properties.Resources.Datum.Split('\n').ToList();
            foreach (string Datum in Datumi)
            {
                cbxDatumOdlaska.Items.Add(Datum); //Dodajemo datum u njegov ComboBox
            }
        }
        //Dodavamo termine u ComboBox za termine
        private void DodajTermine()
        {
            //Čitamo iz datoteke i pretvaramo to u listu
            //Ovo u buduće zamijeniti sa API-om
            List<string> Termini = Properties.Resources.Termini.Split('\n').ToList();
            foreach (string Termin in Termini)
            {
                cbxTermin.Items.Add(Termin); //Dodavamo termin u njegov ComboBox
            }
        }
        //Kada se stisne dugme Kupi Kartu
        private void btnKupi_Click(object sender, RoutedEventArgs e)
        {
            if (cbxMjestoPolaska.SelectedIndex < 0 || cbxMjestoDolaska.SelectedIndex < 0 || cbxDatumOdlaska.SelectedIndex < 0 || cbxTermin.SelectedIndex < 0)
            {
                return;
            } //Provjeravamo je li neki ComboBox nema odabira, ako nema prekidamo daljno izvršavanje
            //Dodajemo atributima varijabli od klase Karta vrijednosti
            NovaKarta.mjestoPolaska = cbxMjestoPolaska.SelectedItem.ToString();
            NovaKarta.mjestoDolaska = cbxMjestoDolaska.SelectedItem.ToString();
            NovaKarta.datumOdlaska = cbxDatumOdlaska.SelectedItem.ToString();
            NovaKarta.Termin = cbxTermin.SelectedItem.ToString();
            NovaKarta.Destinacija = NovaKarta.mjestoPolaska + " - " + NovaKarta.mjestoDolaska;
            KupljenaKarta = true; //Da znamo hoćemo li nešto dodavati u našu listu sa svim kupljenim kartama
            this.Close();
        }
    }
}
