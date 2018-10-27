using System;
using System.Collections.Generic;
using System.IO;

namespace SlicingFile
{
    class SlicingFile
    {
        static List<string> paths;

        static void Main(string[] args)
        {
            paths = new List<string>();
            string sourceFile = "..//..//..//..//files//sliceMe.mp4";
            string outputDir = "..//..//..//..//files//";
            string outputAssemble = "..//..//..//..//files//assemble.mp4";
            int parts = 5;

            Slice(sourceFile, outputDir, parts);
            Assemble(paths, outputAssemble);


        }

        private static void Assemble(List<string> slicedFiles, string destinationDir)
        {
            for (int i = 0; i < slicedFiles.Count; i++)
            {
                FileStream source = new FileStream(slicedFiles[i], FileMode.Open);
                FileStream destination = new FileStream(destinationDir, FileMode.Append);
                using (source)
                {
                    using (destination)
                    {
                        byte[] buffer = new byte[source.Length];
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }

        private static void Slice(string source, string destinationDir, int pieces)
        {
            FileStream fileReader = new FileStream(source, FileMode.Open, FileAccess.Read);
            using (fileReader)
            {
                double fileSize = Math.Ceiling((double)fileReader.Length / pieces);
                for (int i = 1; i <= pieces; i++)
                {
                    FileStream fileWriter = new FileStream(destinationDir + $"part{i}.mp4", FileMode.Create);
                    using (fileWriter)
                    {
                        byte[] buffer = new byte[(int)fileSize];
                        int readBytes = fileReader.Read(buffer, 0, buffer.Length);
                        fileWriter.Write(buffer, 0, readBytes);
                        paths.Add(destinationDir + $"part{i}.mp4");
                    }
                }
            }
        }
    }
}
