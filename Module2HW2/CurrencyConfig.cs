using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class CurrencyConfig
    {
        public double ConvertToUAH(double price)
        {
            return price * 26.73;
        }

        public double ConvertToEUR(double price)
        {
            return price * 0.85;
        }
    }
}
