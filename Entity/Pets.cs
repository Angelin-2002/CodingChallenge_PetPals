using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Pets
    {
        int petID;
        string name;
        string species;
        int age;
        string breed;
        int availableForAdoption;

        public int PetID { 
            get { return petID; } 
            set { petID = value; } 
        }
        public string Name { 
            get { return name; } 
            set { name = value; } 
        }

        public string Species { 
            get { return species; } 
            set { species = value; } 
        }

        public int Age { 
            get { return age; } 
            set { age = value; } 
        }
        public string Breed { 
            get { return breed; } 
            set { breed = value; } 
        }

        public int AvailableForAdoption { 
            get { return availableForAdoption; } 
            set { availableForAdoption = value; } 
        }

        public Pets() { }

        public Pets(int petID, string name, string species, int age, string breed, int availableForAdoption)
        {
            PetID = petID;
            Name = name;
            Species = species;
            Age = age;
            Breed = breed;
            AvailableForAdoption = availableForAdoption;
        }

        public override string ToString()
        {
            return $"{PetID} {Name} {Species} {Age} {Breed} {AvailableForAdoption} ) ";
        }
    }
}
