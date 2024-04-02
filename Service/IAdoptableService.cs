using PetPals.Entity;
using PetPals.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Service
{
    internal class IAdoptableService
    {
        private readonly IAdoptionRepository _repository;

        public IAdoptableService()
        {
            _repository = new IAdoptionRepository();
        }

        public void Addparticipant(AdoptionEvent participant)
        {
            _repository.RegisterParticipant(participant);
        }

        public void EventHost(string adoptionstatus)
        {
            _repository.GetAvailableParticpants(adoptionstatus);
        }
    }
}
