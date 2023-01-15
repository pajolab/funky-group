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
        public KupiKartu()
        {
            InitializeComponent();
            DodajMjesta();
            DodajDatume();
            DodajTermine();
        }

        private void DodajMjesta()
        {
            List<string> Mjesta = Properties.Resources.Mjesta.Split('\n').ToList();
            foreach (string Mjesto in Mjesta)
            {
                cbxMjestoPolaska.Items.Add(Mjesto);
                cbxMjestoDolaska.Items.Add(Mjesto);
            }
        }

        private void DodajDatume()
        {
            List<string> Datumi = Properties.Resources.Datum.Split('\n').ToList();
            foreach (string Datum in Datumi)
            {
                cbxDatumOdlaska.Items.Add(Datum);
            }
        }
        private void DodajTermine()
        {
            List<string> Termini = Properties.Resources.Termini.Split('\n').ToList();
            foreach (string Termin in Termini)
            {
                cbxTermin.Items.Add(Termin);
            }
        }
        private void btnKupi_Click(object sender, RoutedEventArgs e)
        {
            if (cbxMjestoPolaska.SelectedIndex < 0 || cbxMjestoDolaska.SelectedIndex < 0 || cbxDatumOdlaska.SelectedIndex < 0 || cbxTermin.SelectedIndex < 0)
            {
                return;
            }
            this.Close();
        }
    }
}
