using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Proxy
{
    public class ServiceMachine : IServiceMechine
    {
        private InteriorOffice interiorOffice;

        public ServiceMachine(InteriorOffice interiorOffice)
        {
            this.interiorOffice = interiorOffice;
        }

        public void ChangeAddress()
        {
            Console.WriteLine("Address Updated ");
        }

        public void ChangePassword()
        {
            Console.WriteLine("Password changed");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"All Info...");
        }

        public void UpdatePassport()
        {
            Console.WriteLine("Enjoy New Passport");
        }
    }
}
