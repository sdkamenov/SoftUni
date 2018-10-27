using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string sourceFile = "..//..//..//..//files//copyMe.png";
            string outputFile = "..//..//..//..//files//copyMe-COPY.png";

            using (FileStream readFile = new FileStream(sourceFile, FileMode.Open))
            {
                var size = readFile.Length;
                byte[] buffer = new byte[size];

                readFile.Read(buffer, 0, buffer.Length);

                using (FileStream writeFile = new FileStream(outputFile, FileMode.Create))
                {
                    writeFile.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
