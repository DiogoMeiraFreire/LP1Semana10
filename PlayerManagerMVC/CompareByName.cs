using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class CompareByName : IComparer<Player>
    {
        private bool Order { get; }
       
        public int Compare(Player p1, Player p2)
        {
            int result;

            if (!Order) { result = p2.Name.CompareTo(p1.Name); }
                
            else { result = p1.Name.CompareTo(p2.Name); }

            return result;
        }

        public CompareByName(bool nameOrder)
        {
            Order = nameOrder;
        }
    }
}