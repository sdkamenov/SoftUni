using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string patternt = @"(?<=\s)[a-zA-Z1-9]+([.\-_][a-zA-Z1-9]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-Za-z]+)+";
            Regex regex = new Regex(patternt);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            //MatchCollection matches = Regex.Matches(input, patternt);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
