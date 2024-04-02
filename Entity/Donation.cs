using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    public abstract class Donation
    {
        string donorName;
        decimal amount;

        public Donation() { }

        public Donation(string donorName, decimal amount)
        {
            this.donorName = donorName;
            this.amount = amount;
        }
    }
}
