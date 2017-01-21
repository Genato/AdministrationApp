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

namespace AdministrationApp.Views
{
    /// <summary>
    /// Interaction logic for MainModule.xaml
    /// </summary>
    public partial class MainModule : Window
    {
        public MainModule()
        {
            //bool userLogin = false;

            //while (userLogin != true)
            //{
            //    LoginWindow loginWnd = new LoginWindow();
            //    userLogin = loginWnd.ShowDialog().Value;
            //}

            this.DataContext = new AdministrationApp.ViewModel.LoginViewModel();

            InitializeComponent();
        }
    }
}
