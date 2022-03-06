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

namespace ProductApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Products> products = new List<Products>();

            products.Add(new Products() { ProductID = 1, ProductName = "Coffee Powder", PackSize = "1 kg", Quantity = 15684 });
            products.Add(new Products() { ProductID = 2, ProductName = "Ground Coffee", PackSize = "500 g", Quantity = 22785 });
            products.Add(new Products() { ProductID = 3, ProductName = "Tea", PackSize = "500 g", Quantity = 8544 });
            products.Add(new Products() { ProductID = 4, ProductName = "Skimmed Milk", PackSize = "1 litre", Quantity = 28012 });
            products.Add(new Products() { ProductID = 5, ProductName = "Smoothie", PackSize = "400 ml", Quantity = 9346 });
            products.Add(new Products() { ProductID = 6, ProductName = "Beef Drink", PackSize = "750 g", Quantity = 7612 });

            

            ProductsList.ItemsSource = products; 

            
        }

        
    }
}
