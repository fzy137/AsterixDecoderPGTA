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

namespace AsterixDisplay
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void iniciatbut_Click(object sender, RoutedEventArgs e) // botón START
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // botón ABOUT US
        {
            AboutUs au = new AboutUs();
            au.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // botón HELP
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
