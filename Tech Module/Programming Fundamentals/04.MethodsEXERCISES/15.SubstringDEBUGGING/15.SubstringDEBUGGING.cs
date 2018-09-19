using System;

namespace SubstringDEBUGGING
{
    class SubstringDEBUGGING
    {
        static void Main(string[] args)
        {
            //Code to fix:

            //string text = Console.ReadLine();
            //int jump = int.Parse(Console.ReadLine());

            //const char Search = 'р';
            //bool hasMatch = false;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == Search)
            //    {
            //        hasMatch = true;

            //        int endIndex = jump;

            //        if (endIndex > text.Length)
            //        {
            //            endIndex = text.Length;
            //        }

            //        string matchedString = text.Substring(i, endIndex);
            //        Console.WriteLine(matchedString);
            //        i += jump;
            //    }
            //}

            //if (!hasMatch)
            //{
            //    Console.WriteLine("no");
            //}

            string input = Console.ReadLine();
            int step = int.Parse(Console.ReadLine());

            char key = 'p';
            bool hasMatch = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == key)
                {
                    hasMatch = true;

                    if (step + i + 1 > input.Length)
                    {
                        Console.WriteLine(input.Substring(i));
                    }
                    else
                    {
                        Console.WriteLine(input.Substring(i, step + 1));
                    }

                    i += step;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
