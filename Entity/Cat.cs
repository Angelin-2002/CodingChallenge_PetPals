using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Cat : Pets
    {
        string catcolor;

        public string Catcolor { 
            get { return catcolor; } 
            set { catcolor = value; } 
        }

        public Cat() { }

        public Cat(int petID, string name, string species, int age, string breed, int availableForAdoption, string catcolor) : base(petID, name, species, age, breed, availableForAdoption)
        {
            Catcolor = catcolor;
        }

        public override string ToString()
        {
            return $"{PetID},{Name},{Species},{Age},{Breed},{AvailableForAdoption},{Catcolor}";
        }
    }
}
