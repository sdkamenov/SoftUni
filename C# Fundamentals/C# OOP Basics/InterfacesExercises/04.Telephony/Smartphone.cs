using _04.Telephony.Interfaces;
using System.Linq;

namespace _04.Telephony
{
    public class Smartphone : IPhone, IBrowsable
    {
        public string BrowseInWeb(string site)
        {
            if (site.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {site}!";
            }
        }

        public string Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                return $"Calling... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }
    }
}
