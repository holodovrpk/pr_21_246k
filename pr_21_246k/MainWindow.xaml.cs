using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr_21_246k
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products = new List<Product>();


        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product { Name = "Товар 1", Count = 5, Price = 150});
            products.Add(new Product { Name = "Товар 2", Count = 54, Price = 2150 });
            products.Add(new Product { Name = "Товар 3", Count = 55, Price = 5150 });
            products.Add(new Product { Name = "Товар 4", Count = 75, Price = 850 });


            tableProduct.ItemsSource = products;
        }




    }
}