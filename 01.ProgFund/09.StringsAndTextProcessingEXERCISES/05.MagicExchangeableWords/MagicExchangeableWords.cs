using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();

            string[] input = Console.ReadLine().Split();
            string one = input[0];
            string two = input[1];

            int minL = Math.Min(input[0].Length, input[1].Length);
            bool isExchangeable = true;

            for (int i = 0; i < minL; i++)
            {
                if (dict.ContainsKey(one[i]) == false)
                {
                    if (dict.ContainsValue(two[i]) == false)
                    {
                        dict.Add(one[i], two[i]);
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }

                }
                else
                {
                    if (dict[one[i]] != two[i])
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            string rest = "";

            if (one.Length > two.Length)
            {
                rest = one.Substring(minL);
            }
            else
            {
                rest = two.Substring(minL);
            }

            foreach (char chara in rest)
            {
                if (dict.ContainsValue(chara) == false && dict.ContainsKey(chara) == false)
                {
                    isExchangeable = false;
                }
            }
            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}