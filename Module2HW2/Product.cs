using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Product
    {
        private ProductService[] _products = new ProductService[15];
        public void Products()
        {
            string[] names = { "Foundation", "Blush,", "Countour", "Consealer", "Brow gel", "Mascara", "Highlighter", "Eyeshadow", "Kajal", "Brow pencil", "Lipliner", "Lipgloss", "Powder,", "Eyeliner", "Lipstick" };
            for (var i = 0; i < 15; i++)
            {
                _products[i] = new ProductService() { ID = Guid.NewGuid(), Name = names[i], Price = new Random().Next(3, 20), Currency = Currency.USD };
            }
        }

        public void ChosenProducts()
        {
            var bucketService = new BucketService();
            for (var i = 0; i < new Random().Next(1, 11); i++)
            {
                var temp = new Random().Next(0, 15);
                bucketService.Products[i] = _products[temp];
            }
        }

        public ProductService FormBucket(int i)
        {
            return _products[i];
        }
    }
}
