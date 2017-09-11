using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp4
{
    public class MainViewModel:BaseModel
    {
            
        public ObservableCollection<Product> Product { get; set; }
        public Product SelectedProduct { get; set; }

        public MainViewModel()

        {
            Product = new ObservableCollection<Product>
                {
                    new Product {Name="Barack", Price=10, Quantity=12},
                   
            };
        }
    }
}

