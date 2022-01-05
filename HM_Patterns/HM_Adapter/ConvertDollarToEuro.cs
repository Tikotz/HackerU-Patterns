using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Adapter
{
    public class ConvertDollarToEuro : PaymentInDollar
    {
        private PaymentInEuro CTEuro = new PaymentInEuro();

        public double DollarPayment(double Money)
        {
            return CTEuro.EuroPayment((int)Money);
        }
    }
}
