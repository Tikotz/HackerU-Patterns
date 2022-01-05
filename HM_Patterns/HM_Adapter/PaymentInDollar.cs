using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Adapter
{
    public class PaymentInDollar
    {
        public double DollarPayment(double Money)
        {
            return Money * 3.5;
        }
    }
}
