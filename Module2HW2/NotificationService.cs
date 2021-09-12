using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class NotificationService
    {
        public void TypeofNotification(UserConfig user, double price, Currency currency)
        {
            if (user.Email != null)
            {
                var emailService = new EmailService();
                emailService.EmailNotify(user, price, currency);
            }
            else
            {
                var smsService = new SmsService();
                smsService.SMSNotify(user, price, currency);
            }
        }
    }
}
