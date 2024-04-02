using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Exceptions
{
    internal class FileHandlingException :Exception
    {
        public FileHandlingException(string message) : base(message) { }

        public void FileNotFound(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new FileHandlingException($"File not found or cannot be read");
            }
        }
    }
}
