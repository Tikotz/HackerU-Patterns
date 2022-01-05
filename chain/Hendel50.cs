using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain
{
    public class Hendel50 : BaseHendler
    {
        public override void HandelRequest(int amount)
        {
            if (amount >= 50)
            {
                Console.WriteLine($"Giving 50 { amount / 50}");
            }
            if (amount % 50 > 0)
            {
                if (next != null)
                {
                    next.HandelRequest(amount % 50);
                }
            }
        }
    }
}
