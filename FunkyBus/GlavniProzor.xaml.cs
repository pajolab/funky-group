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
    /// Interaction logic for GlavniProzor.xaml
    /// </summary>
    public partial class GlavniProzor : Window
    {
        List<Karta> Karte = new List<Karta>();
        public GlavniProzor(string imeKorisnika)
        {
            InitializeComponent();
            PostojeceKarte();
            txtKorisnik.Content = imeKorisnika;
        }

        //Pokreće se kada se otvori GlavniProzor
        private void PostojeceKarte()
        {
            //Provjerava postoji li datoteka sa već kupljenim kartama
            if (File.Exists(Directory.GetCurrentDirectory() + @"\KorisnikoveKarte.txt"))
            {
                //Ako postoji, čita iz te datoteke liniju po liniju i ubacuje karte u listu Karte
                using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + @"\KorisnikoveKarte.txt"))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Karta tempKarta = new Karta();
                        string[] podijeljenaLinija = line.Split(',');
                        tempKarta.mjestoPolaska = podijeljenaLinija[0];
                        tempKarta.mjestoDolaska = podijeljenaLinija[1];
                        tempKarta.Destinacija = tempKarta.mjestoPolaska + " - " + tempKarta.mjestoDolaska;
                        tempKarta.datumOdlaska = podijeljenaLinija[2];
                        tempKarta.Termin = podijeljenaLinija[3];
                        Karte.Add(tempKarta);
                        line = sr.ReadLine();
                    }
                }
            }
        }

        //Otvori prozor sa kartama korisnika
        private void btnMojeKarte_Click(object sender, RoutedEventArgs e)
        {
            //Otvaramo prozor "Moje Karte" i prenosimo Listu sa svim korisnikovim kartama
            MojeKarte Prozor_MojeKarte = new MojeKarte(Karte);
            Prozor_MojeKarte.ShowDialog();
            Prozor_MojeKarte.Close();
        }

        //Otvori prozor za kupovanje karata
        private void btnKupi_Click(object sender, RoutedEventArgs e)
        {
            KupiKartu Prozor_KupiKartu = new KupiKartu();
            Prozor_KupiKartu.ShowDialog();
            
            Prozor_KupiKartu.Close();
            if (Prozor_KupiKartu.KupljenaKarta)
            {
                Karte.Add(Prozor_KupiKartu.NovaKarta);
            } //Provjera je li korisnik kupio kartu, ako je onda se karta dodaje u listu kupljenih karata
        }


        //Spremanje svih korisnikovih karata kada se izađe iz Glavnog Prozora
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Piše sve karte iz liste Karte u datoteku
            using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\KorisnikoveKarte.txt"))
            {
                foreach (Karta karta in Karte)
                {
                    sw.WriteLine(karta.mjestoPolaska + "," + karta.mjestoDolaska + "," + karta.datumOdlaska + "," + karta.Termin);
                }
            }
        }
    }
}
