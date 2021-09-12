using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class User
    {
        private UserConfig[] _users = new UserConfig[3];
        public UserConfig Users()
        {
            string[] names = { "Karen", "Emily", "Tatyana" };
            string[] emails = { "karen.fibonacci@gmail.com", "emilythecat@gmail.com", "tatyanapetrenko@ukr.net" };
            string[] numbers = { "+12345678", "+87654321", "+380123456" };
            Currency[] currencies = { Currency.EUR, Currency.USD, Currency.UAH };
            for (var i = 0; i < 3; i++)
            {
                _users[i] = new UserConfig() { Name = names[i], Email = emails[i], Number = numbers[i], Currency = currencies[i] };
            }

            return _users[new Random().Next(0, 3)];
        }
    }
}