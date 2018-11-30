using System;

namespace _04.Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();

            foreach (var number in phoneNumbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            foreach (var site in sites)
            {
                Console.WriteLine(smartphone.BrowseInWeb(site));
            }
        }
    }
}
