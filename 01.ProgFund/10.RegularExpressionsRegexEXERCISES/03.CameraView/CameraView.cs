using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class CameraView 
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = nums[0] + nums[1];
            int skipNumber = nums[0];
            int takeNumber = nums[1];

            string pattern = $@"(?<=\|<)\w+";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            string[] allResults = new string[matches.Count];
            int index = 0;
            foreach (Match match in matches)
            {
                var currentMatch = match.ToString().Skip(skipNumber).Take(takeNumber).ToArray();
                string currentResult = string.Join("", currentMatch);
                allResults[index++] = currentResult;
            }

            Console.WriteLine(string.Join(", ", allResults));
        }
    }
}
