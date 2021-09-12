using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Starter
    {
        public void Run()
        {
            var product = new Product();
            product.Products();
            product.ChosenProducts();
            var bucket = new Bucket();
            bucket.Price();
            var user = new User();
            var chosenUser = user.Users();
            var orderService = new OrderService();
            orderService.OrderProducts(chosenUser);
        }
    }
}
