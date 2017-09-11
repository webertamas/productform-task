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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly List<Product> _products = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            var vm = new ProductFormViewModel
            {
                Product = new Product()
            };
            var form = new ProductFormWindow
            {
                DataContext = vm
            };
            form.ShowDialog();
            if(vm.Validate())
            {
                ((MainViewModel)DataContext)
                .Product
                .Add(vm.Product);

                                }

 
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            var target = ((MainViewModel)DataContext).SelectedProduct;
            if (target == null)
                return;
            var vm = new ProductFormViewModel
            {
                Product = target
            };
            var form = new ProductFormWindow
            {
                DataContext = vm
            };
            form.ShowDialog();

         
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            

            if ((MainViewModel)DataContext).SelectedProduct != null && MessageBox.Show("Biztosan szeretnéd törölni?","Törlés",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                _products.Remove(
                    (Product)(MainViewModel)DataContext).SelectedProduct;
                    );
                
            }

            else
            {
                MessageBox.Show("Nincs semmi kiválasztva");
            }
        }
    }
    }
}
