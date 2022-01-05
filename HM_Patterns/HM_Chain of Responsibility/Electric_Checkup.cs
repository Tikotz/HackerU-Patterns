using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Chain_of_Responsibility
{
    public class Electric_Checkup : Car
    {
        public override void Handle()
        {
            int Grade = new Random().Next(1, 11);
            if (Grade > 6)
            {
                IsOK = true;
                Console.WriteLine("The Car Is OK !");
            }
            else
            {
                if (next != null)
                {
                    Console.WriteLine("third Check is FAILED");
                    next.Handle();
                }
            }
        }
    }
}
