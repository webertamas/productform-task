using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class ProductFormViewModel:BaseModel
    {
        public Product Product { get; internal set; }

        public bool Validate()
        {
            return Product.Name != null &&
                Product.Name.Length > 4 &&
                Product.Price > 0 &&
                Product.Quantity > 0;
        }
    }
}
