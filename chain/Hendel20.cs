using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain
{
    public class Hendel20 : BaseHendler
    {
        public override void HandelRequest(int amount)
        {
            if (amount >= 20)
            {
                Console.WriteLine($"Giving 20 { amount / 20}");
            }
            if (amount % 20 > 0)
            {
                if (next != null)
                {
                    next.HandelRequest(amount % 20);
                }
            }
        }
    }
}
