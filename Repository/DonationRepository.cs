using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Repository
{
    public abstract class DonationRepository
    {
            protected List<CashDonation> donations;

            public DonationRepository()
            {
                donations = new List<CashDonation>();
            }

            public abstract void RecordDonation(CashDonation donation);
        
    }

}
