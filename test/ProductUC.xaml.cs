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
using test.Comp;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для ProductUC.xaml
    /// </summary>
    public partial class ProductUC : UserControl
    {
        private Product product;
        public ProductUC(Product product)
        {
            InitializeComponent();
            if (App.isAdmin == false)
            {
                DelBut.Visibility = Visibility.Collapsed;
            }
           
            TitleTb.Text = product.Title;
            CostTb.Text = product.Cost.ToString("N0");
            
            DisTb.Text = product.DiscountStr;
            CostTb.Visibility = product.GetVisibility;
            CostDtb.Text = product.costTimeStr;


        }

        private void DelBut_Click(object sender, RoutedEventArgs e)
        {
            App.db.Product.Remove(product);
            App.db.SaveChanges();
            

        }
    }
}
