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

namespace P3
{
    /// <summary>
    /// Interaction logic for NewApptWindow.xaml
    /// </summary>
    public partial class NewApptWindow : Window
    {
        public NewApptWindow()
        {
            InitializeComponent();
        }

        private void txtNameToSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNameToSearch_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void NewPatient_Click(object sender, RoutedEventArgs e)
        {
            NewPatientsWindow patientWindow = new NewPatientsWindow(true);
            patientWindow.Owner = this.Owner;
            this.Close();
            patientWindow.Show();
        }
        private void PatientA_Selected(object sender, RoutedEventArgs e)
        {
            NewApptMonth apptmonthWindow = new NewApptMonth();
            apptmonthWindow.Owner = this.Owner;
            this.Close();
            apptmonthWindow.Show();
        }
    }
}
