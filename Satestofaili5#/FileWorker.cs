using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Satestofaili5_
{
    
    public abstract class FileWorker
    {        
    protected long MaxFileSize { get; }

        public abstract string FileExtension { get; }

        protected FileWorker(long maxFileSize)
        {
            MaxFileSize = maxFileSize;
        }

        public virtual void Read()
        {
            Console.WriteLine("I can read from txt file with max storage 128");
        }

        public virtual void Write()
        {
            Console.WriteLine("I can write to txt file with max storage 128");
        }

        public virtual void Edit()
        {
            Console.WriteLine("I can edit txt file with max storage 128");
        }

        public virtual void Delete()
        {
            Console.WriteLine("I can delete from txt file with max storage 128");
        }
    }

    public class TextFileWorker : FileWorker
    {
        public override string FileExtension => ".txt";

        public TextFileWorker(long maxFileSize) : base(maxFileSize) { }

        public override void Read()
        {
            Console.WriteLine("Reading a text file...");
        }

        public override void Write()
        {
            Console.WriteLine("Writing to a text file...");
        }
    }

}

