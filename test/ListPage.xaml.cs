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
using test.Comp;
using test.Comp.Pages;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public ListPage()
        {
            InitializeComponent();
            if (App.isAdmin == false)
            {
                AddBut.Visibility = Visibility.Collapsed;
            }
            
            IEnumerable<Product> ProductList = App.db.Product;
            foreach (var product in ProductList)
            {
                ProductWP.Children.Add(new ProductUC(product));
            }
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProduct());
        }
    }
}
