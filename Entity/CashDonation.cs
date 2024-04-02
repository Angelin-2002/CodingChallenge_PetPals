using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    public class CashDonation : Donation
    {
        public DateTime DonationDate { get; }



        public CashDonation(string donorName, decimal amount, DateTime donationDate) : base(donorName, amount)
        {
            DonationDate = donationDate;
        }


    }
}
