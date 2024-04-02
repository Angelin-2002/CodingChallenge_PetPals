using PetPals.Entity;
using PetPals.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Service
{
    internal class PetShelterService
    {
        private readonly PetShelterRepository repository;

        public PetShelterService()
        {
            repository = new PetShelterRepository();
        }

        public void InsertPet(Pets pet)
        {

            repository.addPet(pet);
        }

        public void DeletePet(int p_id)
        {
            repository.RemovePet(p_id);
        }

        public void AvailablePets(int avail_status)
        {
            repository.ListAvailablePets(avail_status);
        }
    }
}
