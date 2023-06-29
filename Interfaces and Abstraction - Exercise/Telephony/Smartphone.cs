using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    internal class Smartphone : Iphonable, IBrowseable
    {
        private string phoneNumber;
        private string url;
      


        public string Browse(string url)
        {
            if (url.Any( char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }
           else return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (phoneNumber.Any(c => !char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number!");
            }
            else return $"Calling... {phoneNumber}";
        }
    }
}
