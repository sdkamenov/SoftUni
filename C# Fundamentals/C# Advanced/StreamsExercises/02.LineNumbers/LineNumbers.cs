using System;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string sourceFile = "..//..//..//..//files//text.txt";
            string outputFile = "..//..//..//..//files//output.txt";

            using (StreamReader streamReader = new StreamReader(sourceFile))
            {
                using (StreamWriter streamWriter = new StreamWriter(outputFile))
                {
                    var line = streamReader.ReadLine();
                    int counter = 1;
                    while (line != null)
                    {
                        streamWriter.WriteLine($"Line {counter}: {line}");
                        counter++;
                        line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}
