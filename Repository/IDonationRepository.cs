using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Repository
{
    public class IDonationRepository : DonationRepository
    {
        public override void RecordDonation(CashDonation donation)
        {
            donations.Add(donation);
            Console.WriteLine("Donation recorded successfully");
        }
    }
}
