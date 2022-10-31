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

namespace Wpf_Samkova_PR_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Random rand = new Random();
            InitializeComponent();
        }

        private void Sgen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(101);
            lab.Text = i.ToString();
        }

        private void Ugaday_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(lab.Text);
            int test = Convert.ToInt32(Chislo.Text);

            if ( i == test)
            {
                MessageBox.Show("Угадал, возьми с полки пиражок");
            }
            else if (i > test)
            {
                MessageBox.Show("Маленькое число, попробуй ещё раз");
            }
            else 
            {
                MessageBox.Show("Много хочешь, пробуй ещё");
            }
        }
    }
}
