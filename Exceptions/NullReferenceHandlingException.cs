using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Exceptions
{
    internal class NullReferenceHandlingException :Exception
    {
        public NullReferenceHandlingException(string message) : base(message) { }

        public void NullReferencePet(string name, int? age)
        {
            if (name == null || age == null)
            {
                throw new NullReferenceHandlingException("Information is missing");
            }
        }
    }
}
