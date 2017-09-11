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
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for ProductFormWindow.xaml
    /// </summary>
    public partial class ProductFormWindow : Window
    {
        public ProductFormWindow()
        {
            InitializeComponent();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            String textName = nameTextBox.Text;
            int error;
            
            if (string.IsNullOrEmpty(textName))
            {
                MessageBox.Show("Nem írtál nevet", "Hiba!");
                return;
            }
            if (!(int.TryParse(priceTextBox.Text, out error)))
            {
                MessageBox.Show("Az ár csak szám lehet", "Hiba!");
                return;
            }
            if (int.Parse(priceTextBox.Text) == 0)
            {
                MessageBox.Show("Az ár nullánál nagyobb legyen", "Hiba!");
                return;
            }
            if (!(int.TryParse(quantityTextBox.Text, out error)))
            {
                MessageBox.Show("A mennyiség csak szám lehet", "Hiba!");
                return;
            }
            if (int.Parse(quantityTextBox.Text) == 0)
            {
                MessageBox.Show("A mennyiség nullánál nagyobb legyen", "Hiba!");
                return;
            }
            DialogResult = false;
        }
    }
}
