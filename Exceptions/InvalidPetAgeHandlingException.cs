using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Exceptions
{
    internal class InvalidPetAgeHandlingException :Exception
    {
        public InvalidPetAgeHandlingException(string message) : base(message) { }

        public void InvalidPetAge(int age)
        {
            if (age <= 0)
            {
                throw new InvalidPetAgeHandlingException("Age must be greater than zero");
            }
        }
    }
}
