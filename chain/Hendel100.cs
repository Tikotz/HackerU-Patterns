using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain
{
    public class Hendel100 : BaseHendler
    {
        public override void HandelRequest(int amount)
        {
            if (amount >= 100)
            {
                Console.WriteLine($"Giving 100 { amount / 100}");
            }
            if (amount % 100 > 0)
            {
                if (next != null)
                {
                    next.HandelRequest(amount % 100);
                }
            }
        }
    }
}
