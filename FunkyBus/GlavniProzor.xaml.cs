﻿using System;
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
    /// Interaction logic for GlavniProzor.xaml
    /// </summary>
    public partial class GlavniProzor : Window
    {
        List<Karta> Karte = new List<Karta>();
        public GlavniProzor()
        {
            InitializeComponent();
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
            } //Provjera da li je korisnik kupio kartu, ako je onda se karta dodaje u listu kupljenih karata
        }
    }
}
