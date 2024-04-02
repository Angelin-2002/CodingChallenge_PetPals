using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class PetShelter
    {
        public List<Pets> availablePets;

        public PetShelter()
        {
            availablePets = new List<Pets>();
        }
    }
}
