using System;
using System.Linq;

namespace IndexОfLetters
{
    class IndexОfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];      //  2  // not needed if
                                                 //  2  // using 2*
            int index = 0;                       //  2  //
            for (char i = 'a'; i <= 'z'; i++)    //  2  //
            {                                    //  2  //
                alphabet[index++] = i;           //  2  //
            }                                    //  2  //

            foreach (char letter in word)
            {
                //  1*  // int foundIndex = Array.IndexOf(alphabet, letter);
                //  2*  // int index = letter - 97;
                int foundIndex = IndexOf(alphabet, letter);  // 1 // not needed if using 1*

                Console.WriteLine($"{letter} -> {foundIndex}");
            }
        }

        private static int IndexOf(char[] alphabet, char letter)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
