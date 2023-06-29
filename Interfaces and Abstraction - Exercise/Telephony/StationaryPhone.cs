using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : Iphonable
    {
        private string phoneNumber;



        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number!");
            }
            else return $"Dialing... {phoneNumber}";
        }
    }
}
