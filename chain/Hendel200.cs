using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain
{
    public class Hendel200 : BaseHendler
    {
        public override void HandelRequest(int amount)
        {
            if (amount >= 200)
            {
                Console.WriteLine($"Giving 200 {amount / 200}");
            }
            if (amount % 200 > 0)
            {
                if (next != null)
                {
                    next.HandelRequest(amount % 200);
                }
            }
        }
    }
}
