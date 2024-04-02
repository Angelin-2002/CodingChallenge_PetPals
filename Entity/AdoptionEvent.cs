using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class AdoptionEvent
    {
        int participantID;
        string participantName;
        int adoptedPetID;
        DateTime adoptionDate;
        public int ParticipantID
        {
            get { return participantID; }
            set { participantID = value; }
        }
        public string ParticipantName
        {
            get { return participantName; }
            set { participantName = value; }
        }
        public int AdoptedPetID
        {
            get { return adoptedPetID; }
            set { adoptedPetID = value; }
        }
        public DateTime AdoptionDate
        {
            get { return adoptionDate; }
            set { adoptionDate = value; }
        }

        public AdoptionEvent() { }

        public AdoptionEvent(int participantID,string participantName, int adoptedPetId, DateTime adoptionDate)
        {
            ParticipantID = participantID;
            ParticipantName=participantName;
            AdoptedPetID=adoptedPetId; 
            AdoptionDate = adoptionDate;
        }
    }
}
