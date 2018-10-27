using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string textPath = "..//..//..//..//files//text.txt";
            using (StreamReader streamReader = new StreamReader(textPath))
            {
                var line = streamReader.ReadLine();
                int counter = 0;

                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                    line = streamReader.ReadLine();
                }
            }
        }
    }
}
