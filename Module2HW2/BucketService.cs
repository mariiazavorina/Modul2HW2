using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class BucketService
    {
        private static ProductService[] _products = new ProductService[10];
        public ProductService[] Products
        {
            get
            {
                return _products;
            }
        }

        public ProductService GetProduct(int i)
        {
            return _products[i];
        }
    }
}
