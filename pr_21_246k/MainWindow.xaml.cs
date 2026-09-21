using System.Collections.ObjectModel;
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
        ObservableCollection<Product> products = 
            new ObservableCollection<Product>();


        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product { Name = "Товар 1", Count = 5, Price = 150});
            products.Add(new Product { Name = "Товар 2", Count = 54, Price = 2150 });
            products.Add(new Product { Name = "Товар 3", Count = 55, Price = 5150 });
            products.Add(new Product { Name = "Товар 4", Count = 75, Price = 850 });


            tableProduct.ItemsSource = products;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            int price = Convert.ToInt32(txtPrice.Text);
            int count = Convert.ToInt32(txtCount.Text);

            products.Add(new Product { Name = name, 
                Count = count, 
                Price = price });
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (tableProduct.SelectedItem is Product p)
            {
                MessageBoxResult q = MessageBox.Show("Вы точно хотите удалить?",
                    "Удаление",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (q == MessageBoxResult.Yes) 
                    products.Remove(p);
            }
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).DataContext is Product p)
            {
                if (p.Count > 0)
                    p.Count -= 1;
                else
                    MessageBox.Show("Товар закончился");


                tableProduct.ItemsSource = null;
                tableProduct.ItemsSource = products;
            }

        }
    }
}