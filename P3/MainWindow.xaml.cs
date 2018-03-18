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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime time;

        public MainWindow()
        {
            InitializeComponent();
            this.time = DateTime.Now;
            this.dateText.Text = time.ToString("d MMM yyyy");
        }

        private void newApptButton_Click(object sender, RoutedEventArgs e)
        {
            NewApptWindow newApptWindow = new NewApptWindow();
            newApptWindow.Show();
        }

        private void patientsButton_Click(object sender, RoutedEventArgs e)
        {
            
                PatientsWindow patientsWindow = new PatientsWindow();
                patientsWindow.Show();
            

           /* 
            * PatientInfo patientinfo = new PatientInfo();
            patientinfo.Show();
            */
        }

        private void sampleApptButton_Click(object sender, RoutedEventArgs e)
        {
            ApptWindow apptWindow = new ApptWindow();
            apptWindow.Show();
        }
    }
}
