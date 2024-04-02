using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Member
    {
        public int MemberID { get; set; }
        public string Membername { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public Member()
        {
        }

        // Parameterized Constructor
        public Member(int memberID, string membername, string email, string phoneNumber, string password)
        {
            MemberID = memberID;
            Membername = membername;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        // ToString method
        public override string ToString()
        {
            return $"UserID: {MemberID}, Username: {Membername}, Email: {Email}, PhoneNumber: {PhoneNumber},Password: {Password}";
        }
    }
}
