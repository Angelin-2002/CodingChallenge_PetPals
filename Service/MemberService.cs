using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Service
{
    internal class MemberService
    {
        public List<Member> MemberList = new List<Member>();


        public void Register(Member member)
        {
            if (!UserExists(member.Membername))
            {
                MemberList.Add(member);
            }
            else
            {
                Console.WriteLine("MemberName exists.Try Again!");
            }
        }

        public bool Login(string membername, string password)
        {
            Member member = FindUserByUsername(membername);
            if (member != null && member.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UserExists(string membername)
        {
            foreach (Member member in MemberList)
            {
                if (member.Membername.Equals(membername))
                {
                    return true;
                }
            }
            return false;
        }

        public Member FindUserByUsername(string membername)
        {
            foreach (Member member in MemberList)
            {
                if (member.Membername.Equals(membername))
                {
                    return member;
                }
            }
            return null;
        }
    }
}
