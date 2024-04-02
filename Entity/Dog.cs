using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Dog : Pets
    {
        string dogbreed;

        public string Dogbreed { 
            get { return dogbreed; } 
            set { dogbreed = value; } 
        }

        public Dog() { }

        public Dog(int petID, string name, string species, int age, string breed, int availableForAdoption, string dogbreed) : base(petID, name, species, age, breed, availableForAdoption)
        {
            Dogbreed = dogbreed;
        }

        public override string ToString()
        {
            return $"{PetID} {Name} {Species} {Age} {Breed} {AvailableForAdoption}{Dogbreed}";
        }
    }
}
 