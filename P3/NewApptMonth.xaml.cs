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
    /// Interaction logic for NewApptMonth.xaml
    /// </summary>
    public partial class NewApptMonth : Window
    {
        public NewApptMonth()
        {
            InitializeComponent();

            Random rnd = new Random();

            for (int i = 0; i < 31; i++)
            {
                MonthDayBoxControl dayBox = new MonthDayBoxControl(i+1, rnd.Next(0,11), "Slot");
                dayBox.MouseLeftButtonDown += DayBox_MouseLeftButtonDown;
                this.uniformMonthGrid.Children.Add(dayBox);
            }
        }

        private void DayBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NewApptDay dayWindow = new NewApptDay();
            dayWindow.Show();
            this.Close();
        }
    }
}
