using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class OrderService
    {
        public void OrderProducts(UserConfig user)
        {
            var bucket = new Bucket();
            var notify = new NotificationService();
            double totalPrice = bucket.GetPrice();
            if (user.Currency == Currency.UAH)
            {
                var currencyConfig = new CurrencyConfig();
                double convertedPrice = currencyConfig.ConvertToUAH(totalPrice);
                notify.TypeofNotification(user, convertedPrice, Currency.UAH);
            }
            else if (user.Currency == Currency.EUR)
            {
                var currencyConfig = new CurrencyConfig();
                double convertedPrice = currencyConfig.ConvertToEUR(totalPrice);
                notify.TypeofNotification(user, convertedPrice, Currency.EUR);
            }
            else
            {
                notify.TypeofNotification(user, totalPrice, Currency.USD);
            }
        }
    }
}
