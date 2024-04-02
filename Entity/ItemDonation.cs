using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class ItemDonation : Donation
    {
        string itemType;

        public string ItemType { get { return itemType; } set { itemType = value; } }

        public ItemDonation(string donorName, decimal amount, string itemType) : base(donorName, amount)
        {
            ItemType = itemType;
        }

        public void RecordDonation(object DonorName, object Amount)
        {
            Console.WriteLine($"Recorded item donation of {ItemType} from {DonorName}. Donation amount: {Amount:C}");
        }
    }
}
