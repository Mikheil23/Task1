using System;
using System.Collections.Generic;
using System.Linq;

namespace Satestofaili5_
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileWorker textFileWorker = new TextFileWorker(1024);
            Console.WriteLine($"File Extension: {textFileWorker.FileExtension}");
            textFileWorker.Read();
            textFileWorker.Write();
            textFileWorker.Edit();
            textFileWorker.Delete();

        }
    }
}