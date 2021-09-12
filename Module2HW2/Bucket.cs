using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Bucket
    {
        private static double _totalPrice = 0;
        public void Price()
        {
            var bucketService = new BucketService();
            for (var i = 0; i < 10; i++)
            {
                var temp = bucketService.GetProduct(i);
                if (temp != null)
                {
                    _totalPrice += temp.Price;
                }
            }
        }

        public double GetPrice()
        {
            return _totalPrice;
        }
    }
}
