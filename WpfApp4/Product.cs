using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class Product
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChange();
            }
        }


        public double Price { get; set; }
        public double Quantity { get; set; }
    }

}
