using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class SmsService
    {
        public void SMSNotify(UserConfig user, double totalPrice, Currency currency)
        {
            Console.WriteLine($"{user.Name}, we are glad to help you with saving your beauty! Total price of your order: {Math.Round(totalPrice, 2)} {currency}. Number of the order: [№{new Random().Next(1000, 2000)}]");
        }
    }
}
