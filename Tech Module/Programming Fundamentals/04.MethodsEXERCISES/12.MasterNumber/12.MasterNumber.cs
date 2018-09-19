using System;

namespace MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool isPalindrom = IsPalindrome(i);
                bool isDivisible = IsDivisible(i);
                bool containsEvenDigit = ContainsEvenDigit(i);

                bool isMaster = isPalindrom &&
                    isDivisible &&
                    containsEvenDigit;

                if (isMaster)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int number)
        {
            bool containsEvenDigit = false;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit %2 == 0)
                {
                    containsEvenDigit = true;
                    break;
                }
                number /= 10;
            }
            return containsEvenDigit;
        }

        private static bool IsDivisible(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            bool isDivisible = sum % 7 == 0;
            return isDivisible;
        }

        private static bool IsPalindrome(int number)
        {
            string reversed = string.Empty;
            string numberAsString = number.ToString();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                reversed += numberAsString[i];
            }

            bool isPalindrome = numberAsString == reversed;
            return isPalindrome;
        }
    }
}
