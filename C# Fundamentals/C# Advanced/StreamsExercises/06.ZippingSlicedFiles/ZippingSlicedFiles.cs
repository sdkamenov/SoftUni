using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace ZippingSlicedFiles
{
    class ZippingSlicedFiles
    {
        static List<string> paths;
        static void Main(string[] args)
        {
            paths = new List<string>();
            string sourceFile = "..//..//..//..//files//sliceMe.mp4";
            string outputDir = "..//..//..//..//files//";
            int pieces = 5;

            Slice(sourceFile, outputDir, pieces);
            Assemble(paths, outputDir);


        }

        private static void Assemble(List<string> slicedFiles, string destinationDir)
        {
            for (int i = 0; i < slicedFiles.Count; i++)
            {
                using (FileStream source = new FileStream(slicedFiles[i], FileMode.Open))
                {
                    using (GZipStream decompressStream = new GZipStream(source, CompressionMode.Decompress, false))
                    {
                        using (FileStream destination = new FileStream(destinationDir + "file.gz", FileMode.Append))
                        {
                            byte[] buffer = new byte[source.Length];
                            int readBytes = decompressStream.Read(buffer, 0, buffer.Length);
                            destination.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

        private static void Slice(string sourcePath, string destinationDirPath, int pieces)
        {
            
            using (FileStream fileReader = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            {
                double fileSize = Math.Ceiling((double)fileReader.Length / pieces);
                for (int i = 1; i <= pieces; i++)
                {
                    FileStream fileWriter = new FileStream(destinationDirPath + $"Part{i}.gz", FileMode.Create);
                    GZipStream compressStream = new GZipStream(fileWriter, CompressionMode.Compress, false);
                    using (fileWriter)
                    {
                        byte[] buffer = new byte[(int)fileSize];
                        int readBytes = fileReader.Read(buffer, 0, buffer.Length);
                        compressStream.Write(buffer, 0, readBytes);
                        paths.Add(destinationDirPath + $"Part{i}.gz");
                    }
                }
            }
        }
    }
}
