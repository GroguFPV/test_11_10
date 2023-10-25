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
using System.Windows.Navigation;
using System.Windows.Shapes;
using test.Comp.Pages;
using test.Comp;

namespace test.Comp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autoriz.xaml
    /// </summary>
    public partial class Autoriz : Page
    {
        public Autoriz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {                
            NavigationService.Navigate(new ListPage());
        }

        private void Button_Click_Admin(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Password == "0000")
            {
                App.isAdmin = true;
                NavigationService.Navigate(new ListPage());

            }
        }
    }
}
