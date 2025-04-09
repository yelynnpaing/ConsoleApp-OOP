using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagementSystem__OOP_
{
    internal class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }

        public void DisplayMember()
        {
            Console.WriteLine($"Member Id - {MemberId} , Member Name {MemberName}");
        }
    }
}
