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
using System.IO;

namespace FunkyBus
{
    /// <summary>
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Window
    {
        public Registracija()
        {
            InitializeComponent();
        }


        private void btnKreiraj_Click(object sender, RoutedEventArgs e)
        {
            if (txtIme.Text.Length < 1)
            {
                MessageBox.Show("Korisnički ID nije unesen.");
                return;
            }
            if (txtLozinka.Text.Length < 1)
            {
                MessageBox.Show("Lozinka nije unesena.");
                return;
            }

            this.Close();
        }
    }
}
